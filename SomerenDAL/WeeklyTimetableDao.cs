using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using SomerenModel;

namespace SomerenDAL
{
    public class WeeklyTimetableDao : BaseDao
    {
        public List<string> GetAllWeeklyActivities(DateTime startDate)
        {
            string query = "SELECT a.activity_name, ISNULL(l.FirstName, 'Unsupervised') as FirstName, ISNULL(l.LastName, 'Unsupervised') as LastName, a.start_time, a.end_time from Activity a LEFT JOIN ActivitySupervisor al on al.ActivityID = a.activity_id LEFT JOIN Lecturer l on l.lecturer_id = al.LecturerID WHERE CONVERT(date, a.start_time) = CONVERT(date, @startDate) ORDER BY a.activity_name;";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@startDate", startDate);
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<string> ReadTables(DataTable dataTable)
        {
            List<string> activityList = new List<string>();

            string currentActivityName = null;
            string currentSupervisors = null;

            foreach (DataRow dr in dataTable.Rows)
            {
                string activityName = (string)dr["activity_name"];
                string firstName = (string)dr["FirstName"];
                string lastName = (string)dr["LastName"];

                if (activityName != currentActivityName)
                {
                    if (currentActivityName != null)
                    {
                        activityList.Add(currentActivityName);
                        activityList.Add("Supervisors: " + currentSupervisors);
                        activityList.Add("-----------------------------------");
                    }

                    currentActivityName = activityName;
                    if(firstName != "Unsupervised")
                        currentSupervisors = firstName + " " + lastName;
                    else
                        currentSupervisors = firstName;
                }
                else
                {
                    if (firstName != "Unsupervised")
                        currentSupervisors += ", " + firstName + " " + lastName;                        
                    else
                        currentSupervisors += ", " + firstName;
                }
            }

            if (currentActivityName != null)
            {
                activityList.Add(currentActivityName);
                activityList.Add("Supervisors: " + currentSupervisors);
                activityList.Add("-----------------------------------");
            }

            return activityList;
        }
    }
}
