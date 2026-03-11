namespace DateAndTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string date = Console.ReadLine();
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(UserProgramCode.Validate(date, year));
        }
    }
}
