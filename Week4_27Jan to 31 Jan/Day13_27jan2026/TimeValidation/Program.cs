namespace TimeValidation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            Console.WriteLine(ValidateMyTime.Validate(str));
        }
    }
}
