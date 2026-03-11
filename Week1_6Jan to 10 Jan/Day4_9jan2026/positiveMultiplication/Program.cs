using System.Xml;

namespace positiveMultiplication
{
    internal class Program
    {

        public int PositiveMultiplication()
        {
            Console.WriteLine("Enter the size of array");
            int size = Convert.ToInt32(Console.ReadLine());
            int[]arr = new int[size];
            int output = 1;

            if(size < 0)
            {
                output = -2;
            }
            else
            {
				for (int i = 0; i < size; i++)
				{
					arr[i] = Convert.ToInt32(Console.ReadLine());
				}

                foreach(int number in arr)
                {
                    if(number > 0)
                    {
                        output *= number;
                    }
                }
			}

            return output;            
        }


        static void Main(string[] args)
        {
            Program obj = new Program();
            int answer = obj.PositiveMultiplication();
            Console.WriteLine(answer);
        }
    }
}
