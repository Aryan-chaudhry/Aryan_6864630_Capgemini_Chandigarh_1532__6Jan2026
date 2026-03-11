using System;
using System.Collections.Generic;
using System.Text;

namespace ClosestSquare
{
    internal class UserProgramCode
    {
        public static bool PerfectRoot(int number)
        {
            int sqrt = (int)Math.Sqrt(number);

            return sqrt * sqrt == number ? true : false;
        }
        public static int Solve(int number)
        {
            // check if number itself a perfect root return number it self
            if (PerfectRoot(number))
            {
                return number;
            }

            int leftCount = 0;
            int leftNumber = number;

            while (PerfectRoot(leftNumber) == false)
            {
                leftCount++;
                leftNumber--;
            }

            int rightCount = 0;
            int rightNumber = number;

            while (PerfectRoot(rightNumber) == false)
            {
                rightCount++;
                rightNumber++;
            }

            return leftCount < rightCount ? leftNumber : rightNumber;
        }
    }
}
