
using System;

namespace BankingApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingsAccount savings = new SavingsAccount { AccountNumber = "123456", Balance = 1000m };
            CheckingAccount checking = new CheckingAccount { AccountNumber = "654321", Balance = 500m };

            savings.Deposit(500);
            checking.WriteCheck(100);
        }
    }
}
