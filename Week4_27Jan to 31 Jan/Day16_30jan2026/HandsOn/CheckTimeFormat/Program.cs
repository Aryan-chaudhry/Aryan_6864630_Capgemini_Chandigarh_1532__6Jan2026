namespace CheckTimeFormat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter time please : ");
            string time = Console.ReadLine();

            Console.WriteLine(UserProgramCode.Check(time));
        }
    }
}
