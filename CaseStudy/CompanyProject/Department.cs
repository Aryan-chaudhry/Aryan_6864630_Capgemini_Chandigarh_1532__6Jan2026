using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyProject
{
    internal class Department:Company
    {
        public string[] department;
        
        public void InitializeDepartment()
        {
			department = new string[5];

			department[0] = "Development";
			department[1] = "Testing";
			department[2] = "Marketing";
			department[3] = "Bussiness";
			department[4] = "Production";
		}

        public void  SelectDepartment()
        {
            Console.WriteLine("\n" + "Department Assign ");
            Console.WriteLine(" \n Please select your Department  ");
            for(int i=0; i<5; i++)
            {
                Console.WriteLine((i+1) + " " +  department[i]);
            }

            Console.Write(" \n Enter your Department id : ");
            int id = Convert.ToInt32(Console.ReadLine());

            switch (id)
            {
                case 1:
                    Console.WriteLine("Your Department : " + department[0]);
                    break;
                case 2:
                    Console.WriteLine("Your Department : " + department[1]);
                    break;
                case 3:
                    Console.WriteLine("Your Department : " + department[2]);
                    break;
                case 4:
                    Console.WriteLine("Your Department : " + department[3]);
                    break;
                case 5:
                    Console.WriteLine("Your Department : " + department[4]);
                    break;
                default:
                    Console.WriteLine("Department not exist \n");
                    break;
            }
		}


    }
}
