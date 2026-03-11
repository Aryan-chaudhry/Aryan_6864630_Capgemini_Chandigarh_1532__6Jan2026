using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ElectricBill
{
    internal class UserProgramCode
    {
        public static int Calculate(string firstMeter, string secondMeter, int rate)
        {
            int firstMeterReading = Convert.ToInt32(Regex.Match(firstMeter, @"\d{5}").Value);
            Console.WriteLine("First Meter Reading " + firstMeterReading);

            int secondMterReading = Convert.ToInt32(Regex.Match(secondMeter, @"\d{5}").Value);
            Console.WriteLine("Second Meter Reading " + secondMterReading);

            int absDiff = Math.Abs(firstMeterReading - secondMterReading);

            int bill = absDiff * rate;

            return bill;
        }
    }
}
