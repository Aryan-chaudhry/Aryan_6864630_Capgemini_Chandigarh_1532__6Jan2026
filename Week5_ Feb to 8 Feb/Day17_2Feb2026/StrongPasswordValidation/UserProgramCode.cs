using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace StrongPasswordValidation
{
    internal class UserProgramCode
    {
        public static string Validate(string password)
        {
            bool status = Regex.IsMatch(password, @"^(?=.*[A-Za-z0-9])(?=.*[@#_])[A-Za-z\d@#_]{8,}$");
            if(status == true)
            {
                return "Valid";
            }
            return "Invalid";
        }
    }
}
