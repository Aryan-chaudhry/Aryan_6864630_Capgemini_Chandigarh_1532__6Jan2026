using System;
using System.Collections.Generic;
using System.Text;

namespace VowelGame
{
	internal class CheckVowel
	{
		// Check if character is vowel (case-insensitive)
		public static bool Vowel(char ch)
		{
			ch = char.ToLower(ch);
			return ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u';
		}

		public static string GameOfVowel(string input1, string input2)
		{
			// Store characters of input2 in lowercase for case-insensitive comparison
			HashSet<char> st = new HashSet<char>();

			foreach (var ch in input2)
			{
				st.Add(char.ToLower(ch));
			}

			// Step 1: Remove common consonants
			string ans = "";

			foreach (char ch in input1)
			{
				char lower = char.ToLower(ch);

				if (Vowel(ch))
				{
					ans += ch;
				}
				else
				{
					if (!st.Contains(lower))
					{
						ans += ch;
					}
				}
			}

			// Step 2: Remove consecutive duplicate characters
			string output = "";

			foreach (char ch in ans)
			{
				if (output.Length == 0 || output[output.Length - 1] != ch)
				{
					output += ch;
				}
			}

			return output;
		}
	}
}
