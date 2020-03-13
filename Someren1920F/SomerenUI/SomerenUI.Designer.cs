namespace SomerenUI
{
    partial class SomerenUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SomerenUI));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Id");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("FirstName");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("LastName");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Email");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("Phonenumber");
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashbordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_Dashboard = new System.Windows.Forms.Panel();
            this.picture_someren = new System.Windows.Forms.PictureBox();
            this.lbl_Dashboard = new System.Windows.Forms.Label();
            this.pnl_Students = new System.Windows.Forms.Panel();
            this.lbl_list = new System.Windows.Forms.Label();
            this.listViewStudents = new System.Windows.Forms.ListView();
            this.studentID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.studentName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.studentDOB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_Students = new System.Windows.Forms.Label();
            this.pnl_teachers = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listViewteachers = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnl_Rooms = new System.Windows.Forms.Panel();
            this.lbl_Rooms = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listViewRooms = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.pnl_Dashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_someren)).BeginInit();
            this.pnl_Students.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_teachers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.pnl_Rooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.dashbordToolStripMenuItem,
            this.studentsToolStripMenuItem,
            this.teacherToolStripMenuItem,
            this.roomsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1283, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem1,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.dashboardToolStripMenuItem.Text = "Application";
            this.dashboardToolStripMenuItem.Click += new System.EventHandler(this.dashboardToolStripMenuItem_Click);
            // 
            // dashboardToolStripMenuItem1
            // 
            this.dashboardToolStripMenuItem1.Name = "dashboardToolStripMenuItem1";
            this.dashboardToolStripMenuItem1.Size = new System.Drawing.Size(165, 26);
            this.dashboardToolStripMenuItem1.Text = "Dashboard";
            this.dashboardToolStripMenuItem1.Click += new System.EventHandler(this.dashboardToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(162, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // dashbordToolStripMenuItem
            // 
            this.dashbordToolStripMenuItem.Name = "dashbordToolStripMenuItem";
            this.dashbordToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.dashbordToolStripMenuItem.Text = "Dashbord";
            this.dashbordToolStripMenuItem.Click += new System.EventHandler(this.dashbordToolStripMenuItem_Click);
            // 
            // studentsToolStripMenuItem
            // 
            this.studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            this.studentsToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.studentsToolStripMenuItem.Text = "Students";
            this.studentsToolStripMenuItem.Click += new System.EventHandler(this.studentsToolStripMenuItem_Click);
            // 
            // teacherToolStripMenuItem
            // 
            this.teacherToolStripMenuItem.Name = "teacherToolStripMenuItem";
            this.teacherToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.teacherToolStripMenuItem.Text = "Teacher";
            this.teacherToolStripMenuItem.Click += new System.EventHandler(this.teacherToolStripMenuItem_Click);
            // 
            // roomsToolStripMenuItem
            // 
            this.roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            this.roomsToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.roomsToolStripMenuItem.Text = "Rooms";
            this.roomsToolStripMenuItem.Click += new System.EventHandler(this.roomsToolStripMenuItem_Click);
            // 
            // pnl_Dashboard
            // 
            this.pnl_Dashboard.Controls.Add(this.picture_someren);
            this.pnl_Dashboard.Controls.Add(this.lbl_Dashboard);
            this.pnl_Dashboard.Location = new System.Drawing.Point(16, 33);
            this.pnl_Dashboard.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_Dashboard.Name = "pnl_Dashboard";
            this.pnl_Dashboard.Size = new System.Drawing.Size(1251, 574);
            this.pnl_Dashboard.TabIndex = 2;
            // 
            // picture_someren
            // 
            this.picture_someren.Image = global::SomerenUI.Properties.Resources.someren;
            this.picture_someren.InitialImage = ((System.Drawing.Image)(resources.GetObject("picture_someren.InitialImage")));
            this.picture_someren.Location = new System.Drawing.Point(1078, 0);
            this.picture_someren.Margin = new System.Windows.Forms.Padding(4);
            this.picture_someren.Name = "picture_someren";
            this.picture_someren.Size = new System.Drawing.Size(173, 151);
            this.picture_someren.TabIndex = 2;
            this.picture_someren.TabStop = false;
            this.picture_someren.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // lbl_Dashboard
            // 
            this.lbl_Dashboard.AutoSize = true;
            this.lbl_Dashboard.Location = new System.Drawing.Point(17, 16);
            this.lbl_Dashboard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Dashboard.Name = "lbl_Dashboard";
            this.lbl_Dashboard.Size = new System.Drawing.Size(243, 17);
            this.lbl_Dashboard.TabIndex = 1;
            this.lbl_Dashboard.Text = "Welcome to the Someren Application!";
            // 
            // pnl_Students
            // 
            this.pnl_Students.Controls.Add(this.lbl_list);
            this.pnl_Students.Controls.Add(this.listViewStudents);
            this.pnl_Students.Controls.Add(this.pictureBox1);
            this.pnl_Students.Controls.Add(this.lbl_Students);
            this.pnl_Students.Location = new System.Drawing.Point(16, 32);
            this.pnl_Students.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_Students.Name = "pnl_Students";
            this.pnl_Students.Size = new System.Drawing.Size(1251, 574);
            this.pnl_Students.TabIndex = 4;
            // 
            // lbl_list
            // 
            this.lbl_list.AutoSize = true;
            this.lbl_list.Location = new System.Drawing.Point(47, 76);
            this.lbl_list.Name = "lbl_list";
            this.lbl_list.Size = new System.Drawing.Size(0, 17);
            this.lbl_list.TabIndex = 6;
            // 
            // listViewStudents
            // 
            this.listViewStudents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.studentID,
            this.studentName,
            this.studentDOB});
            this.listViewStudents.HideSelection = false;
            this.listViewStudents.Location = new System.Drawing.Point(25, 49);
            this.listViewStudents.Margin = new System.Windows.Forms.Padding(4);
            this.listViewStudents.Name = "listViewStudents";
            this.listViewStudents.Size = new System.Drawing.Size(1020, 377);
            this.listViewStudents.TabIndex = 5;
            this.listViewStudents.UseCompatibleStateImageBehavior = false;
            // 
            // studentID
            // 
            this.studentID.Text = "ID";
            // 
            // studentName
            // 
            this.studentName.Text = "Name";
            // 
            // studentDOB
            // 
            this.studentDOB.Text = "Date of Birth";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SomerenUI.Properties.Resources.someren;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(1073, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 151);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_Students
            // 
            this.lbl_Students.AutoSize = true;
            this.lbl_Students.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Students.Location = new System.Drawing.Point(19, 12);
            this.lbl_Students.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Students.Name = "lbl_Students";
            this.lbl_Students.Size = new System.Drawing.Size(129, 33);
            this.lbl_Students.TabIndex = 3;
            this.lbl_Students.Text = "Students";
            // 
            // pnl_teachers
            // 
            this.pnl_teachers.Controls.Add(this.pictureBox5);
            this.pnl_teachers.Controls.Add(this.label1);
            this.pnl_teachers.Controls.Add(this.label2);
            this.pnl_teachers.Controls.Add(this.listViewteachers);
            this.pnl_teachers.Location = new System.Drawing.Point(16, 32);
            this.pnl_teachers.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_teachers.Name = "pnl_teachers";
            this.pnl_teachers.Size = new System.Drawing.Size(1251, 574);
            this.pnl_teachers.TabIndex = 9;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::SomerenUI.Properties.Resources.someren;
            this.pictureBox5.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.InitialImage")));
            this.pictureBox5.Location = new System.Drawing.Point(1074, 12);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(173, 151);
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 33);
            this.label1.TabIndex = 8;
            this.label1.Text = "Teachers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 6;
            // 
            // listViewteachers
            // 
            this.listViewteachers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewteachers.GridLines = true;
            this.listViewteachers.HideSelection = false;
            listViewItem1.Tag = "id";
            listViewItem2.Tag = "FirstName";
            listViewItem3.Tag = "LastName";
            listViewItem4.Tag = "Email";
            listViewItem5.Tag = "Phonenumber";
            this.listViewteachers.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5});
            this.listViewteachers.Location = new System.Drawing.Point(25, 49);
            this.listViewteachers.Margin = new System.Windows.Forms.Padding(4);
            this.listViewteachers.Name = "listViewteachers";
            this.listViewteachers.Size = new System.Drawing.Size(1020, 377);
            this.listViewteachers.TabIndex = 5;
            this.listViewteachers.UseCompatibleStateImageBehavior = false;
            // 
            // pnl_Rooms
            // 
            this.pnl_Rooms.Controls.Add(this.lbl_Rooms);
            this.pnl_Rooms.Controls.Add(this.label4);
            this.pnl_Rooms.Controls.Add(this.listViewRooms);
            this.pnl_Rooms.Controls.Add(this.pictureBox3);
            this.pnl_Rooms.Location = new System.Drawing.Point(16, 32);
            this.pnl_Rooms.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_Rooms.Name = "pnl_Rooms";
            this.pnl_Rooms.Size = new System.Drawing.Size(1251, 574);
            this.pnl_Rooms.TabIndex = 10;
            // 
            // lbl_Rooms
            // 
            this.lbl_Rooms.AutoSize = true;
            this.lbl_Rooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Rooms.Location = new System.Drawing.Point(14, 12);
            this.lbl_Rooms.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Rooms.Name = "lbl_Rooms";
            this.lbl_Rooms.Size = new System.Drawing.Size(108, 33);
            this.lbl_Rooms.TabIndex = 8;
            this.lbl_Rooms.Text = "Rooms";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 6;
            // 
            // listViewRooms
            // 
            this.listViewRooms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewRooms.HideSelection = false;
            this.listViewRooms.Location = new System.Drawing.Point(25, 49);
            this.listViewRooms.Margin = new System.Windows.Forms.Padding(4);
            this.listViewRooms.Name = "listViewRooms";
            this.listViewRooms.Size = new System.Drawing.Size(1020, 377);
            this.listViewRooms.TabIndex = 5;
            this.listViewRooms.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Date of Birth";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SomerenUI.Properties.Resources.someren;
            this.pictureBox3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.InitialImage")));
            this.pictureBox3.Location = new System.Drawing.Point(1073, 12);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(173, 151);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // SomerenUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 622);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnl_teachers);
            this.Controls.Add(this.pnl_Rooms);
            this.Controls.Add(this.pnl_Students);
            this.Controls.Add(this.pnl_Dashboard);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SomerenUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "SomerenApp";
            this.Load += new System.EventHandler(this.SomerenUI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnl_Dashboard.ResumeLayout(false);
            this.pnl_Dashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_someren)).EndInit();
            this.pnl_Students.ResumeLayout(false);
            this.pnl_Students.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_teachers.ResumeLayout(false);
            this.pnl_teachers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.pnl_Rooms.ResumeLayout(false);
            this.pnl_Rooms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel pnl_Dashboard;
        private System.Windows.Forms.Label lbl_Dashboard;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomsToolStripMenuItem;
        private System.Windows.Forms.Panel pnl_Students;
        private System.Windows.Forms.Label lbl_Students;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listViewStudents;
        private System.Windows.Forms.ColumnHeader studentID;
        private System.Windows.Forms.ColumnHeader studentName;
        private System.Windows.Forms.ColumnHeader studentDOB;
        private System.Windows.Forms.ToolStripMenuItem teacherToolStripMenuItem;
        private System.Windows.Forms.Label lbl_list;
        private System.Windows.Forms.ToolStripMenuItem dashbordToolStripMenuItem;
        private System.Windows.Forms.Panel pnl_teachers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listViewteachers;
        private System.Windows.Forms.Panel pnl_Rooms;
        private System.Windows.Forms.Label lbl_Rooms;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listViewRooms;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.PictureBox picture_someren;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}

