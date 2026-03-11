using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace StringCompression
{
    internal class CompressString
    {
        public static string CompressString1(string s)
        {
            Dictionary<char, int> dt = new Dictionary<char, int>();

            foreach(char ch in s)
            {
                if (!dt.ContainsKey(ch))
                {
                    dt.Add(ch, 1);
                }
                else
                {
                    dt[ch]+=1;
                    
                }
            }

            string ans = "";

            foreach(var item in dt)
            {
                string key = item.Key.ToString();
                string value = item.Value.ToString();

                ans += key + value;
            }
            return ans;
        }
    }
}
