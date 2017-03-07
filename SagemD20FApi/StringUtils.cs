using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackSagemRouter.Utils
{
    public static class StringUtils
    {
        // NOTE: It means like 192.168.1.1 doens't use this method to hash password...
        // TODO: Find which method it uses...
        public static string PasswordToBase64(string pwd)
        {
            return Convert.ToBase64String(Encoding.ASCII.GetBytes(pwd));
        }
    }
}
