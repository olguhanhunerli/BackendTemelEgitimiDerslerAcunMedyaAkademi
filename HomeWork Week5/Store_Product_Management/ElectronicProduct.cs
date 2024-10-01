
using System;

namespace StoreProductManagement
{
    public class ElectronicProduct : Product
    {
        public int WarrantyPeriod { get; set; } // in months

        public void CheckWarranty()
        {
            Console.WriteLine($"{Name} has {WarrantyPeriod} months of warranty left.");
        }
    }
}
