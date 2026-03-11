using System;
using System.Collections.Generic;
using System.Text;


namespace PatientCaseStudy
{
    internal class PatientBO
    {
         
        public void DisplayPatientsDetails(List<Patient> PatientList, string name)
        {
            List<Patient> p1 = (from p in PatientList
                                where p.Name == name
                                select p).ToList();

            int size = p1.Count;

            if(size <= 0)
            {
                Console.WriteLine("Patient with {0} not found", name);
            }
            else
            {
				Console.WriteLine(string.Format("{0,-21}{1,-6}{2,-17}{3,-20}","name", "age", "illness", ""));
				foreach (Patient patient in p1)
                {
                    Console.WriteLine(patient.ToString());
                }
                Console.WriteLine();
            }
        }

        public void DisplayYoungestPateintDetails(List<Patient> PatientList)
        {
            int minAge = (from p in PatientList
                          select p.age).Min();

            var patientDetail = (from p in PatientList
                                 where p.age == minAge
                                 select p);

			Console.WriteLine(string.Format("{0,-21}{1,-6}{2,-17}{3,-20}", "name", "age", "illness", "city"));
            foreach(var item in patientDetail)
            {
                Console.WriteLine(item.ToString());
            }


		}

        public void DisplayPatientsFromCity(List<Patient>PatientList, string cname)
        {
            List<Patient> patients = (from p in PatientList
                                      where p.city == cname
                                      select p).ToList();
            
            foreach(Patient p in patients)
            {
                Console.WriteLine(p.ToString());
            }
        }
    }
}
