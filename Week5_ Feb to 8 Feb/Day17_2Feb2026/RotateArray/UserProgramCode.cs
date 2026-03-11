using System;
using System.Collections.Generic;
using System.Text;

namespace RotateArray
{
    internal class UserProgramCode
    {
        public static int[] Rotate(int[]nums, int k)
        {
            int[] ans = new int[nums.Length];

            int startingIndex = nums.Length - k;
            int trackIndex = 0;
            for (int i = startingIndex; i < nums.Length; i++)
            {
                ans[trackIndex++] = nums[i];
            }

            for (int i = 0; i < startingIndex; i++)
            {
                ans[trackIndex++] = nums[i];
            }

            return ans;
        }
    }
}
