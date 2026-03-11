namespace ReplaceString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the string : "); ;
            string input1 = Console.ReadLine();

            Console.Write("Enter n : ");
            int input2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter special Char : ");
            char input3 = Convert.ToChar(Console.ReadLine());

            string ans = UserProgramCode.ReplaceString(input1, input2, input3);

            if (ans.Equals("-1"))
            {
                Console.WriteLine("Invalid String");
            }
            else if (ans.Equals("-2"))
            {
                Console.WriteLine("Number not positive");
            }
            else if (ans.Equals("-3"))
            {
                Console.WriteLine("Character is not a special char");
            }
            else
            {
                Console.WriteLine(ans);
            }
        }
    }
}
