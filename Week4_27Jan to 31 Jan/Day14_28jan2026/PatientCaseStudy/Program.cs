namespace PatientCaseStudy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Patient> patientList = new List<Patient>();
            int noOfPateint, age, trackPatient = 0;
            string name, city, illness;

            Console.WriteLine("Enter the Number of Patients ");
            noOfPateint = Convert.ToInt32(Console.ReadLine());
            Patient patient = new Patient();

            for(int i=1; i<=noOfPateint; i++)
            {
                Console.WriteLine("Enter Pateint " + (++trackPatient) + " Records");

                Console.WriteLine("Enter Pateint Name");
                name = Console.ReadLine();

                Console.WriteLine("Enter Patient Age");
                age = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Patient Illness");
                illness = Console.ReadLine();

                Console.WriteLine("Enter the city");
                city = Console.ReadLine();

                patient = new Patient(name, age, illness, city);
                patientList.Add(patient);
            }

            PatientBO patientBo = new PatientBO();

            
            bool exit = false;

            while (!exit)
            {
				
                Console.WriteLine("1. Display Patients Details \n2. Display Youngest Patient Detail \n3. Display Patients by city \n4. Exit");
				Console.WriteLine("Enter your Choice ");
				int choice = Convert.ToInt32(Console.ReadLine());

				switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter Patient Name ");
                        string PateintName = Console.ReadLine();
                        patientBo.DisplayPatientsDetails(patientList, PateintName);
                        break;

                    case 2: patientBo.DisplayYoungestPateintDetails(patientList);
                        break;

                    case 3:
                        Console.WriteLine("Enter City Name");
                        string CityName = Console.ReadLine();
                        patientBo.DisplayPatientsFromCity(patientList, CityName);
                        break;

                    case 4: exit = true;
                        break;

                    default: Console.WriteLine("This choice not exist");
                        break;
                }
			}

		}
    }
}
