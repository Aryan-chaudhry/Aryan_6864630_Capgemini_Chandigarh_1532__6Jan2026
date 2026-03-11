namespace InsertChar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String");
            string str = Console.ReadLine();

            Console.WriteLine("Enter character");
            char ch = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter Position");
            int position = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(UserProgramCode.solve(str, ch, position));
        }
    }
}
