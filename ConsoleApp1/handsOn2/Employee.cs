using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.handsOn2
{
    internal class Employee
    {
        public int empId, empAge;
        public string empName, empAddess;

        public void getEmpData()
        {
            Console.Write("Enter the Employee Details : ");

            this.empId = Convert.ToInt32(Console.ReadLine());
            this.empAge = Convert.ToInt32(Console.ReadLine());

            this.empName = Console.ReadLine();
            this.empAddess = Console.ReadLine();
        }

        public void displayEmployeeData()
        {
            Console.WriteLine("Employee Id : " + this.empId);
			Console.WriteLine("Employee Name : " + this.empName);
			Console.WriteLine("Employee Age : " + this.empAge);
            Console.WriteLine("Employee Addess : " + this.empAddess);
        }
    }

    class Example()
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            Employee emp2 = new Employee();

            emp1.getEmpData();
            emp1.displayEmployeeData();

            emp2.getEmpData();
            emp2.displayEmployeeData();
        }
       
    }
}
