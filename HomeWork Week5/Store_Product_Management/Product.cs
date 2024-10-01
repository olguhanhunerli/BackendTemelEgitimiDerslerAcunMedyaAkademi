
using System;

namespace StoreProductManagement
{
    public abstract class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }

        public void CheckStock()
        {
            Console.WriteLine($"{Name} has {StockQuantity} items in stock.");
        }

        public void UpdateStock(int quantity)
        {
            StockQuantity += quantity;
            Console.WriteLine($"Stock for {Name} updated. New stock quantity: {StockQuantity}");
        }
    }
}
