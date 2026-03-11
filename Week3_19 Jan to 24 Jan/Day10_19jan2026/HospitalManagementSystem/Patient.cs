using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagementSystem
{
    internal class Patient:Person
    {
        public static int patientId = 1;
        static public Dictionary<int, string> patientRecords = new Dictionary<int, string>();

        public void RegisterPatient()
        {
            if (!patientRecords.ContainsKey(patientId))
            {
                patientRecords[patientId] = Name;
                Console.WriteLine(" Patient Register successfully!");
                Console.WriteLine(" Patient Name : " + Name + "\n");
                patientId++;
            }
            else
            {
				Console.WriteLine(" Patient already Register!");
			}    
        }

		public void ShowAllPatient()
		{
			Console.WriteLine("\n Patients in Hospital \n");

			foreach (var item in patientRecords)
			{
				Console.WriteLine( " " + item.Key + " : " + item.Value);
			}
		}
	}
}
