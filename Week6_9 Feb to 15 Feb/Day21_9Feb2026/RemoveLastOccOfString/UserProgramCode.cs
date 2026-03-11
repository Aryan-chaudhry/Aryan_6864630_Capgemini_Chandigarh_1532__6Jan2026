using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace RemoveLastOccOfString
{
    internal class UserProgramCode
    {
        public static string Solve(string str, string ToRemove)
        {
			string[] arr = str.Split(" ");

            int index = -1;
            
            for(int i=0; i<arr.Length; i++)
            {
                if (arr[i] == ToRemove)
                {
                    index = i;
                }
            }

            string ans = "";

            for(int i=0; i<arr.Length; i++)
            {
                if(i != index)
                {
                    ans += arr[i] + " ";
                }
            }
            return ans = ans.TrimEnd();
		}
    }
}
