using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace Mind.libs
{
    public class Security
    {
        private static readonly string key = "qrdWmmEHIibiy146FbpPk98tbrvRetU";
        private static readonly string passwdRegex = "^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[^\\da-zA-Z]).{8,15}$";

        public static string Hash32(string val, string key = null)
        {
            using (var md5Hash = MD5.Create())
            {
                // TODO - Melhorar essa concatenização
                val = key + val + Security.key;
                byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(val));

                StringBuilder sBuilder = new StringBuilder();
                for (int i = 0; i < data.Length; i++)
                    sBuilder.Append(data[i].ToString("x2"));

                return sBuilder.ToString();
            }
        }

        public static string NewKey()
        {
            var guid = Guid.NewGuid();
            return guid.ToString();
        }

        public static bool IsPasswdRequeriments(string passwd)
        {
            var ER = new Regex(Security.passwdRegex, RegexOptions.None);

            return ER.IsMatch(passwd);
        }
    }
}
