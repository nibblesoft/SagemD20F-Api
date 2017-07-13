using HackSagemRouter.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HackSagemRouter.Utils
{
    public static class StringUtils
    {
        public static string EncodeToBase64(string userName, string pwd)
        {
            return Convert.ToBase64String(Encoding.ASCII.GetBytes($"{userName}:{pwd}"));
        }

        public static IList<DeviceInfo> ParseDeviceInfos(string contentString)
        {
            const string trtd = "<tr><td>";
            const string tdtrClose = "</td></tr>";
            int idx = contentString.IndexOf(trtd, StringComparison.Ordinal);
            while (idx >= 0)
            {
                /// int
                break;
            }
            return null;
        }
    }
}
