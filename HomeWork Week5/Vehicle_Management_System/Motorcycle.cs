
using System;

namespace VehicleManagementSystem
{
    public class Motorcycle : Vehicle
    {
        public bool HasSidecar { get; set; }

        public override void ShowDetails()
        {
            Console.WriteLine($"{Year} {Make} {Model}, Has Sidecar: {HasSidecar}");
        }
    }
}
