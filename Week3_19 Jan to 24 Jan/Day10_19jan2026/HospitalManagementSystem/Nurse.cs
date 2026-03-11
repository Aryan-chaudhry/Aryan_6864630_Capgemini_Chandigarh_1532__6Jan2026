using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagementSystem
{
    internal class Nurse:Person
    {
        static int nurseId = 1;
        static public Dictionary<int, string> nurseRecord = new Dictionary<int, string>();

        public void RegisterNurse()
        {
            if (!nurseRecord.ContainsKey(nurseId))
            {
                nurseRecord.Add(nurseId, Name);
                Console.WriteLine(" Nurse Register Successfully");
                Console.WriteLine(" Nurse Name : " + Name + "\n");
                nurseId++;
            }
            else
            {
                Console.WriteLine(" Nurse already Registered");
            }
        }

		public void ShowAllNurse()
		{
			Console.WriteLine(" Nurses in Hospital");

			foreach (var item in nurseRecord)
			{
				Console.WriteLine(" " + item.Key + " : " + item.Value + "\n");
			}
		}
	}
}
