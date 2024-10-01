
using System;

namespace CalendarApplication
{
    public class Task : Event
    {
        public bool IsCompleted { get; private set; }

        public override void GetEventDetails()
        {
            Console.WriteLine($"Task: {Name} on {Date} at {Location}");
        }

        public void MarkAsComplete()
        {
            IsCompleted = true;
            Console.WriteLine($"Task '{Name}' is marked as completed.");
        }
    }
}
