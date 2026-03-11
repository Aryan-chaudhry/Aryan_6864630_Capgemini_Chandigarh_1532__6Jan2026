namespace EcommercePlatform
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("WELCOME TO E-COMMERCE PLATFORM \n");
            

            Customer customer =  new Customer();
			Products product = new Products();
			Cart crt = new Cart();
			Order order = new Order();

			bool isSignedIn = false;
            while (true)
            {
				if (isSignedIn == true)
				{
					Console.WriteLine("Select the query \n");
					Console.WriteLine("1. Add Products");
					Console.WriteLine("2. View All Products");
					Console.WriteLine("3. Add to Cart");
					Console.WriteLine("4. Placed Order");
					Console.WriteLine("5. Logout");
					Console.WriteLine("6. Exit");

					int choice = Convert.ToInt32(Console.ReadLine());

					switch (choice)
					{
						case 1:
							product.AddProduct();
							break;
						case 2:
							product.showAllProduct();
							break;
						case 3:
							crt.AddToCart();
							break;
						case 4:
							order.placedOrder();
							break;
						case 5:
							bool ans = customer.Logout();
							isSignedIn = ans;
							break;
						case 6:
							return;
						default:
							Console.Write("You Enter Wrong Key");
							break;
					}
				}
				else
				{
					Console.WriteLine("signup or Login to your Account\n");

					Console.WriteLine("1. Signup or Login ");
					Console.WriteLine("2. Exit");

					int choice = Convert.ToInt32(Console.ReadLine());
					switch (choice)
					{
						case 1:
							bool ans = customer.SignIn();
							isSignedIn = ans;
							break;
						case 2:
							return;
						default:
							Console.Write("You Enter Wrong Key");
							break;
					}
				}
			}
		}
    }
}
