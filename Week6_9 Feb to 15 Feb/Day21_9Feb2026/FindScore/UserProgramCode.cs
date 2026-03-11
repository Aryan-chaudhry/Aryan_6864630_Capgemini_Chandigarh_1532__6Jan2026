using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace FindScore
{
    internal class UserProgramCode
    {
        public static bool IsPalindrome(string str, int st, int end)
        {
            while(st < end)
            {
                if (str[st] != str[end])
                {
                    return false;
                }
                st++;
                end--;
            }
            return true;
        }

        public static int Optimized1(string str)
        {
            int score = 0;

            for(int i=0; i<str.Length; i++)
            {
                if (i < str.Length - 3 && IsPalindrome(str,i, 4))
                {
                    score += 5;
                }
                if(i < str.Length-4 && IsPalindrome(str, i, 5))
                {
                    score += 10;
                }
            }
            return score;
        }
        public static int BruteForce(string str)
        {
            int score = 0;

            for(int i=0; i<str.Length; i++)
            {
                for(int j=i; j<str.Length; j++)
                {
                    if(j-i+1 == 4 && IsPalindrome(str, i, j))
                    {
                        score += 5;
                    }
                    else if(j-i+1 == 5 && IsPalindrome(str, i, j))
                    {
                        score += 10;
                    }
                }
            }

            return score;
        }
    }
}
