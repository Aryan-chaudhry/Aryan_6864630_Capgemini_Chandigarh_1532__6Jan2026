using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Is_Isnot
{
    internal class UserProgramCode
    {
        public static string modifyString(string str)
        {

            string[] arr = str.Split(' ');

            string ans = "";

            foreach(var s in arr)
            {
                if (s.Equals("is"))
                {
                    ans += "is not ";
                }
                else
                {
                    ans +=  s + " ";
                }
            }

            return ans;
        }
    }
}
