using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualBasic;

namespace HospitalManagementSystem
{
    internal class Appointment:Patient
    {
        public void BookAppointment()
        {
            Console.Write("Enter your name please : ");
            string Name = Console.ReadLine();

            Console.Write("Enter your Age : ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your Mobile Number : ");
            string phoneNumber = Console.ReadLine();

            // make sure the number should be of 10 length
            while(phoneNumber.Length != 10)
            {
                Console.Write("Re-Enter your mobile number : ");
                string currMobNum = Console.ReadLine();
                phoneNumber = currMobNum;
            }

            Console.Write("Specify the Problem/Issue/Disease..");
            string problem = Console.ReadLine();

            patientRecords[patientId] = Name + " : " + problem;
			Console.WriteLine("\nAppointment booked successfully!\n");

			Console.WriteLine("--------------------------------------------------");
			Console.WriteLine("             HOSPITAL APPOINTMENT DETAILS         ");
			Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($"Patient Name                       {Name}");
			Console.WriteLine($"Patient Age                        {age}");
			Console.WriteLine($"Patient Number                     {phoneNumber}");
			Console.WriteLine($"Issue                              {problem}");
			Console.WriteLine("--------------------------------------------------");
			Console.WriteLine($"                {DateAndTime.Now}                ");
			Console.WriteLine("--------------------------------------------------");
		}
	}
}
