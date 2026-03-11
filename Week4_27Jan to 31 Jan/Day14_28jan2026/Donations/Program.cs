namespace Donations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of array : ");
            int input2 = Convert.ToInt32(Console.ReadLine());

            string[] input1 = new string[input2];

            for(int i=0; i<input2; i++)
            {
                input1[i] = Console.ReadLine();
            }

            int input3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(UserProgramCode.GetDomain(input1, input3));
        }
    }
}
