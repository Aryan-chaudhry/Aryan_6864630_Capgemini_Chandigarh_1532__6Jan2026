using System.Data;

namespace BookStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Welcome to Book Inventory System \n");
			bool cond = true;

			while (cond)
            {

				Console.WriteLine("1. Add new Book to Inventory");
				Console.WriteLine("2. Find cheaper Books");
				Console.WriteLine("3. Increase the Price of Books");
				Console.WriteLine("4. Books out of stocks");
				Console.WriteLine("5. Exit \n");

				Console.Write("Enter your choice Please : ");
				int choice = Convert.ToInt32(Console.ReadLine());

				bookStore store = new bookStore();

				switch (choice)
				{
					case 1:
						store.AddBook();
						break;
					case 2:
						store.FindBook();
						break;
					case 3:
						store.IncreasePrice();
						break;
					case 4:
						store.OutOfStockBooks();
						break;
					case 5: cond = false;
						break;
					default:
						Console.Write("Enter the valid Key Please");
						break;
				}
			}
        }
    }
}
