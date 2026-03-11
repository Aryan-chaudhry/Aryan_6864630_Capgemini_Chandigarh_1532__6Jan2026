using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EcommercePlatform
{
    internal class Customer:Products
    {
        string custName;
        string emailId;
        string password;
        public bool signIn = false;

        public static Dictionary<string, string> custAccount = new Dictionary<string, string>();

        public bool SignIn()
        {
            Console.Write("Enter your email Id : ");
            string Email = Console.ReadLine();

            Console.Write("Create a strong Password which contain atleast (@#$%) one symbol : ");
            string Password = Console.ReadLine();

            while(Password.Length < 8 || (!Password.Contains("@") && !Password.Contains("#") && !Password.Contains("$") && !Password.Contains("%")))
            {
                Console.Write("Week Password! Please try again : ");
                string currPassword = Console.ReadLine();
                Password = currPassword;
            }


            if (!custAccount.ContainsKey(Email))
            {
                custAccount[Email] = Password;
                return true;
            }
            return signIn = true;
        }

        public bool Logout()
        {
            Console.Write("Enter your email Id : ");
            string Email = Console.ReadLine();

            Console.WriteLine("\n are you sure want to logout? yes or no");
            string response = Console.ReadLine();

            if (response.Contains("yes"))
            {
                custAccount.Remove(Email);
                signIn = false;
                Console.WriteLine("Customer Logout Successfully \n");
            }
            else
            {
                signIn = false;
                Console.WriteLine("Customer Already Logout \n");
            }
            return signIn;
        }
    }
}
