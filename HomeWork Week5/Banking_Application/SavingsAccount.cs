
using System;

namespace BankingApplication
{
    public class SavingsAccount : Account
    {
        public decimal InterestRate { get; set; }

        public void ApplyInterest()
        {
            Balance += Balance * InterestRate;
            Console.WriteLine($"Interest applied to {AccountNumber}. New balance: {Balance}");
        }
    }
}
