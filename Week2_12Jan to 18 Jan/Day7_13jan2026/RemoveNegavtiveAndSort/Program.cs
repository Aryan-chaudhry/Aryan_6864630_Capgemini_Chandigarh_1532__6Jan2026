namespace RemoveNegavtiveAndSort
{
    internal class Program
    {
        public int[] RemoveNegavtiveAndSortArray()
        {
            Console.Write("Enter the size of array");
            int input2 = Convert.ToInt32(Console.ReadLine());

            if(input2 < 0)
            {
                return [-1];
            }

            int[] input1 = new int[input2];
            int positiveElements = 0;

            for(int i=0; i<input2; i++)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                positiveElements = number >= 0 ? positiveElements + 1 : 0;
                input1[i] = number;
            }

            int[] output = new int[positiveElements];
            int index = 0;

            foreach(int number in input1)
            {
                if(number >= 0)
                {
                    output[index++] = number;
                }
            }

            output.Sort();

            return output;
        }

		static void Main(string[] args)
        {
            Program obj = new Program();
            var output = obj.RemoveNegavtiveAndSortArray();

            foreach(int number in output)
            {
                Console.Write(number + " ");
            }
        }
    }
}
