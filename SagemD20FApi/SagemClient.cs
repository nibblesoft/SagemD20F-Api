using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackSagemRouter
{
    using HackSagemRouter.Models;
    using System.Collections;
    using System.Net.Http;
    using Utils;

    public class SagemClient
    {
        private static readonly Uri RouterAddress = new Uri("http://192.168.1.1/");
        private readonly RouterConnection RouterConnection;
        private readonly string _password;

        public IEnumerable<DeviceInfo> DeviceInfos { get; }

        // NOTE: This password was processed!
        public SagemClient(string password = "YWRtaW46My4xNDE1") :
            this(password, new RouterConnection(RouterAddress, new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", password)))
        {
        }

        public SagemClient(string password, RouterConnection routerConnection)
        {
            _password = password;
            RouterConnection = routerConnection;
        }

        public void EnableMacFiltering()
        {
        }

        public void DisableMacFilter()
        {
        }

        public async Task AddMacAddressAsync(string macAddress)
        {
            string seasionKey = await RouterConnection.GetSeasionKeyAsync().ConfigureAwait(false);
            await RouterConnection.SendAsync(ActionUrls.MacAddressAdd(macAddress, seasionKey)).ConfigureAwait(false);
        }

        public async Task RemoveMacAddress(string macAddress)
        {
            string seasionKey = await RouterConnection.GetSeasionKeyAsync();
            await RouterConnection.SendAsync(ActionUrls.MacAddressRemove(macAddress, seasionKey)).ConfigureAwait(false);
        }

        public async Task RebootAsync()
        {
            await RouterConnection.SendAsync(ActionUrls.ActionRebot).ConfigureAwait(false);
        }

        public async Task RefreshAsync()
        {
            await RouterConnection.SendAsync(ActionUrls.ActionRefresh).ConfigureAwait(false);
        }

        public async Task TestConnectionAsync()
        {
            await RouterConnection.SendAsync(string.Empty).ConfigureAwait(false);
        }

        public async Task<IList<DeviceInfo>> GetDeviesInfoAsync()
        {
            string contentString = await (await RouterConnection.SendAsync(ActionUrls.DeviceInfo)).Content.ReadAsStringAsync();
            return StringUtils.ParseDeviceInfos(contentString);
        }

    }
}
