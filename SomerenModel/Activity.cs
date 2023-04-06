using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Activity
    {
        public int activityID { get; set; } //activity id eg: 1,2,3
        public string activityName { get; set; } // activity name eg: pingpong obstacle course
        public DateTime startTime { get; set; } //start time  eg: 06-04-2023 05:30:00
        public DateTime endTime { get; set; } //end time  eg: 06-04-2023 06:30:00
    }
}
