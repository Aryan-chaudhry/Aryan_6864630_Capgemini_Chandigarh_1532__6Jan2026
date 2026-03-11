namespace ParanthesisChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            Console.WriteLine(checkParenthesis.validate(str));
        }
    }
}
