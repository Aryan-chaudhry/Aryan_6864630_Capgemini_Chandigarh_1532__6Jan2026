using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace EmailValidation
{
    internal class UserProgramCode
    {
        public static string validateEmail(string email)
        {
            bool status = Regex.IsMatch(email, @"^[a-zA-Z0-9]+@[a-zA-Z0-9]+\.[a-zA-Z0-9]{2,}$");

            if(status == true)
            {
                return "Valid";
            }
            return "InValid";
        }
    }
}
