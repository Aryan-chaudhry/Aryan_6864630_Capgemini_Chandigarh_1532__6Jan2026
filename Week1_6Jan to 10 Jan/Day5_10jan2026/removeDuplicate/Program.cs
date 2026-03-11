namespace removeDuplicate
{
    internal class Program
    {
        public void RemoveDuplicate()
        {
            Console.WriteLine("Enter the size of array : ");
            int size = Convert.ToInt32(Console.ReadLine());
            List<int> list = new List<int>();

            if(size < 0)
            {
                list.Add(-2);
            }
            else
            {
                int[] arr = new int[size];

                // taking input;
                for(int i = 0; i < size; i++)
                {
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }

                // contain any negative element store -1
                bool isNegativeElement = false;

                foreach(int number in arr)
                {
                    if(number < 0)
                    {
                        isNegativeElement = true;
                        break;
                    }
                }

                if (isNegativeElement)
                {
                    list.Add(-1);
                }

                arr.Sort();

                list.Add(arr[0]);

                for(int i=1; i<arr.Length; i++)
                {
                    if (list.Contains(arr[i]))
                    {
                        continue;
                    }
                    else
                    {
                        list.Add(arr[i]);
                    }
                }

            }

            foreach(int number in list)
            {
                Console.Write(number + " ");
            }
		}
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.RemoveDuplicate();
        }
    }
}
