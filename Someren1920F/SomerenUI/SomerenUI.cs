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
                pnl_Products.Hide();
                pnl_Orders.Hide();
                pnl_Sales.Hide();

                // show dashboard
                pnl_Dashboard.Show();
                
            }
            else if (panelName == "Students")
            {
                // hide all other panels
                pnl_Dashboard.Hide();
                pnl_Products.Hide();
                pnl_Orders.Hide();
                pnl_Sales.Hide();
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
                pnl_Products.Hide();
                pnl_Orders.Hide();
                pnl_Sales.Hide();
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
                pnl_Products.Hide();
                pnl_Orders.Hide();
                pnl_Sales.Hide();
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
            else if (panelName == "Products")
            {
                // hide all other panels
                pnl_Dashboard.Hide();
                pnl_Rooms.Hide();
                pnl_Students.Hide();
                pnl_teachers.Hide();
                pnl_Orders.Hide();
                pnl_Sales.Hide();

                //show product panel
                pnl_Products.Show();

                SomerenLogic.Product_Service productService = new SomerenLogic.Product_Service();
                List<Product> productList = productService.GetProducts();

                // clear the listview before filling it again
                listViewProducts.Items.Clear();

                foreach (SomerenModel.Product p in productList)
                {

                    ListViewItem li = new ListViewItem(p.Id.ToString());
                    li.SubItems.Add(p.Name);
                    li.SubItems.Add(p.PriceIncl.ToString("€0.00"));
                    li.SubItems.Add(p.Amount.ToString());
                    li.SubItems.Add(p.Description);
                    if (p.Amount < 10)
                    {
                        li.SubItems.Add("Voorraad bijna op");
                    }
                    else
                    {
                        li.SubItems.Add("Voldoende voorraad");
                    }
                    listViewProducts.Items.Add(li);
                }
            }
            else if (panelName == "Orders")
            {
                //hide all other panels
                pnl_Dashboard.Hide();
                pnl_Rooms.Hide();
                pnl_Students.Hide();
                pnl_teachers.Hide();
                pnl_Products.Hide();
                pnl_Sales.Hide();

                //show order panel
                pnl_Orders.Show();
                SomerenLogic.Student_Service studService = new SomerenLogic.Student_Service();
                List<Student> studentList = studService.GetStudents();

                foreach (SomerenModel.Student s in studentList)
                {
                    combo_Students.Items.Add(s.StudentID + " - " + s.FirstName + " " + s.LastName);
                }

                //fill products
                SomerenLogic.Product_Service productService = new SomerenLogic.Product_Service();
                List<Product> productList = productService.GetProducts();

                foreach (SomerenModel.Product p in productList)
                {
                    combo_Products.Items.Add(p.Id + " - " + p.Name);
                }
            }
            else if (panelName == "Sales")
            {
                // hide all others
                pnl_Dashboard.Hide();
                pnl_Rooms.Hide();
                pnl_Students.Hide();
                pnl_teachers.Hide();
                pnl_Products.Hide();
                pnl_Orders.Hide();

                // show sales
                pnl_Sales.Show();


            }
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dashboardToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            showPanel("Dashboard");
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


        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("What happens in Someren, stays in Someren!");
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Products");
        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Orders");
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Sales");
        }

        private void btn_Order_Click(object sender, EventArgs e)
        {
            //set to default
            combo_Students.Text = "Choose student";
            combo_Products.Text = "Choose product";
            //get studentid
            string studentInput = combo_Students.SelectedItem.ToString();
            string selectedStudent = studentInput.Substring(0, 2);
            selectedStudent = selectedStudent.Replace(" ", String.Empty);
            int selectedStudentID = int.Parse(selectedStudent);
            //get productid
            string productInput = combo_Products.SelectedItem.ToString();
            string selectedProduct = productInput.Substring(0, 2);
            selectedProduct = selectedProduct.Replace(" ", String.Empty);
            int selectedProductID = int.Parse(selectedProduct);
            //send to db
            try
            {
                Order_DAO order_db = new Order_DAO();
                order_db.Db_Send_Order(selectedProductID, selectedStudentID);
                MessageBox.Show("Successfully placed order.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString(), "Error while placing order", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
