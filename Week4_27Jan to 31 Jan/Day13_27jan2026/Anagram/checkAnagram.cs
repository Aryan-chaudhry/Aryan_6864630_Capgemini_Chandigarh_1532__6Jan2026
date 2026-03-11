using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace Anagram
{
    internal class checkAnagram
    {
        public static bool check(string s1, string s2)
        {
            var temp1 = s1.ToCharArray();
            var temp2 = s2.ToCharArray();

            temp1.Sort();
            temp2.Sort();

            s1 = new string (temp1);
            s2 = new string(temp2);

            Console.WriteLine(s1);
            Console.WriteLine(s2);

            return s1.Equals(s2) ? true : false;
        }
    }
}
