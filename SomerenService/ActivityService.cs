using SomerenDAL;
using SomerenModel;
using System.Collections.Generic;

namespace SomerenService
{
    public class ActivityService
    {
        private ActivityDao activityDb;

        public ActivityService()
        {
            activityDb = new ActivityDao();
        }

        public List<Activity> GetActivities()
        {
            List<Activity> activities = activityDb.GetAllActivities();
            return activities;
        }

        public List<Activity> GetASActivities()
        {
            List<Activity> activities = activityDb.GetAllASActivities();
            return activities;
        }
    }

}
