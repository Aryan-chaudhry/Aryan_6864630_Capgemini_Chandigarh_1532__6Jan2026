namespace StrongPasswordValidation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Strong Password : ");
            string password = Console.ReadLine();
            Console.WriteLine(UserProgramCode.Validate(password));
        }
    }
}
