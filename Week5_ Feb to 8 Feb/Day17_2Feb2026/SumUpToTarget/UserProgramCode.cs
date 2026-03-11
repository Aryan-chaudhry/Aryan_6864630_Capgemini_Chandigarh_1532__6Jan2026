using System;
using System.Collections.Generic;
using System.Text;

namespace SumUpToTarget
{
    internal class UserProgramCode
    {
        public  static int[] getAns(int[] nums, int target)
        {
            List<int> ans = new List<int>();

            for(int i=0; i<nums.Length; i++)
            {
                for(int j=i+1; j<nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        ans.Add(i);
                        ans.Add(j);
                        return ans.ToArray();
                    }
                }
            }
            ans.Add(-1);
            return ans.ToArray();
        }
    }
}
