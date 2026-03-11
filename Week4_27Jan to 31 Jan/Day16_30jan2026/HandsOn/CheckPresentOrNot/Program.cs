namespace CheckPresentOrNot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            string input3 = Console.ReadLine();


            Console.WriteLine(UserProgramCode.Check(input1, input2, input3));
            
        }
    }
}
