

using MeetingApp;
//using static MeetingApp.Meeting<TParticipant, TAgenda>;

namespace CompanyProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
              Employee emp1 = new Employee();
            try
            {
                Console.WriteLine("\n     " + DateTime.Now + "       \n");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception : " + ex.ToString());
            }

			emp1.RegisterEmployee();
			emp1.InitializeDepartment();
			emp1.SelectDepartment();

			Console.WriteLine("\n Salary status");
			Console.Write("\n" + "Enter your department Id : ");
			int departmentId = Convert.ToInt32(Console.ReadLine());

			emp1.EmployeeSalary(departmentId);

			emp1.AssignNewProject();
			emp1.EmployeeStatus();

			Meeting<string, string> teamMeeting =
			new Meeting<string, string>("Sprint Planning", DateTime.Now);

			teamMeeting.AddParticipant("Aryan");
			teamMeeting.AddParticipant("Ayush");

			teamMeeting.AddAgendaItem("Discuss sprint goals");
			teamMeeting.AddAgendaItem("Assign tasks");
			teamMeeting.meetingType();
			teamMeeting.DisplayMeetingDetails();
		}
    }
}
