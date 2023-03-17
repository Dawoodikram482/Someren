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
            string query = "SELECT activity_id,activity_name,activity_time FROM [dbo].[Activity]";
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
                    activityTime = dr["activity_time"].ToString()
                };
                activities.Add(_act);
            }
            return activities;
        }

    }
}
