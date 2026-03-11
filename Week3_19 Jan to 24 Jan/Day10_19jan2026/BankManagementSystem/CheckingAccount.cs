namespace BankManagementSystem
{
	class CheckingAccount : BankAccount
	{
		private const double MinBalance = 1000;

		public CheckingAccount(int accNo, string name, double initialBalance)
			: base(accNo, name, initialBalance)
		{
		}

		public override void Withdraw(double amount)
		{
			if (Balance - amount < MinBalance)
			{
				System.Console.WriteLine("Cannot withdraw! Minimum balance must be maintained.");
				return;
			}
			base.Withdraw(amount);
		}

		public override void DisplaySummary()
		{
			System.Console.WriteLine("\n--- Checking Account Summary ---");
			System.Console.WriteLine($"Account No: {AccountNumber}");
			System.Console.WriteLine($"Holder: {AccountHolderName}");
			System.Console.WriteLine($"Balance: ₹{Balance}");
		}
	}
}
