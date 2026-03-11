namespace lamda_Expression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> lst = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // print even number
            List<int> ans = lst.FindAll(x => x % 2 == 0);

            foreach(int number in ans)
            {
                Console.Write("{0} " , number);
            }
            Console.WriteLine();

            // print odd number
            List<int> ans2 = lst.FindAll(x => x % 2 != 0);
            
            foreach(int number in ans2)
            {
                Console.Write("{0} ", number);
            }

            var templist = lst.Select(x => x * x);
            foreach(int number in templist)
            {
                Console.Write("{0} ", number);
            }

           var cubeOfNumber = lst.Select(x => x * x * x);
            foreach(int cube in cubeOfNumber)
            {
                Console.Write(cube + " ");
            }

            Console.WriteLine("\n");

            Console.WriteLine(LamdaFunctions.Add(3, 4));
			Console.WriteLine(LamdaFunctions.Sub(3, 4));
			Console.WriteLine(LamdaFunctions.Odd(4));
		}
    }
}
