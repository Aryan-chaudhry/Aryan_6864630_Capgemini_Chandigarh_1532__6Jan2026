using System;
using System.Collections.Generic;
using System.Text;

namespace ReverseString
{
    internal class Reverse
    {
        public static string ReverseMyString(string str)
        {
            string ans = "";

            for (int i = str.Length - 1; i >= 0; i--)
            {
                ans += str[i];
            }

            return str = ans;


        }

    }
}
