namespace InsertElement
{
    internal class Program
    {
        public int[] InsertElement()
        {
            Console.Write("Enter the size of array : ");
            int input1 = Convert.ToInt32(Console.ReadLine());
            int[] input;

            if (input1 < 0)
            {
                return [-2];
            }

            input = new int[input1];
            
            // taking input
            for(int i=0; i<input1; i++)
            {
                input[i] = Convert.ToInt32(Console.ReadLine());
            }


            // if -ve elemeent store -1
            bool isNegativeElement = false;

            foreach(int number in input)
            {
                if(number < 0)
                {
                    isNegativeElement = true;
                    break;
                }
            }

            if (isNegativeElement)
            {
                return [-1];
            }

            input.Sort();
            Array.Resize(ref input, input.Length + 1);

            Console.Write("Enter the target element you want to insert : ");
            int target = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the index where you want to insert : ");
            int index = Convert.ToInt32(Console.ReadLine());

            int j = input.Length - 1;

            while(j >= index)
            {
                input[j] = input[j - 1];
                j--;
            }

            input[index] = target;
            
            return input;            
        }

		static void Main(string[] args)
        {
            Program obj = new Program();
            int[] output = obj.InsertElement();
            foreach(int number in output)
            {
                Console.Write(number + " ");
            }
        }
    }
}
