using System;
using System.Collections.Generic;
using System.Text;

namespace ReplaceStringToAnother
{
    internal class UserProgramCode
    {
        public static string Solve(string str, char replaceTo, char replaceWith)
        {
            char[] arr = str.ToCharArray();

            int index = -1;

            for(int i=0; i<arr.Length; i++)
            {
                if (arr[i] == replaceTo)
                {
                    index = i;
                    break;
                }
            }

            arr[index] = replaceWith;

            string ans = "";

            foreach(char ch in arr)
            {
                ans += ch;
            }
            return ans;
        }
    }
}
