using System;
using System.Collections.Generic;
using System.Text;

namespace TotalFrequency
{
    internal class UserProgramCode
    {
        public static int Sum(int[] nums)
        {
            Dictionary<int, int> dt = new Dictionary<int, int>();

            foreach(int num in nums)
            {
                if (!dt.ContainsKey(num))
                {
                    dt.Add(num, 1);
                }
                else
                {
                    dt[num]++;
                }
            }

            int maxFrequency = 0;

            foreach(var item in dt)
            {
                maxFrequency = Math.Max(maxFrequency, item.Value);
            }

            int maxFreqSum = 0;

            foreach(var item in dt)
            {
                if(item.Value == maxFrequency)
                {
                    maxFreqSum += item.Value;
                }
            }
            return maxFreqSum;
        }
    }
}
