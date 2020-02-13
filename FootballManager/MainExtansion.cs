using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager
{
    static class MainExtansion
    {
        public static bool IsEmpty(string[]arr, string emp)
        {
            foreach (var myarr in arr)  
            {
                if (myarr == emp)
                {
                    return false;
                }
            }
            return true;
        }
        public static string HashMe(this string pas)
        {
            byte[] btArray = new ASCIIEncoding().GetBytes(pas);
            byte[] hashedArr = new SHA256Managed().ComputeHash(btArray);
            string hassPassword = new ASCIIEncoding().GetString(hashedArr);

            return hassPassword;
        }
    }
}
