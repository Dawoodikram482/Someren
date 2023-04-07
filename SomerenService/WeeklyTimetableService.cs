using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;

namespace SomerenService
{
    public class WeeklyTimetableService
    {
        private WeeklyTimetableDao timetableDao;

        public WeeklyTimetableService()
        {
            timetableDao = new WeeklyTimetableDao();
        }

        public List<string> GetWeeklyActivities(DateTime startDate)
        {
            List<string> weeklyActivities = timetableDao.GetAllWeeklyActivities(startDate);
            return weeklyActivities;
        }
    }
}
