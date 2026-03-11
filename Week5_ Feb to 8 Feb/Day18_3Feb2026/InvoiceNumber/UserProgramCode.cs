using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace InvoiceNumber
{
    internal class UserProgramCode
    {
        public static string UpdateInvoiceNumber(string invoiceNumber)
        {
            bool status = Regex.IsMatch(invoiceNumber, @"^CAP-");
            
            if(status == false)
            {
                return "Invalid Invoice Number";
            }

            int number = Convert.ToInt32((Regex.Match(invoiceNumber, @"\d+")).Value);

            Console.WriteLine("Enter the increment Value : ");
            int increment = Convert.ToInt32(Console.ReadLine());

            int updated = number + increment;

            invoiceNumber = invoiceNumber.Replace(number.ToString(), updated.ToString());

            return invoiceNumber;
        }

	}
}
