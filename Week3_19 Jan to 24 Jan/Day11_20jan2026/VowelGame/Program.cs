namespace VowelGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            Console.Write(CheckVowel.GameOfVowel(input1, input2));
        }
    }
}
