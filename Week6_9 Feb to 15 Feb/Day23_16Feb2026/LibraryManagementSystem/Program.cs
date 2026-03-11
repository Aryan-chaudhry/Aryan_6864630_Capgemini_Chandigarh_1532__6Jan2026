
namespace LibraryManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
			library.Addbooks("C# Basics", 3);
			library.BorrowBook("C# Basics");
			Console.WriteLine($"Remaining copies: {library.GetBookCount("C# Basics")}");

		}
	}
}
