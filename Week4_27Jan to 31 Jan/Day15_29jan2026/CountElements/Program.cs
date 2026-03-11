namespace CountElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of array : ");
            int size = Convert.ToInt32(Console.ReadLine());

            string[] words = new string[size];

            for(int i=0; i<size; i++)
            {
                words[i] = Console.ReadLine();
            }

            Console.WriteLine("Enter Char : ");
            char ch = Convert.ToChar(Console.ReadLine());

            if (!Char.IsLetter(ch))
            {
                Console.WriteLine(-2);
            }
            else
            {
                Console.WriteLine(UserProgramCode.GetCount(words, ch));
            }
        }
    }
}
