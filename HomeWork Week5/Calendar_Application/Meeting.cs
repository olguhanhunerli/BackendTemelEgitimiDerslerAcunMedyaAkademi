
using System;

namespace CalendarApplication
{
    public class Meeting : Event
    {
        public override void GetEventDetails()
        {
            Console.WriteLine($"Meeting: {Name} on {Date} at {Location}");
        }

        public void ScheduleMeeting()
        {
            Console.WriteLine($"Meeting '{Name}' has been scheduled on {Date} at {Location}.");
        }
    }
}
