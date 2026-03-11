using System;
using System.Collections.Generic;
using System.Text;

namespace CountVowel
{
    internal class CountAllVowel
    {
        public static int count(string str)
        {
            int countVowel = 0;

            foreach(char ch in str)
            {
                char toCompare = char.ToLower(ch);

                if(toCompare == 'a' || toCompare == 'e' || toCompare == 'i' || toCompare == 'o' || toCompare == 'u')
                {
                    countVowel++;
                }
            }
            return countVowel;
        }
    }
}
