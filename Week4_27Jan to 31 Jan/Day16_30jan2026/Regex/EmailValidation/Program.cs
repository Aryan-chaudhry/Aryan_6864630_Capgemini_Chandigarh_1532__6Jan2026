namespace EmailValidation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String str = Console.ReadLine();
            Console.WriteLine(UserProgramCode.ValidateEmail(str));

        }
    }
}
