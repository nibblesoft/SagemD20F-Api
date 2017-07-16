using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HackSagemRouter
{
    public class RouterConnection
    {
        private readonly Regex RegexSeasionKey = new Regex("sessionKey=(\\d+)", RegexOptions.Compiled);
        private readonly HttpClient _httpClient;
        private readonly HttpClientHandler _handler = new HttpClientHandler();

        public RouterConnection(Uri uri, AuthenticationHeaderValue auth)
        {
            var baseAddress = new Uri("http://example.com");
            _handler.CookieContainer = new CookieContainer();
            //_handler.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;
            _httpClient = new HttpClient(/*Handler*/) { BaseAddress = uri };
            //_cookieContainer.Add(baseAddress, new Cookie("sagem", "sagem_value"));
            _httpClient.DefaultRequestHeaders.Authorization = auth;
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
            // requestHeaders.TryAddWithoutValidation()
        }

        internal async Task<HttpResponseMessage> SendAsync(string requestParams)
        {
            return await _httpClient.GetAsync(requestParams).ConfigureAwait(false);
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
    }
}
