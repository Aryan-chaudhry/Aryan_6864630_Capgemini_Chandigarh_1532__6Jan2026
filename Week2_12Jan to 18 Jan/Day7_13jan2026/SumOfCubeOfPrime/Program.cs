namespace SumOfCubeOfPrime
{
    internal class Program
    {
		public bool isPrime(int num)
		{
			if (num <= 1) return false;

			for (int i = 2; i < num; i++)
			{
				if (num % i == 0)
				{
					return false;
				}
			}
			return true;
		} 
		public int SumofPrimeCube()
		{
			Console.WriteLine("Enter the Number : ");
			int number = Convert.ToInt32(Console.ReadLine());
			int output = 0;

			if (number < 0)
			{
				output = -1;
			}
			else if (number > 32767)
			{
				output = -2;
			}
			else
			{
				int sumOfPrime = 0;

				for (int i = 2; i <= number; i++)
				{
					if (isPrime(i))
					{
						sumOfPrime += (int)Math.Pow(i, 3);
					}
				}
				output = sumOfPrime;
			}
			return output;
		}

		static void Main(string[] args)
        {
			Program obj = new Program();
			int output = obj.SumofPrimeCube();
			Console.Write(output);
        }
    }
}
