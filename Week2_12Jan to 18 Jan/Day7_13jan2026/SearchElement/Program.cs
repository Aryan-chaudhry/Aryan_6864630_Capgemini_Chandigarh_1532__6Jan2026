using System.Xml;

namespace SearchElement
{
    internal class Program
    {
        public int SearchTargetElement()
        {
            Console.WriteLine("Enter the size of array : ");
            int input2 = Convert.ToInt32(Console.ReadLine());
            int output = -1;

            if(input2 < 0)
            {
                output = -2;
                return output;
            }
            int[] input1 = new int[input2];

            // take input
            for(int i=0; i<input2; i++)
            {
                input1[i] = Convert.ToInt32(Console.ReadLine());
            }
            // check negative element
            bool isNegativeElement = false;

            foreach(int number in input1)
            {
                if(number < 0)
                {
                    isNegativeElement = true;
                    break;
                }
            }

            if (isNegativeElement)
            {
                output = -1;
                return output;
            }

            Console.WriteLine("Enter target : ");
            int input3 = Convert.ToInt32(Console.ReadLine());


            bool targetFound = false;

            for(int index=0; index<input2; index++)
            {
                if (input1[index] == input3)
                {
                    targetFound = true;
                    break;
                }
            }

            output = targetFound ? 1 : -3;
            return output;
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            int output = obj.SearchTargetElement();
            Console.WriteLine(output);
        }
    }
}
