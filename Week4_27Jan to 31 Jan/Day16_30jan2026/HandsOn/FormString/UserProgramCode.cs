using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;

namespace FormString
{
    internal class UserProgramCode
    {
        public static string FormString(string[]str, int n)
        {
            // return -1 if any special char
            foreach(string s in str)
            {
                bool status = Regex.IsMatch(s, @"[^a-zA-Z]");
                if(status == true)
                {
                    return "-1";
                }
            }


            string ans = "";

            foreach(string s in str)
            {
                ans += s.Length > n ? s[n-1] : "$";
            }

            return ans;
        }
    }
}
