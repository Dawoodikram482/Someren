using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenModel;
using System.Data.Common;

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
        public void AddActivity(Activity activity)
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(
                "INSERT INTO Activity (activity_name, start_time, end_time) " +
                "VALUES (@activity_name, @start_time, @end_time); " +
               "SELECT SCOPE_IDENTITY();",
                conn);
              
                command.Parameters.AddWithValue("@activity_name", activity.activityName);
                command.Parameters.AddWithValue("@start_time", activity.startTime);
                command.Parameters.AddWithValue("@end_time", activity.endTime);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Activity Addition Failed!" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
           
        }
        public void UpdateActivity(Activity activity)
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(
                "UPDATE Activity SET activity_name = @activity_name, start_time = @start_time, end_time = @end_time " +
                "WHERE activity_id = @activity_id",
                conn);
                command.Parameters.AddWithValue("@activity_id", activity.activityID);
                command.Parameters.AddWithValue("@activity_name", activity.activityName);
                command.Parameters.AddWithValue("@start_time", activity.startTime);
                command.Parameters.AddWithValue("@end_time", activity.endTime);

                int nrOfRowsAffected = command.ExecuteNonQuery();


                if (nrOfRowsAffected == 0)
                {
                    throw new Exception("No row was updated");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Activity Updating Failed!");
            }
            finally
            {
                conn.Close();
            }

        }
        public void DeleteActivity(Activity activity)
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(
                "DELETE FROM Activity WHERE activity_id = @activity_id",
                conn);
                command.Parameters.AddWithValue("@activity_id", activity.activityID);
                int nrOfRowsAffected = command.ExecuteNonQuery();


                if (nrOfRowsAffected == 0)
                {
                    throw new Exception("No row was updated");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Activity Deletion Failed!");
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
