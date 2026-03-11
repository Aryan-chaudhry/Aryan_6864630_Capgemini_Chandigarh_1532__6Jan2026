using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ValidatePassword
{
    internal class UserProgramCode
    {
        public static int Validate(string password)
        {
            bool status = Regex.IsMatch(password, @"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@#_])[A-Za-z][A-Za-z0-9@#_]{6,}[A-Za-z0-9]$");
            return status == true ? 1 : -1;
        }
    }
}
