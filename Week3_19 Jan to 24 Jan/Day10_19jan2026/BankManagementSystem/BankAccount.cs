using System;

namespace BankManagementSystem
{
	abstract class BankAccount
	{
		public int AccountNumber { get; private set; }
		public string AccountHolderName { get; private set; }
		protected double Balance;

		protected BankAccount(int accNo, string name, double initialBalance)
		{
			AccountNumber = accNo;
			AccountHolderName = name;
			Balance = initialBalance;
		}

		public void Deposit(double amount)
		{
			if (amount <= 0)
			{
				Console.WriteLine("Invalid deposit amount!");
				return;
			}

			Balance += amount;
			Console.WriteLine($"₹{amount} deposited successfully.");
		}

		public virtual void Withdraw(double amount)
		{
			if (amount <= 0 || amount > Balance)
			{
				Console.WriteLine("Invalid withdrawal!");
				return;
			}

			Balance -= amount;
			Console.WriteLine($"₹{amount} withdrawn successfully.");
		}

		public double GetBalance() => Balance;

		public abstract void DisplaySummary();
	}
}
