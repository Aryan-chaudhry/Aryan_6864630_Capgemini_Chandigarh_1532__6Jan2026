using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagementSystem
{
    internal class Doctor:Person
    {
        static int doctorId;
        static public Dictionary<int, string> doctorRecors = new Dictionary<int, string>();

        public void RegisterDoctor()
        {
            if (!doctorRecors.ContainsKey(doctorId))
            {
                doctorRecors[doctorId] = Name;
                Console.WriteLine(" Doctor Register Successfully ");
                Console.WriteLine(" Doctor Name : " + Name + "\n");
                doctorId++;
            }
            else
            {
                Console.WriteLine(" Doctor already exist");
            }
        }

        public void ShowAllDoctor()
        {
            Console.WriteLine(" Doctors in Hospital \n");

            foreach(var item in doctorRecors)
            {
                Console.WriteLine(" " + item.Key + " : " + item.Value );
            }
        }
    }
}
