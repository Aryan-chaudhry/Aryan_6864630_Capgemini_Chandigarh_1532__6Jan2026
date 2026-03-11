using System;
using System.Collections.Generic;
using System.Text;

namespace EcommercePlatform
{
    internal class Products
    {
        

        public static int productId = 1;

        public static Dictionary<int, string> products = new Dictionary<int, string>();

        public string[] category = new string[10] { "Electronics", "Clothing", "Books", "Groccery", "Furniture", "Shoes", "Vehicles", "Gaming", "Beauty Products", "Utensils" };
        public void AddProduct()
        {
            Console.Write("Enter Product Name : ");
            string productName = Console.ReadLine();

			Console.WriteLine("\nSelect Product Category \n");

			for (int i=0; i<category.Length; i++)
            {
                Console.WriteLine(string.Format("{0} {1}", (i + 1), category[i]));
            }
            Console.Write("\n Enter product Id : ");		
			int categoryId = Convert.ToInt32(Console.ReadLine());

            string categoryName = category[categoryId - 1];

            products[productId] = productName + "         " + categoryName;
            productId++;

            Console.WriteLine("Product Added Successfully \n");
		}

        public void showAllProduct()
        {
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine($"                    PRODUCTS                      ");
			Console.WriteLine("---------------------------------------------------");

            foreach(var item in products)
            {
                Console.WriteLine($"{item.Key}      {item.Value}");
            }
		}
    }
}
