
using System;

namespace BankingApplication
{
    public class CheckingAccount : Account
    {
        public void WriteCheck(decimal amount)
        {
            Withdraw(amount);
            Console.WriteLine($"Check written for {amount} from {AccountNumber}");
        }
    }
}
