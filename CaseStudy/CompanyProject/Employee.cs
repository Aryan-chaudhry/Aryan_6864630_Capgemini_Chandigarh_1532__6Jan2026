using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace CompanyProject
{
	
    internal class Employee:Department, EmployeeAccount
    {
		public const int employeeId = 16750;
        public string employeeName;
        public string employeeAge;
        public int employeeAttandence = 0;
        public int employeeTotalworkingDays = 0;
		public bool foodServiceStatus = false;
		public bool vehicleServiceStatus = false;
		public int departmentId;
		public string projectAssigned;
		public double employeeBaseSalary;

        public void RegisterEmployee()
        {
            Console.Write("Enter the name of employee : ");
            this.employeeName = Console.ReadLine();

            Console.Write("\n" + "Enter age of Employee : ");
            this.employeeAge = Console.ReadLine();

			Console.Write("\n" + employeeName + " are you willing to take monthly food allowance yes or no : ");
			string foodAcceptance = Console.ReadLine();

			foodServiceStatus = foodAcceptance.Equals("yes") ? true : false;

			Console.Write("\n" + employeeName + " are you willing to opt the vehicle service yes or no : ");
			string vehicleAcceptance = Console.ReadLine();

			vehicleServiceStatus = vehicleAcceptance.Equals("yes") ? true : false;


		}

        public void EmployeeSalary(int empDepartment)
        {
            double salary = 0;

            if (empDepartment == 1)
                salary = 500000;
            else if (empDepartment == 2)
                salary = 400000;
            else if (empDepartment == 3)
                salary = 350000;
            else if (empDepartment == 4)
                salary = 450000;
            else if (empDepartment == 5)
                salary = 200000;


			double foodCutOff = 0;
			double vehicleCutOff = 0;

			if (foodServiceStatus)
			{
				foodCutOff = salary * 0.2;
			}
			if (vehicleServiceStatus)
			{
				vehicleCutOff = salary * 0.12;
			}

			double totalCuttOff = foodCutOff + vehicleCutOff;
			double BaseSalary = salary - totalCuttOff;
			employeeBaseSalary = BaseSalary;
			Console.Write("Rs : " + BaseSalary + "\n");
        }

		public void AssignNewProject()
		{
			Console.WriteLine("\n" + "Dear Employee Please assign new Project Please ");
			Console.Write($"\n{employeeName}, select your Department ID:");
			

			int departmentId = Convert.ToInt32(Console.ReadLine());
			this.departmentId = departmentId;

			string[] developmentProject =
			{
				".NET with Azure",
				"MERN Stack",
				"MEAN Stack",
				"Artificial Intelligence",
				"Machine Learning"
			};

			string[] testingProject =
			{
				"Debugging",
				"Automation Testing",
				"Performance Testing",
				"Deployment Testing"
			};

			string[] marketingProject =
			{
				"Digital Marketing",
				"SEO Optimization",
				"Social Media Campaigns",
				"Email Marketing"
			};

			string[] businessProject =
			{
				"Business Analysis",
				"Client Requirement Gathering",
				"Market Research",
				"Strategy Planning"
			};

			string[] productionProject =
			{
				"Software Deployment",
				"Server Maintenance",
				"Application Monitoring",
				"Release Management"
			};

			string[] selectedProjects = null;

			if (departmentId == 1) selectedProjects = developmentProject;
			else if (departmentId == 2) selectedProjects = testingProject;
			else if (departmentId == 3) selectedProjects = marketingProject;
			else if (departmentId == 4) selectedProjects = businessProject;
			else if (departmentId == 5) selectedProjects = productionProject;
			else
			{
				Console.WriteLine("Invalid Department");
				return;
			}

			Console.WriteLine("\nAvailable Projects:");
			foreach (string project in selectedProjects)
			{
				Console.WriteLine("- " + project);
			}

			Console.Write("\nEnter Project Name exactly as above: ");
			string projectName = Console.ReadLine().Trim();

			bool projectFound = false;

			foreach (string project in selectedProjects)
			{
				if (project.Equals(projectName))
				{
					projectFound = true;
					break;
				}
			}

			if (projectFound)
			{
				Console.WriteLine(" Project Assigned Successfully: " + projectName + "\n");
				this.projectAssigned = projectName;
			}
			else
			{
				Console.WriteLine(" No project Found \n");
			}
		}

		public void EmployeeStatus()
		{
			Console.WriteLine("---------------------------------------------------------------------------------------" + "\n");
			Console.WriteLine("Company : " + companyName + "                     " + "Location : " + companyLocation + "\n");
			Console.WriteLine("Name : " + employeeName + "                            " + "Id : " + employeeId + "\n");
			Console.WriteLine("Stutus : Working " +  "                       " + "Address : " + "NA" + "\n");

			Console.WriteLine("Department Details --------------------------------------------------------------------\n ");

			Console.WriteLine("Department Name : " + department[departmentId - 1] + "           " + "department Id : " + departmentId + "\n");
			Console.WriteLine("Project Assigned : " + projectAssigned + "\n") ;

			Console.WriteLine("Services Alloted ----------------------------------------------------------------------\n ");

			Console.Write("Food Service : ");
			if (foodServiceStatus)
			{
				Console.Write(" Yes          \n");
			}
			else
			{
				Console.Write(" No        \n");
			}

			Console.Write("Vehicle Service : ");
			if (vehicleServiceStatus)
			{
				Console.WriteLine(" Yes        \n");
			}
			else
			{
				Console.WriteLine(" No        \n");
			}

			Console.WriteLine("Employee Salary -----------------------------------------------------------------------\n");
			Console.WriteLine("Base Salary : " + employeeBaseSalary + "\n");

			Console.Write("Food Service Percentage : ");
			if (foodServiceStatus)
			{
				Console.Write("20%  \n");
			}
			else
			{
				Console.Write("0% \n");
			}

			Console.Write("Vehicle Service Percentage : ");
			if (vehicleServiceStatus)
			{
				Console.WriteLine("12% \n ");
			}
			else
			{
				Console.WriteLine ("0% \n ");
			}
			Console.WriteLine("---------------------------------------------------------------------------------------" + "\n");
		}
	}
}
