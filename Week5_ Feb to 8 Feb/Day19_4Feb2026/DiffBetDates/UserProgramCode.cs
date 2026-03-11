using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace DiffBetDates
{
    internal class UserProgramCode
    {

        public static int FindDiff(string input1, string input2)
        {
            DateOnly dt1 = DateOnly.Parse(input1);
            DateOnly dt2 = DateOnly.Parse(input2);

            int numberOfDays1 = dt1.Day;
            int numberOfDays2 = dt2.Day;

            return Math.Abs(numberOfDays1 - numberOfDays2);            
        }
    }
}
