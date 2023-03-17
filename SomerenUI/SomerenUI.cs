using SomerenService;
using SomerenModel;
using System.Windows.Forms;
using System.Collections.Generic;
using System;

namespace SomerenUI
{
    public partial class SomerenUI : Form
    {
        public SomerenUI()
        {
            InitializeComponent();

            ShowDashboardPanel(); //opens dashboard panel when you log in
        }

        private void ShowDashboardPanel()
        {
            // hide all other panels
           pnlStudents.Hide();
            panelrooms.Hide();
            panelActivity.Hide();
            panellecturer.Hide();

            // show dashboard
            pnlDashboard.Show();
        }
        //students part

        private void ShowStudentsPanel()
        {
            // hide all other panels
            pnlDashboard.Hide();
            panelrooms.Hide();
            panelActivity.Hide();
            panellecturer.Hide();

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
            listViewStudents.Items.Clear();

            foreach (Student student in students)
            {
                ListViewItem li = new ListViewItem(student.id.ToString());
                li.Tag = student;   // link student object to listview item

                li.SubItems.Add(student.number.ToString());
                li.SubItems.Add(student.className.ToString());
                li.SubItems.Add(student.First_name.ToString());
                li.SubItems.Add(student.Last_name.ToString());
                li.SubItems.Add(student.Phone_number.ToString());
                li.SubItems.Add(student.room.ToString());

               listViewStudents.Items.Add(li);
            }
        }


        //rooms part
        private List<Room> GetRooms()
        {
            RoomService roomService = new RoomService();
            List<Room> Room = roomService.GetRoom();
            return Room;
        }
        private void ShowRoomsPanel()
        {
            // hide all other panels
            pnlDashboard.Hide();
            panelActivity.Hide();
            panellecturer.Hide();
            pnlStudents.Hide();

            
            // show all rooms
            panelrooms.Show();

            try
            {
                // get and display all rooms
                List<Room> rooms = GetRooms();
                DisplayRooms(rooms);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the rooms: " + e.Message);
            }
        }

        private void DisplayRooms(List<Room> rooms)
        {
            // clear the listview before filling it
            listViewRooms.Items.Clear();

            foreach (Room room in rooms)
            {
                ListViewItem li = new ListViewItem(room.Number.ToString());
                li.Tag = room;   // link student object to listview item

                if (room.RoomType == true)
                {
                    li.SubItems.Add("Single (Lecturers)");
                }
                else
                {
                    li.SubItems.Add("Dormitory (Students)");
                }
                if (room.RoomType == true)
                {
                    li.SubItems.Add("1");
                }
                else
                {
                    li.SubItems.Add("8");
                }
                li.SubItems.Add(room.BuildingType.ToString());




                listViewRooms.Items.Add(li);
            }
        }


        //activity part

        private List<Activity> GetActivities()
        {
            ActivityService activityService = new ActivityService();
            List<Activity> activities = activityService.GetActivities();
            return activities;
        }

        private void ShowActivityPanel()
        {
            // hide all other panels
            pnlDashboard.Hide();
            pnlStudents.Hide();
            panelrooms.Hide();
            panellecturer.Hide();

            //show all activity
            panelActivity.Show();

            try
            {
                // get and display all activity
                List <Activity> activities = GetActivities();
                DisplayActivities(activities);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the activities: " + e.Message);
            }
        }



        private void DisplayActivities(List<Activity> activities)
        {
            // clear the listview before filling it
            listViewActivity.Items.Clear();

            foreach (Activity activity in activities)
            {
                ListViewItem li = new ListViewItem(activity.activityID.ToString());
                li.Tag = activity;   // link student object to listview item

                li.SubItems.Add(activity.activityName.ToString());
                li.SubItems.Add(activity.activityTime.ToString());

                listViewActivity.Items.Add(li);
            }
        }


        //teachers part

        private List<Teacher> GetTeachers()
        {
            TeacherService teachersService = new TeacherService();
            List<Teacher> teachers = teachersService.GetTeachers();
            return teachers;
        }

        private void DisplayTeachers(List<Teacher> teachers)
        {
            // clear the listview before filling it
            listViewlecturer.Items.Clear();

            foreach (Teacher teacher in teachers)
            {
                ListViewItem li = new ListViewItem(teacher.Id.ToString ());
                li.Tag = teacher;   // link student object to listview item
                li.SubItems.Add(teacher.FirstName.ToString());
                li.SubItems.Add(teacher.LastName.ToString());
                li.SubItems.Add(teacher.PhoneNumber.ToString());
                li.SubItems.Add(teacher.Age.ToString());
                li.SubItems.Add(teacher.RoomId.ToString());

                if (teacher.IsSupervisor == true)
                {
                    li.SubItems.Add("Yes");
                }
                else
                {
                    li.SubItems.Add("No");
                }

                
               

                listViewActivity.Items.Add(li);
            }

        }

        private void ShowTeachersPanel()
        {
            // hide all other panels
            pnlDashboard.Hide();
            pnlStudents.Hide();
            panelrooms.Hide();
            panelActivity.Hide();

            //show all activity
            panellecturer.Show();

            try
            {
                // get and display all teacher
                List<Teacher> teachers = GetTeachers();
                DisplayTeachers(teachers);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the teachers: " + e.Message);
            }
        }

        private void dashboardToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            ShowDashboardPanel();
        }

        private void exitToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowStudentsPanel(); //show student panel
        }
        

        private void roomsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ShowRoomsPanel();  //shows room panel when room button is clicked from menu

        }

        private void activitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowActivityPanel();  //shows activity panel on pressing room
        }

        private void lecturersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowTeachersPanel();
        }
    }
}