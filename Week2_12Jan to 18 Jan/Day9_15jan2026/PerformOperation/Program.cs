using System.Xml;

namespace PerformOperation
{
    internal class Program
    {
        public int PerformOperations()
        {
            Console.Write("Enter first number : ");
            int inpu1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second Number : ");
            int input2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter input for operation from 1 to 4 : ");
            int input3 = Convert.ToInt32(Console.ReadLine());
            int Output = 0;

            switch (input3)
            {
                case 1: Output = inpu1 + input2;
                    break;
                case 2: Output = inpu1 - input2;
                    break;
                case 3: Output = inpu1 * input2;
                    break;
                case 4: Output = inpu1 / input3;
                    break;
                default: Console.Write("Please enter valid key");
                    break;
            }

            return Output;
        }

		static void Main(string[] args)
        {
            Program obj = new Program();
            int output = obj.PerformOperations();
            Console.Write(output);
        }
    }
}
