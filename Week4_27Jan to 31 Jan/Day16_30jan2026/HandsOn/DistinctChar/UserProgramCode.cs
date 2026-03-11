using System;
using System.Collections.Generic;
using System.Text;

namespace DistinctChar
{
    internal class UserProgramCode
    {
        public static string CheckDistinct(string str)
        {
            string store = "";
            string ans = "";

            foreach(char ch in str)
            {
                if(ch != ' ' && !store.Contains(ch))
                {
                    ans += ch;
                    store += ch;
                }
                else if(ch == ' ')
                {
                    ans += ch;
                }
            }
           
            return ans;
        }
    }
}
