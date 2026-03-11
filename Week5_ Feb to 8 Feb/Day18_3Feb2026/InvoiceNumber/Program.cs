namespace InvoiceNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string invoiceNumber = Console.ReadLine();
            Console.WriteLine(UserProgramCode.UpdateInvoiceNumber(invoiceNumber));
        }
    }
}
