using System.Globalization;
using System.Text.RegularExpressions;

namespace EmployeeDesignation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter size ");
            int input1 = Convert.ToInt32(Console.ReadLine());
            string[] input2 = new string[input1];

            bool isSpecialChar = false;

            for(int i=0; i<input1; i++)
            {
                string str = Console.ReadLine();

                // if any special char return -1
                bool status = Regex.IsMatch(str, @"^[a-zA-Z]+$");

                if(status == false)
                {
                    isSpecialChar = true;
                    break;
                }
                else
                {
                    input2[i] = str;
                }
            }

            if (isSpecialChar)
            {
                Console.WriteLine("Invalid Input");
            }
            else
            {
                Console.Write("Enter Designation : ");
                string designation = Console.ReadLine();

                bool status = Regex.IsMatch(designation, @"^[a-zA-Z]+$");

                if(status == false)
                {
                    Console.WriteLine("Invalid Input");
                }
                else{
                    var stringArray = UserProgramCode.getEmployee(input2, designation);

                    foreach(var element in stringArray)
                    {
                        Console.Write(element + " ");
                    }
                }
            }
        }
    }
}
