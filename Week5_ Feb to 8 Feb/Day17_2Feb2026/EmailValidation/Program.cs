namespace EmailValidation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter email for validation : ");
            string email = Console.ReadLine();

            Console.WriteLine(UserProgramCode.validateEmail(email));
        }
    }
}
