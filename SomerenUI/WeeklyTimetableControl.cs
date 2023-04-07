using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomerenUI
{
    public partial class WeeklyTimetableControl : UserControl
    {
        private string activityDate, activityDay;
        private List<string> activities;

        public WeeklyTimetableControl(string activityDate, string activityDay, List<string> activities)
        {
            InitializeComponent();

            this.activityDate = activityDate;
            this.activityDay = activityDay;
            this.activities = activities;

            UpdateDateAndDayLabels();
        }

        private void UpdateDateAndDayLabels()
        {
            labelWeekDay.Text = activityDay;
            labelWeekDay.TextAlign = ContentAlignment.MiddleCenter;

            labelDate.Text = activityDate;
            labelDate.TextAlign = ContentAlignment.MiddleCenter;

            ActivitySupervisorNames();
        }

        private void ActivitySupervisorNames()
        {
            if (activities.Count == 0)
                activities.Add("No Activities");

            listBoxWActivities.DataSource = activities;            
        }

    }
}
