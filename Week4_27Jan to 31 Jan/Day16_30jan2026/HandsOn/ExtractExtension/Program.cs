namespace ExtractExtension
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter file with extension : ");
            string file = Console.ReadLine();

            Console.WriteLine(UserProgramCode.Extract(file));
        }
    }
}
