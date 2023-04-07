using System;
using System.Collections.Generic;

namespace SomerenModel
{
    public class WeeklyTimetable
    {
        public int Id { get; set; }
        public string ActivityType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<Teacher> Supervisors { get; set; }
    }
}
