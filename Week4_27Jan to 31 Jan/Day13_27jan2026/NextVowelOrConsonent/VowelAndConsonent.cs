using System;
using System.Collections.Generic;
using System.Text;

namespace NextVowelOrConsonent
{
    internal class VowelAndConsonent
    {
        public static bool Vowel(char ch)
        {
            return char.ToLower(ch) == 'a' || char.ToLower(ch) == 'e' || char.ToLower(ch) == 'i' || char.ToLower(ch) == 'o' || char.ToLower(ch) == 'u' ? true : false;

		}

        public static char getNextConsonent(char ch)
        {
            char tocompare = ch;
			if (tocompare == 'z')
			{
				tocompare = 'a';
			}
            else
            {
                tocompare++;
            }

            while (Vowel(tocompare) == true)
            {
                tocompare++;
            }

            return tocompare;
        }

        public static char getNextVowel(char ch)
        {
            char tocompare = ch;
			if (tocompare == 'z')
			{
				tocompare = 'a';
			}
            else
            {
                tocompare++;
            }

            while (Vowel(tocompare) == false)
            {
                tocompare++;

            }

            return tocompare;
        }
        public static string solve(string str)
        {
            string ans = "";

            foreach (var item in str)
            {
                if (Vowel(item) == false)
                {
                    ans += getNextVowel(item);
                }
                else
                {
                    ans += getNextConsonent(item);
                }
            }
            return ans;
        }
    }
}
