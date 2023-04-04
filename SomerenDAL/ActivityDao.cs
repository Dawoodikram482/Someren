using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenModel;

namespace SomerenDAL
{
    public class ActivityDao : BaseDao
    {
        public List<Activity> GetAllActivities()
        {
            string query = "SELECT activity_id,activity_name,start_time,end_time FROM [dbo].[Activity]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Activity> ReadTables(DataTable dataTable)
        {
            List<Activity> activities = new List<Activity>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Activity _act = new Activity()
                {
                    activityID = (int)dr["activity_id"],
                    activityName = dr["activity_name"].ToString(),
                    startTime = (DateTime)dr["start_time"],
                    endTime = (DateTime)dr["end_time"]


                };
                activities.Add(_act);
            }
            return activities;
        }

    }
}
