using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenDAL
{
    public class TeacherDao : BaseDao
    {
        public List<Teacher> GetAllTeachers()
        {
            string query = "SELECT lecturer_id, FirstName, LastName, PhoneNumber, Lecturer_Age,room_id, is_supervise FROM Lecturer";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Teacher> GetAllASTeachers(bool isSelected, int activity_id)
        {
            string query = "";

            if (isSelected)
            {
                query = "SELECT lecturer_id, FirstName, LastName, PhoneNumber, Lecturer_Age, room_id, is_supervise FROM Lecturer l where l.lecturer_id in (select a.lecturer_id from Supervisor a WHERE a.activity_id = '" + activity_id + "')";
            }
            else
            {
                query = "SELECT lecturer_id, FirstName, LastName, PhoneNumber, Lecturer_Age, room_id, is_supervise FROM Lecturer l where l.lecturer_id not in (select a.lecturer_id from Supervisor a WHERE a.activity_id = '" + activity_id + "')";
            }
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public bool CheckAlreadyExist(int lecturer_id, int activity_id)
        {
            string query = $"SELECT COUNT(*) FROM Supervisor WHERE lecturer_id = @lecturer_id AND activity_id = @activity_id;";
            SqlCommand command = new SqlCommand(query, OpenConnection());

            command.Parameters.AddWithValue("@lecturer_id", lecturer_id);
            command.Parameters.AddWithValue("@activity_id", activity_id);

            OpenConnection();

            int count = (int)command.ExecuteScalar();

            if (count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void RemoveSupervisor(int lecturer_id, int activity_id)
        {
            string query = $"DELETE FROM Supervisor WHERE lecturer_id = '{lecturer_id}' AND activity_id = '{activity_id}';";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        public void AddSupervisor(int lecturer_id, int activity_id)
        {
            string query = $"INSERT INTO Supervisor (lecturer_id, activity_id) VALUES('{lecturer_id}', '{activity_id}');";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }


        private List<Teacher> ReadTables(DataTable dataTable)
        {
            List<Teacher> teachers = new List<Teacher>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Teacher teacher = new Teacher()
                {
                    Id = (int)dr["lecturer_id"],
                    FirstName = dr["FirstName"].ToString(),
                    LastName = dr["LastName"].ToString(),
                    PhoneNumber = (int)dr["PhoneNumber"],
                    Age = (int)dr["Lecturer_Age"],
                    RoomId = (int)dr["room_id"],
                    IsSupervisor = (bool)dr["is_supervise"],
                };
                teachers.Add(teacher);
            }
            return teachers;
        }

    }
}
