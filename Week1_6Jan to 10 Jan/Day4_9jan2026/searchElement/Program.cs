namespace searchElement
{
    internal class Program
    {
        public int SearchElement()
        {
            Console.WriteLine("Enter the size of array : ");
            int size = Convert.ToInt32(Console.ReadLine());
            int output = 0;

            if(size < 0)
            {
                output = -2;
            }
            
            int[] arr = new int[size];

            for (int i = 0; i < size; i++)
            {
               arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            // check element of array
            foreach(int no in arr)
            {
                if(no < 0)
                {
                    output = -2;
                    break;
                }
            }

            Console.Write("Enter the target : ");
            int target = Convert.ToInt32(Console.ReadLine());

            int found = arr.BinarySearch(target);

            if(found >= 0)
            {
                output = found;
            }
            else
            {
                output = -1;  
            }

            return output;  
        }

        static void Main(string[] args)
        {
            Program obj = new Program();
            int answer = obj.SearchElement();
            Console.WriteLine(answer);
        }
    }
}
