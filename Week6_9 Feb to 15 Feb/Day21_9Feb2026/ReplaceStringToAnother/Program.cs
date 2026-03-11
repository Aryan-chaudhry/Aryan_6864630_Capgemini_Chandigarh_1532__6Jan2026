namespace ReplaceStringToAnother
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "my name";
            char toReplace = 'm';
            char replaceWith = 'n';

            Console.WriteLine(UserProgramCode.Solve(str, toReplace, replaceWith));
        }
    }
}
