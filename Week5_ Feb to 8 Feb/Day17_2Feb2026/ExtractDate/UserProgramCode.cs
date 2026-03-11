using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ExtractDate
{
    internal class UserProgramCode
    {
        public static void Extract(string Message)
        {
            var allDates = Regex.Matches(Message, @"\d{2}/+\d{2}/+\d{4}");

            foreach(var dates in allDates)
            {
                Console.WriteLine(dates);
            }
        }
    }
}
