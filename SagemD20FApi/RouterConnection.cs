using HackSagemRouter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HackSagemRouter
{
    public class RouterConnection
    {
        private readonly Regex _regexDeviceInfo = new Regex(@"<tr><td>(.+?)<\/td><td>([0-9a-f]{2}:[0-9a-f]{2}:[0-9a-f]{2}:[0-9a-f]{2}:[0-9a-f]{2}:[0-9a-f]{2})<\/td><td>(\d+.\d+.\d+.\d+)<\/td><td>(.+?)<\/td><\/tr>", RegexOptions.Compiled);

        private readonly Regex RegexSeasionKey = new Regex("sessionKey=(\\d+)", RegexOptions.Compiled);
        private readonly HttpClient _httpClient;
        private readonly HttpClientHandler _handler;

        public RouterConnection(Uri uri, AuthenticationHeaderValue auth)
        {
            // https://www.thomaslevesque.com/tag/httpmessagehandler/
            // HttpMessageHandler
            // DelegatingHandler

            _handler = new HttpClientHandler()
            {
                CookieContainer = new CookieContainer(),
                AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip,
                UseCookies = true
            };
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
            //_cookieContainer.Add(baseAddress, new Cookie("sagem", "sagem_value"));
            _httpClient = new HttpClient(_handler) { BaseAddress = uri };
            _httpClient.DefaultRequestHeaders.Authorization = auth;
            BuildRequestHeader(_httpClient.DefaultRequestHeaders);
        }

        public RouterConnection(Uri baseAddress, ICredentials credentials)
        {
            _handler = new HttpClientHandler()
            {
                CookieContainer = new CookieContainer(),
                AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip,
                //Credentials = new NetworkCredential(),
                // this credential will be used on second request
                // first time we tried to access the server/router it will fail due to authentication issues
                // note: use fiddler to see the requests.
                Credentials = credentials,
                UseCookies = true,
                UseDefaultCredentials = false,
            };

            _httpClient = new HttpClient(_handler) { BaseAddress = baseAddress };
            BuildRequestHeader(_httpClient.DefaultRequestHeaders);
        }

        private static void BuildRequestHeader(HttpRequestHeaders requestHeaders)
        {
            requestHeaders.UserAgent.ParseAdd("Sagem Client");
            requestHeaders.AcceptEncoding.ParseAdd("gzip, deflate, sdch");
            requestHeaders.AcceptLanguage.ParseAdd("en-US,en;q=0.8,pt;q=0.6");
            requestHeaders.Accept.ParseAdd("text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8");
            requestHeaders.Connection.Add("keep-alive");
            //requestHeaders.Add("")
            //requestHeaders.TryAddWithoutValidation()
        }

        internal Task<HttpResponseMessage> SendAsync(string requestParams)
        {
            return _httpClient.GetAsync(requestParams);
        }

        public async Task<string> GetSeasionKeyAsync()
        {
            using (HttpResponseMessage response = await _httpClient.GetAsync("wlmacflt.cmd?action=view").ConfigureAwait(false))
            {
                //var responseCookies = _handler.CookieContainer.GetCookies(new Uri("http://192.168.1.1/wlmacflt.cmd?action=view")).Cast<Cookie>();
                //foreach (var cookies in responseCookies)
                //{
                //}

                // note: this needs to be fast because if page refresh a new session key will be generated
                string htmlPage = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                return RegexSeasionKey.Match(htmlPage).Groups[1].Value;
            }
        }

        public async Task<string> BackUpConfigs()
        {
            string xmlConfigString = await _httpClient.GetStringAsync("/backupsettings.conf").ConfigureAwait(false);
            return xmlConfigString;
        }

        public async Task<IReadOnlyCollection<DeviceInfo>> GetDevicesAsync()
        {
            var httpResponseMessage = await _httpClient.GetAsync(ActionUrls.DeviceInfo).ConfigureAwait(false);
            try
            {
                // read content
                string htmlPage = await httpResponseMessage.Content.ReadAsStringAsync().ConfigureAwait(false);
                var matches = _regexDeviceInfo.Matches(htmlPage);
                // parse

                var deviceList = new List<DeviceInfo>(matches.Count);
                foreach (Match match in matches)
                {
                    deviceList.Add(new DeviceInfo(match.Groups[1].Value,
                        match.Groups[2].Value,
                        match.Groups[3].Value,
                        Flags.None,
                        ParseDate(match.Groups[4].Value)));
                }

                // return deviceinfo collection
                return deviceList;
            }
            finally
            {
                // dispose response message
                httpResponseMessage.Dispose();
            }

        }

        public async Task<IReadOnlyCollection<DeviceInfo>> GetCurrentConnectedDevicesAsync()
        {

            return null;
        }

        private static DateTime ParseDate(string dateString)
        {
            // >23 hours, 21 minutes, 9 seconds
            var tokens = dateString.Split(' ').Where(x => x.Length <= 2).Select(x => int.Parse(x)).ToList();
            if (tokens.Count != 3)
                return default(DateTime);
            var date = DateTime.Now;
            date = date.AddHours(tokens[0]);
            date = date.AddMinutes(tokens[1]);
            date = date.AddSeconds(tokens[2]);
            return date;
        }
    }
}
