namespace ValidatePassword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter password : ");
            string password = Console.ReadLine();

            Console.WriteLine(UserProgramCode.Validate(password));
        }
    }
}
