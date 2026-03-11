using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace DateAndTime
{
    internal class UserProgramCode
    {
        public static string Validate(string date, int year)
        {
            bool status = Regex.IsMatch(date, @"\d{2}-\d{2}-\d{4}$");
            if (status)
            {
                DateOnly dt = DateOnly.Parse(date);
                dt = dt.AddYears(year);
                Console.WriteLine(dt.ToString());
                return dt.DayOfWeek.ToString();
            }
            return "-1";
        }
    }
}
