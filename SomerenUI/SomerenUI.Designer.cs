namespace SomerenUI
{
    partial class SomerenUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SomerenUI));
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            dashboardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            lecturersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            activitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            roomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            DrinkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            pnlDashboard = new System.Windows.Forms.Panel();
            lblDashboard = new System.Windows.Forms.Label();
            panelrooms = new System.Windows.Forms.Panel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            listViewRooms = new System.Windows.Forms.ListView();
            roomnumber = new System.Windows.Forms.ColumnHeader();
            Roomtype = new System.Windows.Forms.ColumnHeader();
            capacity = new System.Windows.Forms.ColumnHeader();
            buildingtype = new System.Windows.Forms.ColumnHeader();
            label1 = new System.Windows.Forms.Label();
            pnlStudents = new System.Windows.Forms.Panel();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            listViewStudents = new System.Windows.Forms.ListView();
            id = new System.Windows.Forms.ColumnHeader();
            studentnumber = new System.Windows.Forms.ColumnHeader();
            Classname = new System.Windows.Forms.ColumnHeader();
            Firstname = new System.Windows.Forms.ColumnHeader();
            lastname = new System.Windows.Forms.ColumnHeader();
            Phonenumber = new System.Windows.Forms.ColumnHeader();
            roomid = new System.Windows.Forms.ColumnHeader();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            listViewActivity = new System.Windows.Forms.ListView();
            activityid = new System.Windows.Forms.ColumnHeader();
            name = new System.Windows.Forms.ColumnHeader();
            time = new System.Windows.Forms.ColumnHeader();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            panelActivity = new System.Windows.Forms.Panel();
            panellecturer = new System.Windows.Forms.Panel();
            pictureBox4 = new System.Windows.Forms.PictureBox();
            listViewlecturer = new System.Windows.Forms.ListView();
            lecuterid = new System.Windows.Forms.ColumnHeader();
            namefirst = new System.Windows.Forms.ColumnHeader();
            namelast = new System.Windows.Forms.ColumnHeader();
            numberphone = new System.Windows.Forms.ColumnHeader();
            age = new System.Windows.Forms.ColumnHeader();
            idofroom = new System.Windows.Forms.ColumnHeader();
            issupervison = new System.Windows.Forms.ColumnHeader();
            label4 = new System.Windows.Forms.Label();
            paneldrinks = new System.Windows.Forms.Panel();
            pictureBox5 = new System.Windows.Forms.PictureBox();
            listViewdrinks = new System.Windows.Forms.ListView();
            DrinkId = new System.Windows.Forms.ColumnHeader();
            drinkname = new System.Windows.Forms.ColumnHeader();
            type = new System.Windows.Forms.ColumnHeader();
            price = new System.Windows.Forms.ColumnHeader();
            stock = new System.Windows.Forms.ColumnHeader();
            label5 = new System.Windows.Forms.Label();
            menuStrip1.SuspendLayout();
            pnlDashboard.SuspendLayout();
            panelrooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panelActivity.SuspendLayout();
            panellecturer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            paneldrinks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { dashboardToolStripMenuItem, studentsToolStripMenuItem, lecturersToolStripMenuItem, activitiesToolStripMenuItem, roomsToolStripMenuItem, DrinkToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            menuStrip1.Size = new System.Drawing.Size(1112, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            dashboardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { dashboardToolStripMenuItem1, exitToolStripMenuItem });
            dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            dashboardToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            dashboardToolStripMenuItem.Text = "Application";
            // 
            // dashboardToolStripMenuItem1
            // 
            dashboardToolStripMenuItem1.Name = "dashboardToolStripMenuItem1";
            dashboardToolStripMenuItem1.Size = new System.Drawing.Size(165, 26);
            dashboardToolStripMenuItem1.Text = "Dashboard";
            dashboardToolStripMenuItem1.Click += dashboardToolStripMenuItem1_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // studentsToolStripMenuItem
            // 
            studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            studentsToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            studentsToolStripMenuItem.Text = "Students";
            studentsToolStripMenuItem.Click += studentsToolStripMenuItem_Click;
            // 
            // lecturersToolStripMenuItem
            // 
            lecturersToolStripMenuItem.Name = "lecturersToolStripMenuItem";
            lecturersToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            lecturersToolStripMenuItem.Text = "Lecturers";
            lecturersToolStripMenuItem.Click += lecturersToolStripMenuItem_Click;
            // 
            // activitiesToolStripMenuItem
            // 
            activitiesToolStripMenuItem.Name = "activitiesToolStripMenuItem";
            activitiesToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            activitiesToolStripMenuItem.Text = "Activities";
            activitiesToolStripMenuItem.Click += activitiesToolStripMenuItem_Click;
            // 
            // roomsToolStripMenuItem
            // 
            roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            roomsToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            roomsToolStripMenuItem.Text = "Rooms";
            roomsToolStripMenuItem.Click += roomsToolStripMenuItem_Click_1;
            // 
            // DrinkToolStripMenuItem
            // 
            DrinkToolStripMenuItem.Name = "DrinkToolStripMenuItem";
            DrinkToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            DrinkToolStripMenuItem.Text = "Drinks";
            DrinkToolStripMenuItem.Click += DrinkToolStripMenuItem_Click;
            // 
            // pnlDashboard
            // 
            pnlDashboard.Controls.Add(lblDashboard);
            pnlDashboard.Location = new System.Drawing.Point(14, 32);
            pnlDashboard.Margin = new System.Windows.Forms.Padding(4);
            pnlDashboard.Name = "pnlDashboard";
            pnlDashboard.Size = new System.Drawing.Size(1072, 621);
            pnlDashboard.TabIndex = 1;
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Location = new System.Drawing.Point(15, 18);
            lblDashboard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new System.Drawing.Size(262, 20);
            lblDashboard.TabIndex = 0;
            lblDashboard.Text = "Welcome to the Someren Application!";
            // 
            // panelrooms
            // 
            panelrooms.Controls.Add(pictureBox1);
            panelrooms.Controls.Add(listViewRooms);
            panelrooms.Controls.Add(label1);
            panelrooms.Location = new System.Drawing.Point(14, 32);
            panelrooms.Margin = new System.Windows.Forms.Padding(4);
            panelrooms.Name = "panelrooms";
            panelrooms.Size = new System.Drawing.Size(1072, 621);
            panelrooms.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(920, 0);
            pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(148, 164);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // listViewRooms
            // 
            listViewRooms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { roomnumber, Roomtype, capacity, buildingtype });
            listViewRooms.Location = new System.Drawing.Point(18, 56);
            listViewRooms.Margin = new System.Windows.Forms.Padding(4);
            listViewRooms.Name = "listViewRooms";
            listViewRooms.Size = new System.Drawing.Size(875, 408);
            listViewRooms.TabIndex = 1;
            listViewRooms.UseCompatibleStateImageBehavior = false;
            listViewRooms.View = System.Windows.Forms.View.Details;
            // 
            // roomnumber
            // 
            roomnumber.Text = "Room Number";
            roomnumber.Width = 100;
            // 
            // Roomtype
            // 
            Roomtype.Text = "Room Type";
            Roomtype.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            Roomtype.Width = 200;
            // 
            // capacity
            // 
            capacity.Text = "Capacity";
            capacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            capacity.Width = 200;
            // 
            // buildingtype
            // 
            buildingtype.Text = "Building Type";
            buildingtype.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            buildingtype.Width = 200;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(15, 9);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(110, 41);
            label1.TabIndex = 0;
            label1.Text = "Rooms";
            // 
            // pnlStudents
            // 
            pnlStudents.Controls.Add(pictureBox2);
            pnlStudents.Controls.Add(listViewStudents);
            pnlStudents.Controls.Add(label2);
            pnlStudents.Location = new System.Drawing.Point(14, 32);
            pnlStudents.Margin = new System.Windows.Forms.Padding(4);
            pnlStudents.Name = "pnlStudents";
            pnlStudents.Size = new System.Drawing.Size(1072, 621);
            pnlStudents.TabIndex = 7;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(920, 0);
            pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(148, 164);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // listViewStudents
            // 
            listViewStudents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { id, studentnumber, Classname, Firstname, lastname, Phonenumber, roomid });
            listViewStudents.Location = new System.Drawing.Point(18, 56);
            listViewStudents.Margin = new System.Windows.Forms.Padding(4);
            listViewStudents.Name = "listViewStudents";
            listViewStudents.Size = new System.Drawing.Size(875, 408);
            listViewStudents.TabIndex = 1;
            listViewStudents.UseCompatibleStateImageBehavior = false;
            listViewStudents.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            id.Text = "Student Id";
            id.Width = 150;
            // 
            // studentnumber
            // 
            studentnumber.Text = "Student Number";
            studentnumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            studentnumber.Width = 200;
            // 
            // Classname
            // 
            Classname.Text = "Class Name";
            Classname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            Classname.Width = 200;
            // 
            // Firstname
            // 
            Firstname.Text = "First Name";
            Firstname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            Firstname.Width = 200;
            // 
            // lastname
            // 
            lastname.Text = "Last Name";
            lastname.Width = 200;
            // 
            // Phonenumber
            // 
            Phonenumber.Text = "Phone Number";
            Phonenumber.Width = 200;
            // 
            // roomid
            // 
            roomid.Text = "Room Id";
            roomid.Width = 150;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(15, 9);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(134, 41);
            label2.TabIndex = 0;
            label2.Text = "Students";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(15, 9);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(114, 41);
            label3.TabIndex = 0;
            label3.Text = "Activity";
            // 
            // listViewActivity
            // 
            listViewActivity.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { activityid, name, time });
            listViewActivity.Location = new System.Drawing.Point(18, 56);
            listViewActivity.Margin = new System.Windows.Forms.Padding(4);
            listViewActivity.Name = "listViewActivity";
            listViewActivity.Size = new System.Drawing.Size(875, 408);
            listViewActivity.TabIndex = 1;
            listViewActivity.UseCompatibleStateImageBehavior = false;
            listViewActivity.View = System.Windows.Forms.View.Details;
            // 
            // activityid
            // 
            activityid.Text = "Activity Id";
            activityid.Width = 200;
            // 
            // name
            // 
            name.Text = "Activity Name";
            name.Width = 200;
            // 
            // time
            // 
            time.Text = "Activity Time";
            time.Width = 200;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (System.Drawing.Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new System.Drawing.Point(920, 0);
            pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(148, 164);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // panelActivity
            // 
            panelActivity.Controls.Add(pictureBox3);
            panelActivity.Controls.Add(listViewActivity);
            panelActivity.Controls.Add(label3);
            panelActivity.Location = new System.Drawing.Point(14, 32);
            panelActivity.Margin = new System.Windows.Forms.Padding(4);
            panelActivity.Name = "panelActivity";
            panelActivity.Size = new System.Drawing.Size(1072, 621);
            panelActivity.TabIndex = 9;
            // 
            // panellecturer
            // 
            panellecturer.Controls.Add(pictureBox4);
            panellecturer.Controls.Add(listViewlecturer);
            panellecturer.Controls.Add(label4);
            panellecturer.Location = new System.Drawing.Point(14, 32);
            panellecturer.Margin = new System.Windows.Forms.Padding(4);
            panellecturer.Name = "panellecturer";
            panellecturer.Size = new System.Drawing.Size(1072, 621);
            panellecturer.TabIndex = 8;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (System.Drawing.Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new System.Drawing.Point(920, 0);
            pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new System.Drawing.Size(148, 164);
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // listViewlecturer
            // 
            listViewlecturer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { lecuterid, namefirst, namelast, numberphone, age, idofroom, issupervison });
            listViewlecturer.Location = new System.Drawing.Point(18, 56);
            listViewlecturer.Margin = new System.Windows.Forms.Padding(4);
            listViewlecturer.Name = "listViewlecturer";
            listViewlecturer.Size = new System.Drawing.Size(875, 408);
            listViewlecturer.TabIndex = 1;
            listViewlecturer.UseCompatibleStateImageBehavior = false;
            listViewlecturer.View = System.Windows.Forms.View.Details;
            // 
            // lecuterid
            // 
            lecuterid.Text = "Lecturer Id";
            lecuterid.Width = 150;
            // 
            // namefirst
            // 
            namefirst.Text = "First Name";
            namefirst.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            namefirst.Width = 200;
            // 
            // namelast
            // 
            namelast.Text = "Last Name";
            namelast.Width = 200;
            // 
            // numberphone
            // 
            numberphone.Text = "Phone Number";
            numberphone.Width = 200;
            // 
            // age
            // 
            age.Text = "Age";
            age.Width = 100;
            // 
            // idofroom
            // 
            idofroom.Text = "Room Id";
            idofroom.Width = 150;
            // 
            // issupervison
            // 
            issupervison.Text = "Is Supervisor";
            issupervison.Width = 200;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(15, 9);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(125, 41);
            label4.TabIndex = 0;
            label4.Text = "Lecturer";
            // 
            // paneldrinks
            // 
            paneldrinks.Controls.Add(pictureBox5);
            paneldrinks.Controls.Add(listViewdrinks);
            paneldrinks.Controls.Add(label5);
            paneldrinks.Location = new System.Drawing.Point(14, 32);
            paneldrinks.Margin = new System.Windows.Forms.Padding(4);
            paneldrinks.Name = "paneldrinks";
            paneldrinks.Size = new System.Drawing.Size(1072, 621);
            paneldrinks.TabIndex = 10;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (System.Drawing.Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new System.Drawing.Point(920, 0);
            pictureBox5.Margin = new System.Windows.Forms.Padding(4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new System.Drawing.Size(148, 164);
            pictureBox5.TabIndex = 2;
            pictureBox5.TabStop = false;
            // 
            // listViewdrinks
            // 
            listViewdrinks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { DrinkId, drinkname, type, price, stock });
            listViewdrinks.Location = new System.Drawing.Point(18, 56);
            listViewdrinks.Margin = new System.Windows.Forms.Padding(4);
            listViewdrinks.Name = "listViewdrinks";
            listViewdrinks.Size = new System.Drawing.Size(875, 408);
            listViewdrinks.TabIndex = 1;
            listViewdrinks.UseCompatibleStateImageBehavior = false;
            listViewdrinks.View = System.Windows.Forms.View.Details;
            // 
            // DrinkId
            // 
            DrinkId.Text = "Drink Id";
            DrinkId.Width = 80;
            // 
            // drinkname
            // 
            drinkname.Text = "Drink Name";
            drinkname.Width = 100;
            // 
            // type
            // 
            type.Text = "Drink Type";
            type.Width = 150;
            // 
            // price
            // 
            price.Text = "Price";
            price.Width = 80;
            // 
            // stock
            // 
            stock.Text = "Stock";
            stock.Width = 140;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(15, 9);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(221, 41);
            label5.TabIndex = 0;
            label5.Text = "Drinks Supplies";
            // 
            // SomerenUI
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1112, 659);
            Controls.Add(menuStrip1);
            Controls.Add(paneldrinks);
            Controls.Add(panelActivity);
            Controls.Add(panellecturer);
            Controls.Add(pnlStudents);
            Controls.Add(panelrooms);
            Controls.Add(pnlDashboard);
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(4);
            Name = "SomerenUI";
            Text = "SomerenApp";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pnlDashboard.ResumeLayout(false);
            pnlDashboard.PerformLayout();
            panelrooms.ResumeLayout(false);
            panelrooms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlStudents.ResumeLayout(false);
            pnlStudents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panelActivity.ResumeLayout(false);
            panelActivity.PerformLayout();
            panellecturer.ResumeLayout(false);
            panellecturer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            paneldrinks.ResumeLayout(false);
            paneldrinks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lecturersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomsToolStripMenuItem;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Panel panelrooms;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listViewRooms;
        private System.Windows.Forms.ColumnHeader roomnumber;
        private System.Windows.Forms.ColumnHeader Roomtype;
        private System.Windows.Forms.ColumnHeader capacity;
        private System.Windows.Forms.ColumnHeader buildingtype;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlStudents;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ListView listViewStudents;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader studentnumber;
        private System.Windows.Forms.ColumnHeader Classname;
        private System.Windows.Forms.ColumnHeader Firstname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader lastname;
        private System.Windows.Forms.ColumnHeader Phonenumber;
        private System.Windows.Forms.ColumnHeader roomid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listViewActivity;
        private System.Windows.Forms.ColumnHeader activityid;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader time;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panelActivity;
        private System.Windows.Forms.Panel panellecturer;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ListView listViewlecturer;
        private System.Windows.Forms.ColumnHeader lecuterid;
        private System.Windows.Forms.ColumnHeader namefirst;
        private System.Windows.Forms.ColumnHeader namelast;
        private System.Windows.Forms.ColumnHeader numberphone;
        private System.Windows.Forms.ColumnHeader idofroom;
        private System.Windows.Forms.ColumnHeader issupervison;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader age;
        private System.Windows.Forms.ToolStripMenuItem DrinkToolStripMenuItem;
        private System.Windows.Forms.Panel paneldrinks;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.ListView listViewdrinks;
        private System.Windows.Forms.ColumnHeader DrinkId;
        private System.Windows.Forms.ColumnHeader drinkname;
        private System.Windows.Forms.ColumnHeader type;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.ColumnHeader stock;
        private System.Windows.Forms.Label label5;
    }
}