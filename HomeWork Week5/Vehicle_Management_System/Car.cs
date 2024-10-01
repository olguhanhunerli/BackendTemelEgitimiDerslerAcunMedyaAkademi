
using System;

namespace VehicleManagementSystem
{
    public class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }

        public override void ShowDetails()
        {
            Console.WriteLine($"{Year} {Make} {Model}, Doors: {NumberOfDoors}");
        }
    }
}
