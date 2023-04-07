using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public List<Teacher> GetASTeachers(bool isSelected, int activityId)
        {
            List<Teacher> teachers = teacherDb.GetAllASTeachers(isSelected, activityId);
            return teachers;
        }

        public bool CheckAlreadyExist(int LecturerID, int ActivityID)
        {
            return teacherDb.CheckAlreadyExist(LecturerID, ActivityID);
        }

        public void AddSupervisor(int LecturerID, int ActivityID)
        {
            teacherDb.AddSupervisor(LecturerID, ActivityID);
        }

        public void RemoveSupervisor(int LecturerID, int ActivityID)
        {
            teacherDb.RemoveSupervisor(LecturerID, ActivityID);
        }
    }

}
