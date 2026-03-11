using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace EmailValidation
{
    internal class UserProgramCode
    {
        public static bool ValidateEmail(string email)
        {
            string pattern = @"^\w+@\w+\.+\w+$";
            bool answer = Regex.IsMatch(email, pattern);
            return answer;
        }
    }
}
