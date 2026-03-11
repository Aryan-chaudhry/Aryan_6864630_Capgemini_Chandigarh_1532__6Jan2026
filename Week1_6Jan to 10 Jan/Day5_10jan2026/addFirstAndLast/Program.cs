using System.Runtime.CompilerServices;

namespace addFirstAndLast
{
    internal class Program
    {
        public void AddFirstAndLastElement()
        {
            Console.WriteLine("Enter the size of forst Array 1 : ");
            int size1 = Convert.ToInt32(Console.ReadLine());
            int[] arr1 = new int[size1];

            Console.WriteLine("Enter the size of Array 2 : ");
            int size2 = Convert.ToInt32(Console.ReadLine());
            int[] arr2 = new int[size2];

            // taking input of array 1
            Console.WriteLine("Enter values in array 1 ");
            for (int i = 0; i < size1; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            // taking input of array 2
            Console.WriteLine("Enter values in array 2");
            for (int i = 0; i < size2; i++)
            {
                arr2[i] = Convert.ToInt32(Console.ReadLine());
            }

            // add elements to new array
            int x = 0, y = arr2.Length - 1;
            int[] output = new int[size1];
            int k = 0;

            while (x < arr1.Length && y >= 0)
            {
                output[k++] = arr1[x] + arr2[y];
                x++;
                y--;
            }

            // check if negative element store -1 at first position in output array
            bool isNegativeElement = false;

            for(int i=0; i<size1; i++)
            {
                if (arr1[i] < 0 || arr2[i] < 0)
                {
                    isNegativeElement = true;
                    break;
                }
            }

            output[0] = isNegativeElement ? -1 : output[0];

            foreach(int number in output)
            {
                Console.Write(number + " ");
            }
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.AddFirstAndLastElement();
        }
    }
}
