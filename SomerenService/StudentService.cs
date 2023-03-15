﻿using SomerenDAL;
using SomerenModel;
using System.Collections.Generic;

namespace SomerenService
{
    public class StudentService
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