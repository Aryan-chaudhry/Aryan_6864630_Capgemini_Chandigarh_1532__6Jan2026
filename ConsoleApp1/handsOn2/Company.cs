using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters;
using System.Text;

namespace ConsoleApp1.handsOn2
{
    internal class Company
    {
        const string Name = "Capgemini";
        const string Location = "Pune";

        static int empId;
        string empName;
        double empSalary;

        Dictionary<int, string> details = new Dictionary<int, string>();

        static Company()
        {
            empId = 1;
        }

        Company(string empName)
        {
            this.empName = empName;
            string employeeDetail = "empId : " + empId + "\n"
                                    +
                                    "employee Name : " + empName + "\n";

            details[empId] = employeeDetail;
            empId += 1;
        }


        public string GetLocation()
        {
            string campusLocation = "Capus Location is : " + Location;
            return campusLocation;
        }

        public void GetEmployeeDetail()
        {
            Console.Write("Enter Employee ID : ");
            int employeeId = Convert.ToInt32(Console.ReadLine());

            if (details.ContainsKey(employeeId))
            {
                Console.Write(details.Values);
            }
            else
            {
                Console.Write("Sorry employee with id : " + employeeId + " does not exist");
            }
        }

        public void UpdateEmployeeDetails()
        {
            Console.Write("Enter Employee Id : ");
            int empId = Convert.ToInt32(Console.ReadLine());

            if (details.ContainsKey(empId))
            {
                Console.Write("Enter updated Name : ");
                string newEmpName = Console.ReadLine();

				string newEmployeeDetail = "empId : " + empId + "\n"
									+
									"employee Name : " + newEmpName + "\n";

                // updated now store
                details[empId] = newEmployeeDetail;

			}


		}

        
        static void Main(string[] args)
        {
            Company company = new Company("Aryan");
            company.GetEmployeeDetail();
            
        }        
	}
    
}
