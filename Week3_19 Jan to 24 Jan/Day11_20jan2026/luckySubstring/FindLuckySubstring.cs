using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace luckySubstring
{
    internal class FindLuckySubstring
    {
        static bool validSubstring(string s, int n)
        {
            if (s.Length != n) return false;   

            foreach(var ch in s)
            {
                if(ch != 'P' && ch != 'S' && ch != 'G')
                {
                    return false;
                }
            }
            return true;
        }

        public static bool IsLucky(string s, int n)
        {
            int consCh = 0;

            for(int i=1; i<n; i++)
            {
                if (s[i] == s[i - 1])
                {
                    consCh++;
                }
                
            }

            if (consCh >= n/2) return true;
            return false;
        }
        public static string findLuckySubstring(string str, int n)
        {

            for (int i = 0; i < str.Length; i++)
            {
                string s = "";

                for (int j = i; j < str.Length; j++)
                {

                    s += str[j];

                    if (validSubstring(s,n))
                    {
                        if (IsLucky(s, n))
                        {
                            return "Yes";
                        }
                    }
                }
            }
            return "No";
        }
    }
}
