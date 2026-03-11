using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace OnlyNumber
{
    internal class UserProgramCode
    {
        public static string Check(string[] str)
        {
            
            foreach(var item in str)
            {
                bool status = Regex.IsMatch(item, @"^[0-9.]+$");
                if(status == false)
                {
                    return "Invalid";
                }
            }
            return "Valid";
        }
    }
}
