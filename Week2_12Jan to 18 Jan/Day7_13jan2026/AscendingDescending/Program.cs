namespace AscendingDescending
{
    internal class Program
    {
        public int[] SortAscDsc()
        {
            Console.Write("Enter the size of array : ");
            int input2 = Convert.ToInt32(Console.ReadLine());

            if(input2 < 0)
            {
                return [-1];
            }

            int[] input1 = new int[input2];

            for(int i=0; i<input2; i++)
            {
                input1[i] = Convert.ToInt32(Console.ReadLine());
            }

            int mid = input2 / 2;
            Array.Sort(input1, 0, input1.Length);
            Array.Reverse(input1, mid, input1.Length-mid);
            return input1;
        }

		static void Main(string[] args)
        {
            Program obj = new Program();
            int[] output = obj.SortAscDsc();
            foreach(int number in output)
            {
                Console.Write(number + " ");
            }
        }
    }
}
