using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Text;

namespace Palindrome
{
    internal class checking
    {
        public static bool IsPalindrome(string str)
        {
            int st = 0;
            int end = str.Length - 1;

            while(st <= end)
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
    }
}
