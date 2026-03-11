using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyProject
{
    internal class Company
    {
        public const string companyName = "Capgemini";
        public const string companyLocation = "Pune";

        public void GetCompanyName()
        {
            Console.WriteLine("Company Name : " + companyName);
        }

        public void GetCompanyLocation()
        {
            Console.WriteLine("Company Location : " + companyLocation);                                   
        }

    }
}