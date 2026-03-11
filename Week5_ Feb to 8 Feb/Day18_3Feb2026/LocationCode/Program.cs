namespace LocationCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Invoice Number : ");
            string invoiceNumber = Console.ReadLine();

            Console.WriteLine(UserProgramCode.UpdateLocation(invoiceNumber));
        }
    }
}
 