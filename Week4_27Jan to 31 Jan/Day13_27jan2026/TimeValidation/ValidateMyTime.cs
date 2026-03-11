using System;
using System.Collections.Generic;
using System.Text;

namespace TimeValidation
{
    internal class ValidateMyTime
    {
        public static string Validate(string str)
        {
            int hour = Convert.ToInt32(str.Substring(0, 2));
            char symbol = str[2];
            int min = Convert.ToInt32(str.Substring(3, 2));
            string format = str.Substring(6,2).ToLower();

            

            if (symbol != ':') return "Invalid Time Format";

            if(hour > 12 || min > 60 || ( format != "pm" && format != "am" ))
            {
                return "Invalid Time Format";
            }
            return "Valid Time Format";
        }
    }
}
