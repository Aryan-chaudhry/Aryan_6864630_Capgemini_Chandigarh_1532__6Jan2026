using System;
using System.Collections.Generic;
using System.Text;

namespace EcommercePlatform
{
    internal class Cart:Products
    {
        public static int cartId = 1;
        public static Dictionary<int ,string> cartRecords = new Dictionary<int, string>();

        public void AddToCart()
        {
            int i = 1;
            while(i <= products.Count)
            {
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine(i + "               " + products[i]);
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine("<- (p)             Save To Cart(s)                (n) ->");
                string response = Console.ReadLine();
                if (response.Equals("p") || response.Equals("P "))
                {
                    i--;
                }
                else if (response.Equals("n") || response.Equals("N"))
                {
                    i++;
                }
                else if (response.Equals("s") || response.Equals("S"))
                {
                    cartRecords[i] = response;
                    Console.WriteLine("Product added to your cart");
                }
                Console.WriteLine("--------------------------------------------------------------\n\n\n");
            }
        }
    }
}
