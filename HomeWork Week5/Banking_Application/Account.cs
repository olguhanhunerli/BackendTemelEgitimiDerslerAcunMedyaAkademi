
using System;

namespace BankingApplication
{
    public abstract class Account
    {
        public string AccountNumber { get; set; }
        public decimal Balance { get; protected set; }

        public void Deposit(decimal amount)
        {
            Balance += amount;
            Console.WriteLine($"Deposited {amount} to {AccountNumber}. New balance: {Balance}");
        }

        public void Withdraw(decimal amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrew {amount} from {AccountNumber}. New balance: {Balance}");
            }
            else
            {
                Console.WriteLine($"Insufficient funds in {AccountNumber}.");
            }
        }

        public void GetBalance()
        {
            Console.WriteLine($"Account {AccountNumber} has balance: {Balance}");
        }
    }
}
