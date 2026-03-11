namespace BankManagementSystem
{
	class SavingsAccount : BankAccount
	{
		private const double InterestRate = 0.04; // 4%

		public SavingsAccount(int accNo, string name, double initialBalance)
			: base(accNo, name, initialBalance)
		{
		}

		public void CalculateInterest()
		{
			double interest = Balance * InterestRate;
			Balance += interest;
		}

		public override void DisplaySummary()
		{
			System.Console.WriteLine("\n--- Savings Account Summary ---");
			System.Console.WriteLine($"Account No: {AccountNumber}");
			System.Console.WriteLine($"Holder: {AccountHolderName}");
			System.Console.WriteLine($"Balance: ₹{Balance}");
		}
	}
}
