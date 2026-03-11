namespace FindSaving
{
    internal class Program
    {
        public double FindSavingOfPerson()
        {
            Console.Write("Enter the salary of Person : ");
            double input1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the total working days : ");
            int input2 = Convert.ToInt32(Console.ReadLine());

            double output = 0;

            if (input1 > 9000)
            {
                output = -1;
                return output;
            }
            else if(input1 < 0)
            {
                output = -2;
                return output;
            }
            else if(input2 < 0)
            {
                output = -4;
                return output;
            }

            // check if total working days are 31 add 500 to total salary and then find saving
            if(input2 == 31)
            {
                input1 += 500;
                double totalExpense = 0.5 * input1 + 0.2 * input1;
                double saving = input1 - totalExpense;
                output = saving;
            }
            else
            {
				double totalExpense = 0.5 * input1 + 0.2 * input1;
				double saving = input1 - totalExpense;
				output = saving;
			}
            return output;            
        }

		static void Main(string[] args)
        {
            Program obj = new Program();
            double output = obj.FindSavingOfPerson();
            Console.Write(output);
        }
    }
}
