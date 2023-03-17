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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SomerenUI));

            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lecturersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.pnlStudents = new System.Windows.Forms.Panel();
            this.panelrooms = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.listViewRooms = new System.Windows.Forms.ListView();
            this.roomNumber = new System.Windows.Forms.ColumnHeader();
            this.room_type = new System.Windows.Forms.ColumnHeader();
            this.Capacity = new System.Windows.Forms.ColumnHeader();
            this.buildingtype = new System.Windows.Forms.ColumnHeader();
            this.labelrooms = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listViewStudents = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.pnlDashboard.SuspendLayout();
            this.pnlStudents.SuspendLayout();
            this.panelrooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.studentsToolStripMenuItem,
            this.lecturersToolStripMenuItem,
            this.activitiesToolStripMenuItem,
            this.roomsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(778, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";

            // 
            // dashboardToolStripMenuItem
            // 
            dashboardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { dashboardToolStripMenuItem1, exitToolStripMenuItem });
            dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            dashboardToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            dashboardToolStripMenuItem.Text = "Application";
            // 
            // dashboardToolStripMenuItem1
            // 


            this.dashboardToolStripMenuItem1.Name = "dashboardToolStripMenuItem1";
            this.dashboardToolStripMenuItem1.Size = new System.Drawing.Size(131, 22);
            this.dashboardToolStripMenuItem1.Text = "Dashboard";
            this.dashboardToolStripMenuItem1.Click += new System.EventHandler(this.dashboardToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);

            // 
            // studentsToolStripMenuItem
            // 
            studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            studentsToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            studentsToolStripMenuItem.Text = "Students";
            studentsToolStripMenuItem.Click += studentsToolStripMenuItem_Click;
            // 
            // lecturersToolStripMenuItem
            // 
            lecturersToolStripMenuItem.Name = "lecturersToolStripMenuItem";
            lecturersToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            lecturersToolStripMenuItem.Text = "Lecturers";
            lecturersToolStripMenuItem.Click += lecturersToolStripMenuItem_Click;
            // 
            // activitiesToolStripMenuItem
            // 
            activitiesToolStripMenuItem.Name = "activitiesToolStripMenuItem";
            activitiesToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            activitiesToolStripMenuItem.Text = "Activities";
            // 
            // roomsToolStripMenuItem
            // 

            this.roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            this.roomsToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.roomsToolStripMenuItem.Text = "Rooms";
            this.roomsToolStripMenuItem.Click += new System.EventHandler(this.roomsToolStripMenuItem_Click_1);

            // 
            // pnlDashboard
            // 
            pnlDashboard.Controls.Add(lblDashboard);
            pnlDashboard.Location = new System.Drawing.Point(12, 27);
            pnlDashboard.Name = "pnlDashboard";
            pnlDashboard.Size = new System.Drawing.Size(938, 466);
            pnlDashboard.TabIndex = 1;
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Location = new System.Drawing.Point(13, 13);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new System.Drawing.Size(208, 15);
            lblDashboard.TabIndex = 0;
            lblDashboard.Text = "Welcome to the Someren Application!";
            // 
            // pnlStudents
            // 
            pnlStudents.Controls.Add(studentsDataGrid);
            pnlStudents.Controls.Add(listViewStudents);
            pnlStudents.Controls.Add(pictureBox1);
            pnlStudents.Controls.Add(label1);
            pnlStudents.Location = new System.Drawing.Point(12, 27);
            pnlStudents.Name = "pnlStudents";
            pnlStudents.Size = new System.Drawing.Size(938, 466);
            pnlStudents.TabIndex = 2;
            // 

            // panelrooms
            // 
            this.panelrooms.Controls.Add(this.pictureBox2);
            this.panelrooms.Controls.Add(this.listViewRooms);
            this.panelrooms.Controls.Add(this.labelrooms);
            this.panelrooms.Location = new System.Drawing.Point(12, 27);
            this.panelrooms.Name = "panelrooms";
            this.panelrooms.Size = new System.Drawing.Size(938, 466);
            this.panelrooms.TabIndex = 3;

            // 
            // pictureBox2
            // 


            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(805, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(130, 123);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // listViewRooms
            // 
            this.listViewRooms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.roomNumber,
            this.room_type,
            this.Capacity,
            this.buildingtype});
            this.listViewRooms.Location = new System.Drawing.Point(16, 42);
            this.listViewRooms.Name = "listViewRooms";
            this.listViewRooms.Size = new System.Drawing.Size(766, 307);
            this.listViewRooms.TabIndex = 1;
            this.listViewRooms.UseCompatibleStateImageBehavior = false;
            this.listViewRooms.View = System.Windows.Forms.View.Details;
            // 
            // roomNumber
            // 
            this.roomNumber.Text = "Room Number";
            this.roomNumber.Width = 200;
            // 
            // room_type
            // 
            this.room_type.Text = "Room Type";
            this.room_type.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.room_type.Width = 200;
            // 
            // Capacity
            // 
            this.Capacity.Text = "Capacity";
            this.Capacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Capacity.Width = 200;
            // 
            // buildingtype
            // 
            this.buildingtype.Text = "Building Type";
            this.buildingtype.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.buildingtype.Width = 200;
            // 
            // labelrooms
            // 
            this.labelrooms.AutoSize = true;
            this.labelrooms.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelrooms.Location = new System.Drawing.Point(13, 7);
            this.labelrooms.Name = "labelrooms";
            this.labelrooms.Size = new System.Drawing.Size(86, 32);
            this.labelrooms.TabIndex = 0;
            this.labelrooms.Text = "Rooms";

            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(805, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(130, 123);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(13, 7);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(107, 32);
            label1.TabIndex = 0;
            label1.Text = "Students";
            // 
            // pnlLecture
            // 
            pnlLecture.Controls.Add(lectureListView);
            pnlLecture.Controls.Add(pictureBox2);
            pnlLecture.Controls.Add(label2);
            pnlLecture.Location = new System.Drawing.Point(9, 30);
            pnlLecture.Name = "pnlLecture";
            pnlLecture.Size = new System.Drawing.Size(938, 466);
            pnlLecture.TabIndex = 4;
            // 
            // lectureListView
            // 
            lectureListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { Id, lectureFirstName, lectureLastName, phoneNumber, lecutreAge, lectureRoomId, isSupervisor });
            lectureListView.Location = new System.Drawing.Point(13, 42);
            lectureListView.Name = "lectureListView";
            lectureListView.Size = new System.Drawing.Size(767, 398);
            lectureListView.TabIndex = 3;
            lectureListView.UseCompatibleStateImageBehavior = false;
            // 
            // Id
            // 
            Id.Text = "Id";
            // 
            // lectureFirstName
            // 
            lectureFirstName.Text = "First Name";
            // 
            // lectureLastName
            // 
            lectureLastName.Text = "Last Name";
            // 
            // phoneNumber
            // 
            phoneNumber.Text = "Phone Number";
            // 
            // lecutreAge
            // 
            lecutreAge.Text = "Age";
            // 
            // lectureRoomId
            // 
            lectureRoomId.Text = "Room ID";
            // 
            // isSupervisor
            // 
            isSupervisor.Text = "Is Supervisor";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(805, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(130, 123);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(13, 7);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(110, 32);
            label2.TabIndex = 0;
            label2.Text = "Lecturers";
            // 
            // pnlRooms
            // 
            pnlRooms.Controls.Add(roomListView);
            pnlRooms.Controls.Add(pictureBox3);
            pnlRooms.Controls.Add(label3);
            pnlRooms.Location = new System.Drawing.Point(9, 30);
            pnlRooms.Name = "pnlRooms";
            pnlRooms.Size = new System.Drawing.Size(938, 466);
            pnlRooms.TabIndex = 5;
            // 
            // roomListView
            // 
            roomListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { capacity, roomNumber, type });
            roomListView.Location = new System.Drawing.Point(24, 42);
            roomListView.Name = "roomListView";
            roomListView.Size = new System.Drawing.Size(766, 365);
            roomListView.TabIndex = 4;
            roomListView.UseCompatibleStateImageBehavior = false;
            // 
            // capacity
            // 
            capacity.DisplayIndex = 1;
            capacity.Text = "Capacity";
            // 
            // roomNumber
            // 
            roomNumber.DisplayIndex = 0;
            roomNumber.Text = "Room Number";
            // 
            // type
            // 
            type.Text = "Type";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (System.Drawing.Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new System.Drawing.Point(805, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(130, 123);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(13, 7);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(86, 32);
            label3.TabIndex = 0;
            label3.Text = "Rooms";
            // 
            // studentBindingSource1
            // 
            studentBindingSource1.DataSource = typeof(SomerenModel.Student);
            // 
            // studentBindingSource
            // 
            studentBindingSource.DataSource = typeof(SomerenModel.Student);
            // 
            // listViewStudents
            // 
            this.listViewStudents.Location = new System.Drawing.Point(16, 42);
            this.listViewStudents.Name = "listViewStudents";
            this.listViewStudents.Size = new System.Drawing.Size(766, 307);
            this.listViewStudents.TabIndex = 1;
            this.listViewStudents.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Students";
            // 
            // SomerenUI
            // 


            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 413);
            this.Controls.Add(this.panelrooms);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlStudents);
            this.Controls.Add(this.pnlDashboard);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SomerenUI";
            this.Text = "SomerenApp";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlDashboard.ResumeLayout(false);
            this.pnlDashboard.PerformLayout();
            this.pnlStudents.ResumeLayout(false);
            this.pnlStudents.PerformLayout();
            this.panelrooms.ResumeLayout(false);
            this.panelrooms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();


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
        private System.Windows.Forms.Panel pnlStudents;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;


        private System.Windows.Forms.Panel panelrooms;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ListView listViewRooms;
        private System.Windows.Forms.ColumnHeader roomNumber;
        private System.Windows.Forms.ColumnHeader room_type;
        private System.Windows.Forms.ColumnHeader Capacity;
        private System.Windows.Forms.ColumnHeader buildingtype;
        private System.Windows.Forms.Label labelrooms;

    }
}