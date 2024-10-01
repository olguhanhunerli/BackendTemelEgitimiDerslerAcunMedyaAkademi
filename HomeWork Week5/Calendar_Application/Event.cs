
using System;

namespace CalendarApplication
{
    public abstract class Event
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }

        public abstract void GetEventDetails();
    }
}
