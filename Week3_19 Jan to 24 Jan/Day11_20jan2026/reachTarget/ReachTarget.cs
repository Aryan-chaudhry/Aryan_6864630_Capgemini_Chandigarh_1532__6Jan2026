using System;
using System.Collections.Generic;
using System.Text;

namespace reachTarget
{
    internal static class ReachTarget
    { 
        public static int FindMinOperations(int number, int target)
        {
            if (number < 0 || number > target*3) return int.MaxValue;
            if (number == target) return 0;
            

            int minAns = int.MaxValue;
            int opt1 = int.MaxValue, opt2 = int.MaxValue ,opt3 = int.MaxValue;

            if(number < target)
            {
				opt1 = FindMinOperations(number + 2, target);
				opt3 = FindMinOperations(number * 3, target);
			}
            else
            {
				opt2 = FindMinOperations(number - 1, target);
			}


            minAns = 1 + Math.Min(minAns, Math.Min(opt1, Math.Min(opt2, opt3)));
            return minAns;
        }
    }
}
