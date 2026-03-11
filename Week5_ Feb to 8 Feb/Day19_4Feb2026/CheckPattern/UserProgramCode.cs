using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace CheckPattern
{
    internal class UserProgramCode
    {
        public static string Check(string input1, string input2)
        {
            bool status1 = Regex.IsMatch(input1, @"^Hi how are you$");
            if(status1 == false)
            {
                return "input1 invalid";
            }

            bool status2 = Regex.IsMatch(input2, @"^\w{10,}$");
            if(status2 == false)
            {
                return "input2 invalid";
            }

            return input1 + " " + input2;
        }
    }
}
