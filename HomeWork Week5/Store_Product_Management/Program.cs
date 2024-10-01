
using System;

namespace StoreProductManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            FoodProduct apple = new FoodProduct { Name = "Apple", Price = 0.5m, StockQuantity = 100, ExpirationDate = DateTime.Now.AddMonths(1) };
            ElectronicProduct phone = new ElectronicProduct { Name = "Smartphone", Price = 500m, StockQuantity = 50, WarrantyPeriod = 12 };

            apple.CheckStock();
            phone.CheckStock();
        }
    }
}
