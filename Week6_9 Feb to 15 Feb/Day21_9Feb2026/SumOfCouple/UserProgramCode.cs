using System;
using System.Collections.Generic;
using System.Text;

namespace SumOfCouple
{
    internal class UserProgramCode
    {
        public static int Solve(int[] arr, int N)
        {
            int count = 0;

            for(int i=0; i<arr.Length-1; i++)
            {
                int sum = arr[i] + arr[i + 1];
                if(sum%N == 0)
                {
                    Console.WriteLine($"({arr[i]},{arr[i + 1]})");
                    count++;
                }
            }

            return count;
        }
    }
}
