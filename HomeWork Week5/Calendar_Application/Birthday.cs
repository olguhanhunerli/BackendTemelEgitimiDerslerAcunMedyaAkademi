
using System;

namespace CalendarApplication
{
    public class Birthday : Event
    {
        public override void GetEventDetails()
        {
            Console.WriteLine($"Birthday: {Name} on {Date}");
        }
    }
}
