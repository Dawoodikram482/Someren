using SomerenService;
using SomerenModel;
using System.Windows.Forms;
using System.Collections.Generic;
using System;
using System.Data;
using System.Security.Permissions;

namespace SomerenUI
{
    public partial class SomerenUI : Form
    {
        public SomerenUI()
        {
            InitializeComponent();
            ShowDashboardPanel();
        }


        // Dashboard panel
        private void ShowDashboardPanel()
        {
            // hide all other panels
            pnlStudents.Hide();
            pnlLecture.Hide();
            pnlRooms.Hide();
            // show dashboard
            pnlDashboard.Show();
        }

        private void dashboardToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            ShowDashboardPanel();
        }

        // students panel

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowStudentsPanel();
        }
        private void ShowStudentsPanel()
        {
            // hide all other panels
            pnlDashboard.Hide();
            pnlLecture.Hide();
            pnlRooms.Hide();

            // show students
            pnlStudents.Show();


            try
            {
                // get and display all students
                List<Student> students = GetStudents();
                DisplayStudents(students);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the students: " + e.Message);
            }
        }

        private List<Student> GetStudents()
        {
            StudentService studentService = new StudentService();
            List<Student> students = studentService.GetStudents();
            return students;
        }

        private void DisplayStudents(List<Student> students)
        {
            // clear the listview before filling it
            studentsDataGrid.Rows.Clear();


            foreach (Student student in students)
            {
                DataGridViewRow row = new DataGridViewRow();

                string[] studentName = student.Name.Split(' ');
                string firstName = studentName[0];
                string lastName = studentName.Length > 1 ? studentName[1] : "";
                row.CreateCells(studentsDataGrid);
                row.Cells[0].Value = student.Number;
                row.Cells[1].Value = firstName;
                row.Cells[2].Value = lastName;
                studentsDataGrid.Rows.Add(row);

            }
        }



        // Teacher panel section
        private void lecturersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowTeachersPanel();
        }

        private void ShowTeachersPanel()
        {
            // hide all other panels
            pnlDashboard.Hide();
            pnlStudents.Hide();
            pnlRooms.Hide();
            // show Lectures
            pnlLecture.Show();

            try
            {
                // get and display all students
                List<Teacher> teachers = GetTeachers();
                DisplayTeachers(teachers);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the rooms: " + e.Message);
            }
        }

        private List<Teacher> GetTeachers()
        {
            TeacherService teacherService = new TeacherService();
            List<Teacher> teachers = teacherService.GetTeachers();
            return teachers;
        }


        private void DisplayTeachers(List<Teacher> teachers)
        {
            // clear the listview before filling it
            lectureListView.Items.Clear();
            lectureListView.View = View.Details;


            foreach (Teacher teacher in teachers)
            {
                string[] arr = new string[7];

                arr[0] = teacher.Id.ToString();
                arr[1] = teacher.FirstName;
                arr[2] = teacher.LastName;
                arr[3] = teacher.PhoneNumber;
                arr[4] = teacher.Age.ToString();
                arr[5] = teacher.RoomId.ToString();
                arr[6] = teacher.IsSuperviser ? "Yes" : "No";

                lectureListView.Items.Add(new ListViewItem(arr));
            }
        }

        // Rooms panel

        private void ShowRoomsPanel()
        {
            // hide all other panels
            pnlDashboard.Hide();
            pnlStudents.Hide();
            pnlLecture.Hide();
            // show Lectures
            pnlRooms.Show();

            try
            {
                // get and display all students
                List<Room> rooms = GetRooms();
                DisplayRooms(rooms);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the teachers: " + e.Message);
            }
        }

        private List<Room> GetRooms()
        {
            RoomService roomService = new RoomService();
            List<Room> rooms = roomService.GetTeachers();
            return rooms;
        }

        private void DisplayRooms(List<Room> rooms)
        {
            // clear the listview before filling it
            //roomsDataGrid.Rows.Clear();
            roomListView.Items.Clear();
            roomListView.View = View.Details;

            foreach (Room room in rooms)
            {
                string[] arr = new string[3];

                arr[0] = room.Number.ToString();
                arr[1] = room.Capacity.ToString();
                arr[2] = room.Type ? "Teacher" : "Student";

                //roomListView.Items.Add("Col1Text").SubItems.AddRange(arr);
                roomListView.Items.Add(new ListViewItem(arr));
                ////DataGridViewRow row = new DataGridViewRow();

                //row.CreateCells(studentsDataGrid);
                //row.Cells[0].Value = room.Number;
                //row.Cells[1].Value = room.Capacity;
                //row.Cells[2].Value = room.Type ? "Teacher" : "Student";
                //roomsDataGrid.Rows.Add(row);
            }
        }
        private void roomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowRoomsPanel();
        }
        //


        private void exitToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

    }


}
