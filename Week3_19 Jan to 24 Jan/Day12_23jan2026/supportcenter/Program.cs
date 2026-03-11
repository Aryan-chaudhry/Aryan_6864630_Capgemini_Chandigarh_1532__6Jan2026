namespace supportcenter
{
    internal class Program
    {
        static void Main(string[] args)
        {

            BuyTicket buy = new BuyTicket();
            buy.BookTicket();
            buy.BookTicket();
            buy.BookTicket();

            buy.DisplayCustHistory();

            buy.DeleteHistory();
        }
    }
}
