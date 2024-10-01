
using System;

namespace StoreProductManagement
{
    public class FoodProduct : Product
    {
        public DateTime ExpirationDate { get; set; }

        public void CheckExpiration()
        {
            if (ExpirationDate < DateTime.Now)
                Console.WriteLine($"{Name} has expired.");
            else
                Console.WriteLine($"{Name} is good until {ExpirationDate.ToShortDateString()}.");
        }
    }
}
