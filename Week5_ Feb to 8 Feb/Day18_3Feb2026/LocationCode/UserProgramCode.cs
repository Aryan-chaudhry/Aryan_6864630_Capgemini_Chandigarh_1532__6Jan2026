using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace LocationCode
{
    internal class UserProgramCode
    {
        public static string UpdateLocation(string invoiceNumber)
        {
            bool status = Regex.IsMatch(invoiceNumber, @"^CAP-\w{3}-\d+$");

            if(status == false)
            {
                return "Invalid Invoice Number ";
            }

            string Location = invoiceNumber.Substring(4, 3);

            Console.Write("Enter updated Location : ");
            string updatedLocation = Console.ReadLine();

            invoiceNumber = invoiceNumber.Replace(Location, updatedLocation);
            return invoiceNumber;
        }
    }
}
