using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace GetDigit
{
    internal class UserProgramCode
    {
        public static void GetAllDigits(string str)
        {
            Regex regex = new Regex(@"\d+");
            Match match = regex.Match(str);

            Console.WriteLine(match.Value);   
        }
    }
}
