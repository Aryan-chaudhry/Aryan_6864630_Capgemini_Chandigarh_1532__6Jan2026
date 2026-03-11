using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;

namespace ReplaceString
{
    internal class UserProgramCode
    {
        public static string ReplaceString(string words, int n, char ch)
        {
            // if not special char return -3
            if(Char.IsLetterOrDigit(ch) == true)
            {
                return "-3";
            }

            // if n is negative return -2;
            if(n < 0)
            {
                return "-2";
            }

            // return -1 is not alphabets
            string[] str = words.Split(' ');

            foreach(string word in str)
            {
                bool status = Regex.IsMatch(word, @"^[a-zA-Z]+$");
                if (status == false)
                {
                    return "-1";
                }
            }



            string myword = str[n-1];

            string replacedword = new string(ch, myword.Length);
            return words.Replace(myword, replacedword);
        }
    }
}
