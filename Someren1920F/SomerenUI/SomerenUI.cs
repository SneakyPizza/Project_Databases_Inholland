using SomerenLogic;
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


                // clear the listview before filling it again
                listViewStudents.Clear();
                // fill the students listview within the students panel with a list of students
                SomerenLogic.Student_Service studService = new SomerenLogic.Student_Service();
                List<Student> studentList = studService.GetStudents();



                foreach (SomerenModel.Student student in studentList)
                {
                    ListViewItem item = new ListViewItem(student.StudentID.ToString());
                    item.SubItems.Add(student.FirstName);
                    item.SubItems.Add(student.LastName);
                    item.SubItems.Add(student.EmailAddress);
                    item.SubItems.Add(student.PhoneNumber);
                    listViewStudents.Items.Add(item);
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
                // clear the listview before filling it again
                listViewteachers.Clear();

                // fill the teachers listview within the teachers panel with a list of teachers
                SomerenLogic.Teacher_Service teacherService = new SomerenLogic.Teacher_Service();
                List<Teacher> teacherList = teacherService.GetTeachers();



                foreach (SomerenModel.Teacher teacher in teacherList)
                {
                    ListViewItem item = new ListViewItem(teacher.TeacherID.ToString());
                    item.SubItems.Add(teacher.FirstName);
                    item.SubItems.Add(teacher.LastName);
                    item.SubItems.Add(teacher.EmailAddress);
                    item.SubItems.Add(teacher.PhoneNumber);
                    listViewteachers.Items.Add(item);
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
                // clear the listview before filling it again
                listViewRooms.Clear();

                // fill the room listview within the room panel with a list of rooms
                SomerenLogic.Room_Service roomService = new SomerenLogic.Room_Service();
                List<Room> roomList = roomService.GetRoom();



                foreach (SomerenModel.Room room in roomList)
                {
                    ListViewItem item = new ListViewItem(room.RoomID.ToString());
                    item.SubItems.Add(room.RoomType);
                    item.SubItems.Add(room.Capacity.ToString());
                    listViewRooms.Items.Add(item);
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
