using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenDAL
{
    public class TeacherDao: BaseDao
    {
        public List<Teacher> GetAllTeachers()
        {
            string query = "SELECT lecturer_id, FirstName, LastName, PhoneNumber, Lecturer_Age, is_supervise FROM Lecturer";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<Teacher> ReadTables(DataTable dataTable)
        {
            List<Teacher> teachers = new List<Teacher>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Teacher teacher = new Teacher()
                {
                    Id = (int)dr["lecturer_id"],
                    Name = $"{dr["FirstName"]} {dr["LastName"]}",
                    PhoneNumber = dr["PhoneNumber"].ToString(),
                    IsSuperviser = (bool)dr["is_supervise"],
                    Age = (int)dr["Lecturer_Age"]
                };
                teachers.Add(teacher);
            }
            return teachers;
        }
    }

}
