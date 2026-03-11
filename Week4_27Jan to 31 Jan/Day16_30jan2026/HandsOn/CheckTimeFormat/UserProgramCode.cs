using System;
using System.Collections.Generic;
using System.Text;

namespace CheckTimeFormat
{
    internal class UserProgramCode
    {
        public static string Check(string time)
        {
            int hour = Convert.ToInt32(time.Substring(0, 2));
            int min = Convert.ToInt32(time.Substring(3, 2));
            string formatt = time.Substring(5, 2);

            if (hour == 0 || hour > 12 || min < 0 || min > 60) return "false";
            if (formatt != "am" && formatt != "pm") return "true";
            return "true";

        }
    }
}
