using System;

namespace BankManagementSystem
{
	class Program
	{
		static void Main()
		{
			SavingsAccount savings = new SavingsAccount(1001, "Aryan", 5000);
			CheckingAccount checking = new CheckingAccount(2001, "Rohit", 8000);

			savings.Deposit(2000);
			savings.CalculateInterest();
			savings.Withdraw(1000);
			savings.DisplaySummary();

			checking.Deposit(3000);
			checking.Withdraw(9500); 
			checking.Withdraw(2000);
			checking.DisplaySummary();
		}
	}
}
