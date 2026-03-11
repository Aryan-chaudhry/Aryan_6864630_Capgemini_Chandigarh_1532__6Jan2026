namespace ArrayMultiplication
{
    internal class Program
    {
        public void MultiplyArray()
        {
            Console.WriteLine("Enter the sise of both array");
            int sizeOfArrays = Convert.ToInt32(Console.ReadLine());
            int size1, size2, size3 = 0;
            size1 = size2 = size3 = sizeOfArrays;

            int[] arr1 = new int[size1];
            int[] arr2 = new int[size2];
            int[] output = new int[size3];

            // taking input of first array1
            for(int i=0; i<size1; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            // taking input of second array2
            for(int i=0; i<size2; i++)
            {
                arr2[i] = Convert.ToInt32(Console.ReadLine());
            }

            // calculating the final array

            for(int i=0; i<size3; i++)
            {
                if (arr1[i] < 0 || arr2[i] < 0)
                {
                    output[i] = -1;
                }
                else
                {
                    output[i] = arr1[i] * arr2[i];
                }
            }

            foreach(int number in output)
            {
                Console.Write(number + " ");
            }
            
        }
        
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.MultiplyArray();
        }
    }
}
