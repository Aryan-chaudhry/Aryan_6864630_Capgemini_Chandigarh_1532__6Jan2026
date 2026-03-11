namespace HospitalManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Patient patient1 = new Patient();
            patient1.Name = "Rahul";
            patient1.Age = 21;
            patient1.RegisterPatient();

            Patient patient2 = new Patient();
            patient2.Name = "Rititk";
            patient2.Age = 25;
            patient2.RegisterPatient();


            Appointment apt = new Appointment();
            apt.BookAppointment();

            patient1.ShowAllPatient();


		}
    }
}
