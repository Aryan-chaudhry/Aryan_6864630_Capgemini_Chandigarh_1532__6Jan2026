namespace RemoveDuplicates
{
    internal class Program
    {
        public int[] RemoveDuplicate()
        {
            Console.WriteLine("Enter the size of array");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] arr;

            if (size < 0)
            {
                arr = new int[1];
                arr[0] = -1;
                return arr;
            }
            
            arr = new int[size];

            // take input of array
            for(int index=0; index<size; index++)
            {
                arr[index] = Convert.ToInt32(Console.ReadLine());
            }

            // check if negative element store -1 at first postion
            bool negativeElement = false;
                
            foreach(int number in arr)
            {
                if(number < 0)
                {
                     negativeElement = true;
                     break;
                }
            }

            if (negativeElement)
            {
                return [-1];
            }
                
            arr.Sort();

            int i = 0, j = i + 1;

            while (j < arr.Length)
            {
                if (arr[i] != arr[j])
                {
                     i++;
                     arr[i] = arr[j];
                }
                j++;
            }

            int[] output = new int[i + 1];
            int k = 0;

            for(int index=0; index<=i; index++)
            {
                output[k++] = arr[index];
            }
            return output;
        }
        static void Main(string[] args)
        {
            Program obj = new Program();

            var output = obj.RemoveDuplicate();

            foreach(int number in output)
            {
                Console.Write(number + " ");
            }

        }
    }
}
