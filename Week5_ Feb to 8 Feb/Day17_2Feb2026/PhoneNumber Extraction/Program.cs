namespace PhoneNumber_Extraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            UserProgramCode.fetchPhoneNumber(message);
        }
    }
}
