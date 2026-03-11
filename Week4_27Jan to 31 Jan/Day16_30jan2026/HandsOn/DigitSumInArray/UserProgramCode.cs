using System;
using System.Collections.Generic;
using System.Text;

namespace DigitSumInArray
{
    internal class UserProgramCode
    {
        public static int SumOfDigit(string[] input2)
        {
            int sum = 0;

            foreach(var str in input2)
            {
                foreach(char ch in str)
                {
                    if (Char.IsDigit(ch))
                    {
                        sum += (ch - '0');
                    }
                }
            }
            return sum;
        }
    }
}
