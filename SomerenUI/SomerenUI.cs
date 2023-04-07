using SomerenService;
using SomerenModel;
using System.Windows.Forms;
using System.Collections.Generic;
using System;
using System.Diagnostics;
using Activity = SomerenModel.Activity;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SomerenUI
{
    public partial class SomerenUI : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SomerenDatabase"].ConnectionString);
        public SomerenUI()
        {
            InitializeComponent();

            ShowDashboardPanel(); //opens dashboard panel when you log in

            Deletebutton.Enabled = false;
        }

        private void ShowDashboardPanel()
        {
            // hide all other panels
            pnlStudents.Hide();
            panelrooms.Hide();
            panelActivity.Hide();
            panellecturer.Hide();
            panelcashregister.Hide();
            // paneldrinks.Hide();
            pnlActivityParticipants.Hide();

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
            panelcashregister.Hide();
            pnlActivityParticipants.Hide();

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
            panelcashregister.Hide();
            pnlActivityParticipants.Hide();

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
            panelcashregister.Hide();
            pnlActivityParticipants.Hide();

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
                li.SubItems.Add(activity.startTime.ToString());
                li.SubItems.Add(activity.endTime.ToString());

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
            panelcashregister.Hide();
            pnlActivityParticipants.Hide();

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

        //Drinks part

        private List<Drinks> GetDrinks()
        {
            DrinkService drinkService = new DrinkService();
            List<Drinks> drinks = drinkService.GetDrinks();
            return drinks;
        }
        private void ShowDrinkPanel()
        {
            // hide all other panels
            pnlDashboard.Hide();
            panelActivity.Hide();
            panellecturer.Hide();
            pnlStudents.Hide();
            panelrooms.Hide();
            pnlActivityParticipants.Hide();


            // show all rooms
            //paneldrinks.Show();

            try
            {
                // get and display all rooms
                List<Drinks> drinks = GetDrinks();
                DisplayDrinks(drinks);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the drinks: " + e.Message);
            }
        }

        private void DisplayDrinks(List<Drinks> drinks)
        {
            //clear the listview before filling it
            //listViewdrinks.Items.Clear();

            foreach (Drinks drink in drinks)
            {
                ListViewItem li = new ListViewItem(drink.drinkID.ToString());
                li.Tag = drink;   // link student object to listview item


                li.SubItems.Add(drink.drinkName.ToString());
                li.SubItems.Add(drink.drinkType.ToString());
                li.SubItems.Add(drink.drinkPrice.ToString());
                li.SubItems.Add(drink.drinkStock.ToString());

                if (drink.drinkStock < 10)
                {
                    li.SubItems.Add("'Stock nearly depleted");
                }
                else
                {
                    li.SubItems.Add("Stock sufficient");
                }




                //listViewdrinks.Items.Add(li);
            }
        }

        //cash regiter part dawood
        private void DisplayCashRegisterPanel(List<Student> students, List<Drinks> drinks)
        {
            listViewstudentnames.Items.Clear();

            foreach (Student student in students)
            {
                ListViewItem li = new ListViewItem(student.id.ToString());
                li.Tag = student;   // link student object to listview item

                li.SubItems.Add(student.First_name.ToString());
                li.SubItems.Add(student.Last_name.ToString());


                listViewstudentnames.Items.Add(li);
            }

            listViewdrinks.Items.Clear();

            foreach (Drinks drink in drinks)
            {
                ListViewItem list = new ListViewItem(drink.drinkID.ToString());
                list.Tag = drink;
                list.SubItems.Add(drink.drinkName.ToString());
                list.SubItems.Add(drink.drinkType.ToString());
                list.SubItems.Add(drink.drinkPrice.ToString());
                list.SubItems.Add(drink.drinkStock.ToString());

                listViewdrinks.Items.Add(list);
            }

        }

        private void ShowCashRegisterPanel()
        {
            // hide all other panels
            pnlDashboard.Hide();
            panelActivity.Hide();
            panellecturer.Hide();
            pnlStudents.Hide();
            panelrooms.Hide();
            pnlActivityParticipants.Hide();



            // paneldrinks.Show();
            panelcashregister.Show();

            try
            {
                // get and display students
                List<Student> students = GetStudents();
                List<Drinks> drinks = GetDrinks();
                DisplayCashRegisterPanel(students, drinks);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the cash register: " + e.Message);
            }
        }

        private void Enablecheckoutbutton()
        {

            if (listViewdrinks.SelectedItems.Count > 0 && listViewstudentnames.SelectedItems.Count > 0)
            {

                int price = int.Parse(listViewdrinks.SelectedItems[0].SubItems[3].Text);
                labelshow.Text = price.ToString();
                checkoutbutton.Enabled = true;

            }
            else
            {
                labelshow.Text = "0.00";
                checkoutbutton.Enabled = false;
            }
        }
        private void UnselectListviewItems(System.Windows.Forms.ListView listView)
        {
            if (listView.SelectedIndices.Count > 0)
                for (int i = 0; i < listView.SelectedIndices.Count; i++)
                {
                    listView.Items[listView.SelectedIndices[i]].Selected = false;
                }
        }
        private void checkoutbutton_Click_1(object sender, EventArgs e)
        {


            int studentId = int.Parse(listViewstudentnames.SelectedItems[0].SubItems[0].Text);
            int drinkId = int.Parse(listViewdrinks.SelectedItems[0].SubItems[0].Text);

            Order order = new Order();
            order.StudentId = studentId;
            order.DrinkId = drinkId;



            try
            {
                OrderService orderService = new OrderService();
                orderService.OrderDrink(order);
                MessageBox.Show("Checkout completed!!");
                UnselectListviewItems(listViewdrinks);
                UnselectListviewItems(listViewstudentnames);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong while checkout: " + ex.Message);
            }
        }




        //Dawood part A List of Activities

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            //parsing the selected row to int
            string activityId = (listViewActivity.SelectedItems[0].SubItems[0].Text);

            //creating new object of class 
            Activity activity = new Activity();
            //assigning the object to the property activity id
            activity.activityID = activityId;

            //deleting the activity using try catch
            try
            {
                //creatinga an object of activity service
                ActivityService activityService = new ActivityService();
                //asking for permission to delete
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this Activity?", "Confirmation", MessageBoxButtons.YesNo);

                //deleting the activity if user agrees
                if (dialogResult == DialogResult.Yes)
                {
                    //calling the delete method
                    activityService.RemoveActivity(activity);
                    //showing the success message 
                    MessageBox.Show("The Activity has been deleted successfully", "Success");
                }

                // cancelling the deletion after user's denial
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Activity was not deleted", "Failed");
                }
            }
            //using catch to throw new exception if the program has an error
            catch (Exception ex)
            {
                //showing the error message in message box
                MessageBox.Show("Something went wrong while deleting the Activity \n" + ex.Message, "Error!");
            }
            //showing the new list
            ShowActivityPanel();
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            //updating the activity using try catch 
            try
            {
                //checking if the number of selected item is greater than 0
                if (listViewActivity.SelectedItems.Count > 0)
                {

                    Activity activity = (Activity)listViewActivity.SelectedItems[0].Tag;

                    //assigning the data entered to the textbox and datetimepicker to properties in class activity
                    activity.activityName = activityNametextBox.Text;
                    activity.startTime = DateTime.Parse(startDateTimePicker.Text);
                    activity.endTime = DateTime.Parse(EndDateTimePicker.Text);
                    //creating an object of service class
                    ActivityService activityService = new ActivityService();
                    //calling the update method
                    activityService.UpdateActivity(activity);
                    //showing the success message 
                    MessageBox.Show("Activity updating successfull", "Success");
                }
                else
                {
                    //showing the failure message in message box
                    MessageBox.Show("Could not update activity because of an error", "Failure!");
                    return;
                }
            }
            //using catch to throw new exception if the program has an error
            catch (Exception ex)
            {
                //showing the error message in message box
                MessageBox.Show("Something went wrong while updating the activity! \n" + ex.Message, "Error!");
            }
            //showing the new list
            ShowActivityPanel();
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            //adding the activity using try catch 
            try
            {
                //creating an object of activity class
                Activity activity = new Activity();

                //assigning the instances of objects to the input added in the textbox and date time picker
                activity.activityName = activityNametextBox.Text;
                activity.startTime = DateTime.Parse(startDateTimePicker.Text);
                activity.endTime = DateTime.Parse(EndDateTimePicker.Text);

                //creating an object of activityservice class
                ActivityService activityService = new ActivityService();
                //adding the activity by calling the method 
                activityService.AddActivity(activity);
                //showing the success message 
                MessageBox.Show($"Activity: {activityNametextBox.Text} added successfuly", "Success");
            }
            //using catch to throw new exception if the program has an error
            catch (Exception ex)
            {
                //showing the error message in message box
                MessageBox.Show("Something went wrong while adding the activity! \n" + ex.Message, "Error");
            }
            //showing the new list
            ShowActivityPanel();
        }

        private void listViewActivity_SelectedIndexChanged(object sender, EventArgs e)
        {
            //enable button if the more than zero rows are selected
            Deletebutton.Enabled = listViewActivity.SelectedItems.Count >= 0;
            //check if any row has been selected
            if (listViewActivity.SelectedItems.Count > 0)
            {

                Activity activity = (Activity)listViewActivity.SelectedItems[0].Tag;
                //assigning values added as input to properties through instance of object
                activityIdtextBox.Text = activity.activityID.ToString();
                activityNametextBox.Text = activity.activityName.ToString();
                startDateTimePicker.Text = activity.startTime.ToString();
                EndDateTimePicker.Text = activity.endTime.ToString();
            }
            else
            {
                return;
            }
        }
        //end part a lis activities


        private void Refreshbutton_Click(object sender, EventArgs e)
        {
            //refresh the list of activities
            ShowActivityPanel();

            //clear the input from id and name text box
            activityIdtextBox.Clear();
            activityNametextBox.Clear();

            //reset the datetime pickers to current date time
            startDateTimePicker.ResetText();
            EndDateTimePicker.ResetText();
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

        private void DrinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowDrinkPanel();
        }

        private void cashRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowCashRegisterPanel();
        }

        private void listViewdrinks_SelectedIndexChanged(object sender, EventArgs e)
        {
            Enablecheckoutbutton();
        }

        private void listViewstudentnames_SelectedIndexChanged(object sender, EventArgs e)
        {
            Enablecheckoutbutton();
        }

        private void activityParticipantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showGridData();
        }

        //participants part
        private void btnadd_Click(object sender, EventArgs e)
        {
            SqlCommand cmd2 = new SqlCommand("Insert into Participant (ParticipantsName) Values (@ParticipantsName)", conn);
            cmd2.Parameters.AddWithValue("ParticipantsName", txtbxinput.Text);
            conn.Open();
            cmd2.ExecuteNonQuery();
            conn.Close();
            showGridData();
        }

        public void showGridData()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT  [ParticipantID],[NonParticipantName],[ParticipantsName],[activity_name] FROM [dbo].[Participant] left join [Activity] on [Participant].[ActivityID] = [Activity].activity_id", "server = grasshoppersdatabase4.database.windows.net; database = GrassHoppersDataBase; UID = GrasshopperGroup; password = IFKRGroup5project3");
            DataSet ds = new DataSet();
            da.Fill(ds, "Participant");
            dataGridView1.DataSource = ds.Tables["Participant"].DefaultView;

            // hide all other panels
            pnlDashboard.Hide();
            pnlStudents.Hide();
            panelrooms.Hide();
            panelActivity.Hide();
            panelcashregister.Hide();
            panellecturer.Hide();

            pnlActivityParticipants.Show();
        }

        private void btnrmv_Click(object sender, EventArgs e)
        {
            SqlCommand cmd2 = new SqlCommand("delete from Participant where ParticipantsName=@ParticipantsName", conn);
            cmd2.Parameters.AddWithValue("ParticipantsName", txtbxinput.Text);
            conn.Open();
            cmd2.ExecuteNonQuery();
            conn.Close();
            showGridData();
        }
    }
}