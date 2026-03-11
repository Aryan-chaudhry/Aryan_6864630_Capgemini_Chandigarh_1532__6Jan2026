using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore
{
    internal class bookStore
    {
        public static Dictionary<string, (int, double)> Books = new Dictionary<string, (int,double)>();

        public void AddBook()
        {
            Console.Write("Enter the Name of Book : ");
            string name = Console.ReadLine();

            if (Books.ContainsKey(name))
            {
                int BookQuantity = Books[name].Item1;
                double BookPrice = Books[name].Item2;

                // update quantity of book 
                Books[name] = (BookQuantity + 1, BookPrice);    
            }
            else
            {
                Console.Write("Enter the Price of Book : ");
                double Price = Convert.ToDouble(Console.ReadLine());

                // add this new Book
                Books.Add(name, (1, Price));
                Console.WriteLine("\n Book Added Successfully \n Book Name {0} \n Book Quantity {1} \n Book Price {2}", name, Books[name].Item1, Price + "\n");
            }
        }


        public void FindBook()
        {
            Console.Write("Enter the Price Please : ");
            int price = Convert.ToInt32(Console.ReadLine());

            List<string> books = new List<string>();

            foreach(var book in Books)
            {
                double priceOfBook = book.Value.Item2;

                if(priceOfBook < price)
                {
                    books.Add(book.Key);
                }
            }

            var bookItem = from book in books
                           select book;

            foreach(string item in bookItem)
            {
                Console.Write(item + " ");
            }
        }

        public void IncreasePrice()
        {
            Console.Write("Enter the Percentage Please : ");
            int percentage = Convert.ToInt32(Console.ReadLine());

            foreach(var book in Books)
            {
                string bookName = book.Key;
                int bookQuantity = book.Value.Item1;

                double originalPriceOfBook = book.Value.Item2;
                double IncreasedPrice = originalPriceOfBook + originalPriceOfBook * percentage / 100;

                // update price of each book
                Books[bookName] = (bookQuantity, IncreasedPrice);
            }
        }

        public void OutOfStockBooks()
        {
            List<string> outOfStock = new List<string>();

            foreach(var book in Books)
            {
                if(book.Value.Item1 <= 0)
                {
                    string bookName = book.Key;
                    outOfStock.Add(bookName);
                    Books.Remove(bookName);
                }
            }

            Console.WriteLine("Out of Stock Books : ");

            foreach(var book in outOfStock)
            {
                Console.WriteLine(book);
            }
            Console.WriteLine("\n");
        }
    }
}
