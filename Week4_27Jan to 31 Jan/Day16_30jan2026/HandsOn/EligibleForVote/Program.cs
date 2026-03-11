namespace EligibleForVote
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your Age : ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(UserProgramCode.CheckEligibility(age));

        }
    }
}
