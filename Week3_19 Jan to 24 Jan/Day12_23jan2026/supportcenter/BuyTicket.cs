using System;
using System.Collections.Generic;
using System.Text;

namespace supportcenter
{
    internal class BuyTicket:customer
    {
        public static int TicketId = 1001;
        public static Queue<string> Tickets = new Queue<string>();

        public void BookTicket()
        {
            
            Console.Write("Enter your Name Please : ");
            Name = Console.ReadLine();

            Console.Write("Enter your PhoneNumber : ");
            string PhoneNumber = Console.ReadLine();

            string Ticket = String.Format(" Name : {0} \n Mob no : {1} \n Ref Id : {2} ", Name, PhoneNumber, TicketId);
            var BookingTime = DateTime.Now.ToString();            
            Tickets.Enqueue(Ticket);
            TicketId++;

            Console.Write("Ticket Book Successfully \n Ref No " + TicketId);

            string customerHistory = String.Format("Name : {0} \n Ticket Id : {1} \n Booked at : {2}", Name, TicketId, BookingTime); // history updated
            History.Push(customerHistory);
            Console.WriteLine();
        }

        public void DisplayCustHistory()
        {
            Console.WriteLine("Customer History");

            Stack<string> clone = new Stack<string>();

            // display all History
            while(History.Count > 0)
            {
                Console.WriteLine(History.Peek());
                clone.Push(History.Peek());
                History.Pop();
            }
            Console.WriteLine();

            // addedd history back to customer history
            while(clone.Count > 0)
            {
                History.Push(clone.Peek());
                clone.Pop();
            } 
        }

        public void DeleteHistory()
        {
            Console.WriteLine();

            while(History.Count > 0)
            {
                Console.WriteLine(History.Peek());
                Console.Write("Want to Delete : (yes/no) ");
                string response = Console.ReadLine();

                if (response.Equals("yes"))
                {
                    History.Pop();
                }
                else
                {
                    break;
                }
            }
        }
        
    }
}
