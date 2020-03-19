﻿using SomerenLogic;
using SomerenModel;
using SomerenDAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SomerenUI
{
    public partial class SomerenUI : Form
    {
        public SomerenUI()
        {
            InitializeComponent();
        }

        private void SomerenUI_Load(object sender, EventArgs e)
        {
            showPanel("Dashboard");
        }

        
        private void showPanel(string panelName)
        {

            if (panelName == "Dashboard")
            {

                // hide all other panels
                pnl_Students.Hide();
                pnl_teachers.Hide();
                pnl_Rooms.Hide();

                // show dashboard
                pnl_Dashboard.Show();
                
            }
            else if (panelName == "Students")
            {
                // hide all other panels
                pnl_Dashboard.Hide();
                
                pnl_teachers.Hide();
                pnl_Rooms.Hide();

                // show students
                pnl_Students.Show();



                // fill the students listview within the students panel with a list of students
                SomerenLogic.Student_Service studService = new SomerenLogic.Student_Service();
                List<Student> studentList = studService.GetStudents();

                // clear the listview before filling it again
                listViewStudents.Items.Clear();

                foreach (SomerenModel.Student s in studentList)
                {

                    ListViewItem li = new ListViewItem(s.StudentID.ToString());
                    li.SubItems.Add(s.FirstName);
                    li.SubItems.Add(s.LastName);
                    li.SubItems.Add(s.EmailAddress);
                    li.SubItems.Add(s.PhoneNumber);
                    listViewStudents.Items.Add(li);
                }
            }
            else if (panelName == "Teachers")
            {
                // hide all other panels
                pnl_Dashboard.Hide();
                
                pnl_Students.Hide();
                pnl_Rooms.Hide();

                // show teachers
                pnl_teachers.Show();

                SomerenLogic.Teacher_Service teacherService = new SomerenLogic.Teacher_Service();
                List<Teacher> teacherList = teacherService.GetTeachers();

                // clear the listview before filling it again
                listViewteachers.Items.Clear();

                foreach (SomerenModel.Teacher t in teacherList)
                {

                    ListViewItem li = new ListViewItem(t.TeacherID.ToString());
                    li.SubItems.Add(t.FirstName);
                    li.SubItems.Add(t.LastName);
                    li.SubItems.Add(t.EmailAddress);
                    li.SubItems.Add(t.PhoneNumber);
                    listViewteachers.Items.Add(li);
                }


            }
            else if (panelName == "Rooms")
            {
                // hide all other panels
                pnl_Dashboard.Hide();
                
                pnl_Students.Hide();
                pnl_teachers.Hide();

                // show rooms
                pnl_Rooms.Show();

                SomerenLogic.Room_Service roomService = new SomerenLogic.Room_Service();
                List<Room> roomList = roomService.GetRoom();

                // clear the listview before filling it again
                listViewRooms.Items.Clear();

                foreach (SomerenModel.Room r in roomList)
                {

                    ListViewItem li = new ListViewItem(r.RoomID.ToString());
                    li.SubItems.Add(r.RoomType);
                    li.SubItems.Add(r.Capacity.ToString());
                    listViewRooms.Items.Add(li);
                }

            }
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
           //
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dashboardToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            showPanel("Dashboard");
        }


        private void img_Dashboard_Click(object sender, EventArgs e)
        {
            
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Students");

        }

        private void teacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Teachers");
        }

        private void roomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Rooms");
        }



        private void dashbordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Dashboard");
        }

        private void listViewteachers_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("What happens in Someren, stays in Someren!");
        }
    }
}
