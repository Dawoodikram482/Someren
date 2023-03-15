using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using SomerenModel;

namespace SomerenDAL
{
    public class RoomDao : BaseDao
    {
        public List<room> GetAllStudents()
        {
            string query = "SELECT StudentId, Name FROM [TABLE]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<room> ReadTables(DataTable dataTable)
        {
            List<room> students = new List<room>();

            foreach (DataRow dr in dataTable.Rows)
            {
                room student = new room()
                {
                    Number = (int)dr["StudentId"],
                    Name = dr["Name"].ToString()
                };
                students.Add(student);
            }
            return students;
        }
    }
}