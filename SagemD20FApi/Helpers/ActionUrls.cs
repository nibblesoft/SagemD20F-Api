using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackSagemRouter
{
    public class ActionUrls
    {
        public const string ActionView = "?action=view";
        public const string ActionRemove = "wlmacflt.cmd?action=remove";
        public const string ActionRebot = "wancfg.cmd?action=reboot";
        public const string ActionRefresh = "wancfg.cmd?action=refresh";
        public const string ActionAddMac = "?action=add";
        public const string ActionRemoveMac = "?action=remove";
        public const string DeviceInfo = "dhcpinfo.html";

        // public const string Disconect = "/wancfg.cmd?action=pppinterconn&pppcmd=Disconnect"
        // GET /wancfg.cmd?action=pppinterconn&pppcmd=Connect&pppUserName=cai0013&pppPassword=cai0013&dddd=kkkk HTTP/1.1

        public static string MacAddressRemove(string macAddress, string seasionKey)
        {
            //GET http://192.168.1.1/wlmacflt.cmd?action=remove&rmLst=70:9E:29:1E:60:4F,%20&sessionKey=1776621945
            return $"wlmacflt.cmd?action=remove&rmLst={macAddress.Trim()}&sessionKey={seasionKey}";
        }

        public static string MacAddressAdd(string macAddress, string seasionKey)
        {
            // wlmacflt.cmd?action=add&wlFltMacAddr=90:4C:E5:04:D1:A1&wlSyncNvram=1&sessionKey=2084490365 HTTP/1.1
            return $"wlmacflt.cmd?action=add&wlFltMacAddr={macAddress.Trim()}&wlSyncNvram=1&sessionKey={seasionKey}";
        }

        public static string MacFiltering(bool allow, string sessionKey)
        {
            // action = save
            // wlFltMacMode	disabled
            string status = allow ? "allow" : "disabled"; // and "deny"
            // http://192.168.1.1/wlmacflt.cmd?action=save&wlmacflt=allow&sessionKey=169163972 
            return $"wlmacflt.cmd?action=save&wlFltMacMode={status}&sessionKey={sessionKey}";
        }
    }
}
