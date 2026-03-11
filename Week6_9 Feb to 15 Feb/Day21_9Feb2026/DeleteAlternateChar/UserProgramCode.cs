using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DeleteAlternateChar
{
    internal class UserProgramCode
    {
        public static string Solve(string str)
        {
            string ans = "";

            for(int i=0; i<str.Length; i = i + 2)
            {
                ans += str[i];
            }

            return ans;
        }
    }
}
