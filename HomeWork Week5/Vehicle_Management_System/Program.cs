
using System;

namespace VehicleManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car { Make = "Toyota", Model = "Corolla", Year = 2020, NumberOfDoors = 4 };
            Bicycle bicycle = new Bicycle { Make = "Giant", Model = "Escape 3", Year = 2021, HasBell = true };
            Motorcycle motorcycle = new Motorcycle { Make = "Harley-Davidson", Model = "Sportster", Year = 2019, HasSidecar = false };

            car.ShowDetails();
            bicycle.ShowDetails();
            motorcycle.ShowDetails();
        }
    }
}
