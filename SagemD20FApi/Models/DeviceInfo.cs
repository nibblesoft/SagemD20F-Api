using System;

namespace HackSagemRouter.Models
{
    /// <summary>
    /// ARP (The address resolution protocol) table devices.
    /// </summary>
    public class DeviceInfo
    {
        public DeviceInfo(string hostname, string macAddress, string ipAddress, DateTime expiresIn)
        {
            Hostname = hostname;
            MacAddress = macAddress;
            IpAddress = ipAddress;
            ExpiresIn = expiresIn;
        }

        public string Hostname { get; }
        public string MacAddress { get; }
        public string IpAddress { get; }
        public DateTime ExpiresIn { get; }
    }
}
