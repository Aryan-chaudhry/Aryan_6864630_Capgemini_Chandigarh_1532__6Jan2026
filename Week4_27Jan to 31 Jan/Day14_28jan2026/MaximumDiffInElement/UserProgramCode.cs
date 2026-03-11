using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace MaximumDiffInElement
{
    internal class UserProgramCode
    {
        public static int diffInArray(int[] input1)
        {
            // return -1 if any negative elements
            foreach(int number in input1)
            {
                if(number < 0)
                {
                    return -1;
                }
            }

            // if one element or more than 10 element return -2
            if(input1.Length == 1 || input1.Length > 10)
            {
                return -2;
            }

            int maxDifference = int.MinValue;

            for(int i=0; i<input1.Length; i++)
            {
                for(int j=i+1; j<input1.Length; j++)
                {
                    if (input1[i] < input1[j])
                    {
                        int currDiff = input1[j] - input1[i];
                        maxDifference = Math.Max(maxDifference, currDiff);
                    }
                }
            }
            return maxDifference;
        }
	}
}
