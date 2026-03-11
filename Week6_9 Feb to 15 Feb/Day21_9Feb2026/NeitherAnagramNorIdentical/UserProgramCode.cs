using System;
using System.Collections.Generic;
using System.Text;

namespace NeitherAnagramNorIdentical
{
    internal class UserProgramCode
    {
        public static string Sort(string str)
        {
            char[] arr = str.ToCharArray();

            Array.Sort(arr);

            string ans = "";

            foreach(char ch in arr)
            {
                ans += ch;
            }

            return ans;
        }

        public static string[] Solve(string[] input)
        {
            Dictionary<string, List<string>> dt = new Dictionary<string, List<string>>();

            foreach(string str in input)
            {
                string sortedKey = Sort(str);
                string orgKey = str;

                if (!dt.ContainsKey(sortedKey))
                {
                    dt[sortedKey] = new List<string>();
                }
                dt[sortedKey].Add(orgKey);  
            }

            List<string> ans = new List<string>();

            foreach (var item in dt)
            {
                if(item.Value.Count == 1)
                {
                    ans.Add(item.Value[0]);
                }
            }

            return ans.ToArray();
        }
    }
}
