using SomerenService;
using SomerenModel;
using System.Windows.Forms;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Globalization;

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
            panelVatCalc.Hide();

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
            panelVatCalc.Hide();

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
            panelVatCalc.Hide();


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
            panelVatCalc.Hide();

            //show all activity
            panelActivity.Show();

            try
            {
                // get and display all activity
                List<Activity> activities = GetActivities();
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
                ListViewItem li = new ListViewItem(teacher.Id.ToString());
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




                listViewlecturer.Items.Add(li);
            }

        }

        private void ShowTeachersPanel()
        {
            // hide all other panels
            pnlDashboard.Hide();
            pnlStudents.Hide();
            panelrooms.Hide();
            panelActivity.Hide();
            panelVatCalc.Hide();

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

        // VAT Calculation - part d start
        private void ShowVatCalculationPanel()
        {
            // hide all other panels
            pnlDashboard.Hide();
            pnlStudents.Hide();
            panelrooms.Hide();
            panelActivity.Hide();
            panellecturer.Hide();

            //show vat calculation
            panelVatCalc.Show();

            VatCalcService vatCalcService = new VatCalcService();


            try
            {
                List<Order> allPurchases = vatCalcService.GetPurchases();


                int[] vatCalcComboBox = allPurchases.DistinctBy(x => x.DateTime.Year).OrderByDescending(x => x.DateTime.Year).Select(x => x.DateTime.Year).ToArray();

                vatCalcSelectYearCombo.DataSource = vatCalcComboBox;
                string[] vatCalcQuarerComboBox = new string[]
                {
                        "Q1", "Q2", "Q3", "Q4"
                };
                vatCalcQuarterCombo.DataSource = vatCalcQuarerComboBox;
                vatCalcQuarterCombo.SelectedIndex = 0;

                if (vatCalcComboBox.Length > 0)
                    vatCalcSelectYearCombo.SelectedIndex = 0;
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the vat calculation: " + e.Message);
            }
        }

        // part D end

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

        // part D start
        private void vatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowVatCalculationPanel();

        }

        private void vatCalcSelectYearCombo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            SetQuarterFromTo();
        }

        private void vatCalcQuarterCombo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            lowTariffVatLabel.Text = "";
            highTariffVatLabel.Text = "";

            SetQuarterFromTo();
            float lowTariff = GetTariffVat(false);
            float highTariff = GetTariffVat(true);

            lowTariffVatLabel.Text = lowTariff.ToString("C2", CultureInfo.CreateSpecificCulture("nl-NL"));
            highTariffVatLabel.Text = highTariff.ToString("C2", CultureInfo.CreateSpecificCulture("nl-NL"));

            totalVatLabel.Text = (lowTariff + highTariff).ToString("C2", CultureInfo.CreateSpecificCulture("nl-NL"));


        }
        private void SetQuarterFromTo()
        {
            DateTime[] dates = GetQuarterFromTo().ToArray();

            if (vatCalcSelectYearCombo.SelectedValue == null || dates.Length == 0)
                return;

            quarterRunsFromLabel.Text = $"{dates[0].ToShortDateString()}";
            quarterRunsToLabel.Text = $"{dates[1].ToShortDateString()}";

        }

        private List<DateTime> GetQuarterFromTo()
        {
            List<DateTime> dates = new List<DateTime>();
            if (vatCalcSelectYearCombo.SelectedValue == null)
                return dates;


            switch (vatCalcQuarterCombo.SelectedValue)
            {
                case "Q1":
                    dates.Add(DateTime.Parse($"01/01/{vatCalcSelectYearCombo.SelectedValue}"));
                    dates.Add(DateTime.Parse($"03/31/{vatCalcSelectYearCombo.SelectedValue}"));
                    break;
                case "Q2":
                    dates.Add(DateTime.Parse($"04/01/{vatCalcSelectYearCombo.SelectedValue}"));
                    dates.Add(DateTime.Parse($"06/30/{vatCalcSelectYearCombo.SelectedValue}"));
                    break;
                case "Q3":
                    dates.Add(DateTime.Parse($"07/01/{vatCalcSelectYearCombo.SelectedValue}"));
                    dates.Add(DateTime.Parse($"09/30/{vatCalcSelectYearCombo.SelectedValue}"));
                    break;
                case "Q4":
                    dates.Add(DateTime.Parse($"10/01/{vatCalcSelectYearCombo.SelectedValue}"));
                    dates.Add(DateTime.Parse($"12/31/{vatCalcSelectYearCombo.SelectedValue}"));
                    break;
            }

            return dates;
        }

        private float GetTariffVat(bool isAlcholic = false)
        {
            VatCalcService vatCalcSerive = new VatCalcService();

            List<Order> allPurchases = vatCalcSerive.GetPurchases();

            DateTime[] dates = GetQuarterFromTo().ToArray();

            string drinkType = isAlcholic ? "Alcoholic" : "Non Alcoholic";
            decimal vat = isAlcholic ? 0.22m : 0.06m;

            if (dates.Length == 0)
                return 0f;
            return (from p in allPurchases
                    where (p.DrinkType == drinkType) && (p.DateTime > dates[0] && p.DateTime < dates[1])
                    select (float)(vat * p.Price)).Sum();
        }

        // part d end
    }
}