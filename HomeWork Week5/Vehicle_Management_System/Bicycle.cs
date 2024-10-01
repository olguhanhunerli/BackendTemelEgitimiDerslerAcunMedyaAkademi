
using System;

namespace VehicleManagementSystem
{
    public class Bicycle : Vehicle
    {
        public bool HasBell { get; set; }

        public override void ShowDetails()
        {
            Console.WriteLine($"{Year} {Make} {Model}, Has Bell: {HasBell}");
        }
    }
}
