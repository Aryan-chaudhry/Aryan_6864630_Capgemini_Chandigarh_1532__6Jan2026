namespace multipleOfThree
{
   
    internal class Program
    {

		public int CountMultipleOfThree()
		{
			Console.WriteLine("Enter the size of Array ");
			int size = Convert.ToInt32(Console.ReadLine());
			int output = 0;

			int[] arr = new int[size];

			// taking input
			for (int i = 0; i < size; i++)
			{
				arr[i] = Convert.ToInt32(Console.ReadLine());
			}

			bool negativeElement = false;

			foreach (int number in arr)
			{
				if (number < 0)
				{
					negativeElement = true;
					break;
				}
			}

			if (negativeElement)
			{
				output = -1;
			}
			else
			{
				foreach (int number in arr)
				{
					if (number % 3 == 0)
					{
						output++;
					}
				}
			}
			return output;
		}

		static void Main(string[] args)
        {
            Program obj = new Program();
            int output = obj.CountMultipleOfThree();
            Console.WriteLine(output);
        }
    }
}
