namespace CountRupees
{
    internal class Program
    {
        int CountIndianRupee()
        {
            Console.Write("Enter size please : ");
            int input2 = Convert.ToInt32(Console.ReadLine());
            int output = 0;


            bool isNegativeElement = false;

            if(input2 < 0)
            {
                isNegativeElement = true;
            }

            if (isNegativeElement)
            {
                output = -1;
            }

            else
            {
                while(input2 > 0)
                {
                    if(input2 >= 500)
                    {
                        int digit = input2 / 500;
                        input2 -= digit * 500;
                        output += digit;
                    }
                    else if(input2 >= 100)
                    {
						int digit = input2 / 100;
						input2 -= digit * 100;
						output += digit;
					}
                    else if(input2 >= 50)
                    {
						int digit = input2 / 50;
						input2 -= digit * 50;
						output += digit;
					}
                    else if(input2 >= 10)
                    {
						int digit = input2 / 10;
						input2 -= digit * 10;
						output += digit;
					}
                    else if (input2 >= 1)
                    {
						int digit = input2 / 1;
						input2 -= digit * 1;
						output += digit;
					}
                }
            }
            return output;
        }

		static void Main(string[] args)
        {
            Program obj = new Program();
            int output = obj.CountIndianRupee();
            Console.Write(output);
        }
    }
}
