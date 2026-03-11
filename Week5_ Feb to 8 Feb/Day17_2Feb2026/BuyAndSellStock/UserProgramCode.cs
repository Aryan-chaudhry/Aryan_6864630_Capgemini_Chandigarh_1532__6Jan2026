using System;
using System.Collections.Generic;
using System.Text;

namespace BuyAndSellStock
{
    internal class UserProgramCode
    {
        public static int Solve(int[] nums)
        {
            int maxProfit = int.MinValue;
            int minPrice = int.MaxValue;

            for(int i=0; i<nums.Length; i++)
            {
                if (nums[i] < minPrice)
                {
                    minPrice = nums[i];
                }
                else
                {
                    maxProfit = Math.Max(maxProfit, nums[i] - minPrice);
                }
            }

            return maxProfit;
        }
    }
}
