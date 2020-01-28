using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
