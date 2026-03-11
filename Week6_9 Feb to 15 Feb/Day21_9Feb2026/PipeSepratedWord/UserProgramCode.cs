using System;
using System.Collections.Generic;
using System.Text;

namespace PipeSepratedWord
{
    internal class UserProgramCode
    {
        public static string Solve(string str)
        {
            string[] arr = str.Split("|");

            int left = 0, right = arr.Length - 1;

            while(left < right)
            {
                string temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;
                left++;
                right--;
            }

            string ans = "";

            foreach(string temp in arr)
            {
                ans += temp + " ";
            }

            ans = ans.TrimEnd();
            return ans;
        }
    }
}
