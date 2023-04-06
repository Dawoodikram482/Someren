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
            //selecting the the records from database
            string query = "SELECT activity_id,activity_name,start_time,end_time FROM [dbo].[Activity]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Activity> ReadTables(DataTable dataTable)
        {
            //creating a list of activities
            List<Activity> activities = new List<Activity>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Activity _act = new Activity()
                {
                    //assigning the query elements to the properties of activity class
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
                //opening the connection
                conn.Open();
                //writing the sql command
                SqlCommand command = new SqlCommand(
                "INSERT INTO Activity (activity_name, start_time, end_time) " +
                "VALUES (@activity_name, @start_time, @end_time); " +
               "SELECT SCOPE_IDENTITY();",
                conn);
              //adding the value in the database from the object activity 
                command.Parameters.AddWithValue("@activity_name", activity.activityName);
                command.Parameters.AddWithValue("@start_time", activity.startTime);
                command.Parameters.AddWithValue("@end_time", activity.endTime);
                //executing the query
                command.ExecuteNonQuery();
            }
            //throwing new exception if the query doesn't work
            catch (Exception ex)
            {
                //displaying the error message
                throw new Exception("Activity Addition Failed!" + ex.Message);
            }
            finally
            {
                //closing the connection
                conn.Close();
            }
           
        }
        public void UpdateActivity(Activity activity)
        {
            try
            {
                //opeening the connection
                conn.Open();
                //writing the sql command
                SqlCommand command = new SqlCommand(
                "UPDATE Activity SET activity_name = @activity_name, start_time = @start_time, end_time = @end_time " +
                "WHERE activity_id = @activity_id",
                conn);
                //adding the value in the database from the object activity 
                command.Parameters.AddWithValue("@activity_id", activity.activityID);
                command.Parameters.AddWithValue("@activity_name", activity.activityName);
                command.Parameters.AddWithValue("@start_time", activity.startTime);
                command.Parameters.AddWithValue("@end_time", activity.endTime);
                //executing the query
                int nrOfRowsAffected = command.ExecuteNonQuery();

                //checking if any row is updated or not
                if (nrOfRowsAffected == 0)
                {
                    //throwing an exception if no row was updated
                    throw new Exception("No row was updated");
                }
            }
            //throwing new exception if the query doesn't work
            catch (Exception ex)
            {
                //displaying the failure message
                throw new Exception("Activity Updating Failed!");
            }
            finally
            {
                //closing the connection
                conn.Close();
            }

        }
        public void DeleteActivity(Activity activity)
        {
            try
            {
                //opening the connection
                conn.Open();
                //writing the command
                SqlCommand command = new SqlCommand(
                "DELETE FROM Activity WHERE activity_id = @activity_id",
                conn);
                command.Parameters.AddWithValue("@activity_id", activity.activityID);
                //executing the query
                int nrOfRowsAffected = command.ExecuteNonQuery();

                //checking if any row is deleted or not
                if (nrOfRowsAffected == 0)
                {
                    //throwing an exception if no row was deleted
                    throw new Exception("No row was updated");
                }
            }
            //throwing new exception if the query doesn't work
            catch (Exception ex)
            {
                //displaying the failure message
                throw new Exception("Activity Deletion Failed!");
            }
            finally
            {
                //closing the connection
                conn.Close();
            }
        }
    }
}
