using SomerenDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenService
{
    public class RoomService
    {
        private RoomDao studentdb;

        public StudentService()
        {
            studentdb = new RoomDao();
        }

        public List<room> GetStudents()
        {
            List<room> students = studentdb.GetAllStudents();
            return students;
        }
    }
}
