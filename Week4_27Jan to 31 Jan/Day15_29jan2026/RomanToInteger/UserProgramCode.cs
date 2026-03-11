using System;
using System.Collections.Generic;
using System.Text;

namespace RomanToInteger
{
    internal class UserProgramCode
    {
        public static int Convert(string str)
        {
            Dictionary<char, int> dt = new Dictionary<char, int>();

            dt.Add('I', 1);
            dt.Add('V', 2);
            dt.Add('X', 10);
            dt.Add('L', 50);
            dt.Add('C', 100);
            dt.Add('D', 500);
            dt.Add('M', 1000);

            // return -1 if not in roman
            foreach(char ch in str)
            {
                if (!dt.ContainsKey(ch))
                {
                    return -1;
                }
            }

            int ans = 0;

            for(int i=0; i<str.Length-1; i++)
            {
                if (dt[str[i]] < dt[str[i + 1]])
                {
                    ans -= dt[str[i]];
                }
                else
                {
                    ans += dt[str[i]];
                }
            }

            return ans + dt[str[str.Length-1]];
        }
    }
}
