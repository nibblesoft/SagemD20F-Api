using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackSagemRouter.Models
{
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
