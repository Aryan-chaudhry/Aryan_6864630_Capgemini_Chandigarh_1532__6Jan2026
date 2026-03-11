using System;
using System.Collections.Generic;
using System.Text;

namespace EcommercePlatform
{
    internal class Order:Products
    {
        public static int orderId = 1001;

        public void placedOrder()
        {
            Console.WriteLine("Enter the Product Name Please ");
            string productName = Console.ReadLine();
            int findProductById = 0;

            // searching the product in product list
            foreach(var item in products)
            {
                string product = item.Value;
                if (product.Contains(productName)){
                    findProductById = item.Key;
                    break;
                }
            }

            if(findProductById == 0)
            {
                Console.WriteLine("No product Find by this Name : " + productName); 
            }
            else
            {
                Console.WriteLine("Placed an Order \n");
                Console.WriteLine("Product Details");
                Console.WriteLine("Product Id : " + findProductById);
                Console.WriteLine("Product Name : " + products[findProductById]);
                Console.WriteLine("\n Are you sure want to Order : (y/n) ");
                string response = Console.ReadLine();
                if (response.Contains("s"))
                {
                    Console.WriteLine("Order Placed Successfully");
                    Console.WriteLine("Order Id : " + orderId + "\n");
                    orderId++;
                }
                else
                {
                    Console.WriteLine("Order rejected \n");
                }

            }
        }

    }
}
