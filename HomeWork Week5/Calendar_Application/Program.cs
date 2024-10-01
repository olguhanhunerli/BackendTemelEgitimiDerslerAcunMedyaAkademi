
using System;

namespace CalendarApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Task task = new Task { Name = "Complete Project", Date = DateTime.Now, Location = "Home" };
            task.MarkAsComplete();

            Meeting meeting = new Meeting { Name = "Team Meeting", Date = DateTime.Now.AddDays(1), Location = "Office" };
            meeting.ScheduleMeeting();
        }
    }
}
