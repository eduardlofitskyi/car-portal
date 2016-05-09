using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace Auto.Utils
{
    public class MD5Hash
    {
        public static string Do(string str)
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            byte[] checkSum = md5.ComputeHash(Encoding.UTF8.GetBytes(str));
            string result = BitConverter.ToString(checkSum).Replace("-", String.Empty);

            return result.ToUpper();
        }
    }
}