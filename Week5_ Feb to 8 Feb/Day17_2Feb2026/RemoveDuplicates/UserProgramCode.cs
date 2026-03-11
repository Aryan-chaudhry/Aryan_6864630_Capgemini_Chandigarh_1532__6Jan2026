using System;
using System.Collections.Generic;
using System.Text;

namespace RemoveDuplicates
{
    internal class UserProgramCode
    {
        public static int[] RemoveDuplicate(int [] nums)
        {
            int i = 0, j = 0;

            while(j < nums.Length)
            {
                if (nums[i] == nums[j])
                {
                    j++;
                }
                else
                {
                    i++;
                    nums[i] = nums[j];
                }
            }

            return nums;
        }
    }
}
