﻿namespace HackSagemRouter
{
    using HackSagemRouter.Models;
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http.Headers;
    using System.Threading.Tasks;
    using Utils;

    public class SagemClient
    {
        private static readonly Uri RouterAddress = new Uri("http://192.168.1.1/");
        private readonly RouterConnection RouterConnection;

        // ROUTER LOGIN ID
        public string UserName { get; set; }
        public string Password { get; set; }

        public IEnumerable<DeviceInfo> DeviceInfos { get; }

        public SagemClient(string userName, string password)
        {
            UserName = userName;
            Password = password;

            string hashedAuth = StringUtils.EncodeToBase64(UserName, Password);
            RouterConnection = new RouterConnection(RouterAddress, new AuthenticationHeaderValue("Basic", hashedAuth));

            /*
            var credentialCache = new CredentialCache();
            NetworkCredential networkCrednetial = new NetworkCredential(userName, password);
            */
        }

        /// <summary>
        /// This is less efficient than Sagem(string userName, string password)
        /// after using this constructor to create instance, for every request the client must send 2 requets.
        /// </summary>
        /// <param name="credentials">Credential that will be used to authenticate</param>
        public SagemClient(ICredentials credentials)
        {
            RouterConnection = new RouterConnection(RouterAddress, credentials);
        }

        public async Task EnableMacFilteringAsync()
        {
            // TODO: Refactor: RouterConnection.GetSeasionKeyAsync().ConfigureAwait(false)
            // inside RouterConnection.SendAsync to avoid duplicated codes.
            string seasionKey = await RouterConnection.GetSeasionKeyAsync().ConfigureAwait(false);
            await RouterConnection.SendAsync(ActionUrls.MacFiltering(true, seasionKey)).ConfigureAwait(false);
        }

        public async Task DisableMacFilterAsync()
        {
            string seasionKey = await RouterConnection.GetSeasionKeyAsync().ConfigureAwait(false);
            await RouterConnection.SendAsync(ActionUrls.MacFiltering(false, seasionKey)).ConfigureAwait(false);
        }

        public async Task AddMacAddressAsync(string macAddress)
        {
            string seasionKey = await RouterConnection.GetSeasionKeyAsync().ConfigureAwait(false);
            await RouterConnection.SendAsync(ActionUrls.MacAddressAdd(macAddress, seasionKey)).ConfigureAwait(false);
        }

        public async Task RemoveMacAddress(string macAddress)
        {
            string seasionKey = await RouterConnection.GetSeasionKeyAsync().ConfigureAwait(false);
            await RouterConnection.SendAsync(ActionUrls.MacAddressRemove(macAddress, seasionKey)).ConfigureAwait(false);
        }

        public Task RebootAsync() => RouterConnection.SendAsync(ActionUrls.ActionRebot);

        public Task RefreshAsync() => RouterConnection.SendAsync(ActionUrls.ActionRefresh);

        public Task TestConnectionAsync() => RouterConnection.SendAsync(string.Empty);

        //[Obsolete]
        //public async Task<IList<DeviceInfo>> GetDeviesInfoAsync()
        //{
        //    string contentString = await (await RouterConnection.SendAsync(ActionUrls.DeviceInfo)).Content.ReadAsStringAsync();
        //    return StringUtils.ParseDeviceInfos(contentString);
        //}

        public Task<IReadOnlyCollection<DeviceInfo>> GetDeviesInfoAsync()
        {
            // note: once method contain async should always rturn awaited* task-result.
            return RouterConnection.GetDevicesAsync();
        }

        public object GetConfigurationsFromRouter()
        {

            // get status if mac filter is enable

            // get mac of current connected client... from ARP (address resolution protocol) tab.

            return null;
        }

        /// <summary>
        /// Uploads configuration file to router server and reboot
        /// </summary>
        /// <param name="fileName">Configuration file</param>
        public Task UploadConfigsAsync(string fileName)
        {
            throw new NotImplementedException();
        }

        public Task<string> BackUpConfigsAsync() => RouterConnection.BackUpConfigs();

        public Task DisconnectAsync() => RouterConnection.SendAsync(ActionUrls.ActionDisconect);

        public Task ConnectAsync() => RouterConnection.SendAsync(ActionUrls.ActionConnect);
    }
}
