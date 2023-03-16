using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SomerenService
{
    public class TeacherService
    {
        private TeacherDao teacherDb;

        public TeacherService()
        {
            teacherDb = new TeacherDao();
        }

        public List<Teacher> GetTeachers()
        {
            List<Teacher> teachers = teacherDb.GetAllTeachers();
            return teachers;
        }
    }
}
