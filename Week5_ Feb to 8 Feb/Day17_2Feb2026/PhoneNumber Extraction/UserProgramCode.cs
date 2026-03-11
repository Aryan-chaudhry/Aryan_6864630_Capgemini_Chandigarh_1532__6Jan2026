using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace PhoneNumber_Extraction
{
    internal class UserProgramCode
    {
        public static void fetchPhoneNumber(string Message)
        {
            var item = Regex.Matches(Message, @"\d{10}");

            foreach(var phoneno in item)
            {
                Console.WriteLine(phoneno);
            }
        }
    }
}
