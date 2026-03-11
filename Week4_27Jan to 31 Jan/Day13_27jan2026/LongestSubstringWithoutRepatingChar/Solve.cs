using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;


namespace LongestSubstringWithoutRepatingChar
{
    internal class Solve
    {
        public static int solveProblem(string str)
        {
            Dictionary<char, int> dt = new Dictionary<char, int>();
            int i = 0, j = 0;
            int maxLength = 1;

            while(j < str.Length)
            {
                if (!dt.ContainsKey(str[j]))
                {
                    dt.Add(str[j], j);
				}
                else
                {
                    int trackindex = dt[str[j]];
                    while (i <= trackindex)  
                    {
                        dt.Remove(str[i]);
                        i++;
                    }
                    //i = dt[j] + 1;

					dt[str[j]] = j;
                   

                }
				int length = j - i + 1;
				maxLength = Math.Max(maxLength, length);
				j++;
            }
            return maxLength;
        }
    }
}       
