using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using SomerenModel;

namespace SomerenDAL
{
    public class StudentDao : BaseDao
    {
        public List<Student> GetAllStudents()
        {

            string query = "SELECT student_id , student_number , class_name , Firstname , Lastname , Phonenumber , room_id FROM [Students]";

            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Student> ReadTables(DataTable dataTable)
        {
            List<Student> students = new List<Student>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Student student = new Student()
                {
                    id = (int)dr["student_Id"],
                    number = (int)dr["student_number"],
                    className = dr["class_name"].ToString(),
                    First_name = dr["Firstname"].ToString(),
                    Last_name = dr["Lastname"].ToString(),
                    Phone_number = (int)dr["Phonenumber"],
                    room = (int)dr["room_Id"],

                };
                students.Add(student);
            }
            return students;
        }
    }
}