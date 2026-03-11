using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace AddingYearToDate
{
    internal class UserProgramCode
    {
        public static string ValidateDate(string date, int year)
        {
            bool status = Regex.IsMatch(date, @"\d{2}-\d{2}-\d{4}");
            if (status == false)
            {
                return "-1";
            }
            else
            {
                DateOnly dt = DateOnly.Parse(date);
                dt = dt.AddYears(year);

                return dt.ToString();
            }


        }
    }
}
