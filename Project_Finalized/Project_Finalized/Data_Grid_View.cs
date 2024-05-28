using CRUD_Operations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Finalized
{
    public partial class Data_Grid_View : Form
    {
        public Data_Grid_View()
        {
            // Initializing Database For Data Grid View

            InitializeComponent();
            var con = Configuration.getInstance().getConnection();

            // Displaying Lookup Table as Default

            SqlCommand cmd = new SqlCommand("Select * from Lookup", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Backward_Click(object sender, EventArgs e)
        {
            this.Hide();
            LMS lms = new LMS();
            lms.Show();
        }

        private void Forward_Click(object sender, EventArgs e)
        {

            // Initializing Database connection For Data Grid View

            var con = Configuration.getInstance().getConnection();

            // Initializing Data Types for Data Grid View

            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();

            if (T.Text == "1. Person")
            {
                cmd = new SqlCommand("SELECT * /* Id,FirstName,LastName,Contact,Email,DateOfBirth,(SELECT Value FROM Lookup WHERE Person.Gender = Lookup.Id) AS Gender */ FROM Person", con);
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (T.Text == "2. Student")
            {
                cmd = new SqlCommand("SELECT * /* Id,(SELECT FirstName + ' ' + LastName FROM Person WHERE Student.ID = Person.Id) AS Name,(SELECT Contact FROM Person WHERE Student.ID = Person.Id) AS Contact,RegistrationNo */ FROM Student", con);
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (T.Text == "3. Advisor")
            {
                cmd = new SqlCommand("SELECT * /* Id,(SELECT FirstName + ' ' + LastName FROM Person WHERE Advisor.ID = Person.Id) AS Name,(SELECT Contact FROM Person WHERE Advisor.ID = Person.Id) AS Contact,Designation,Salary */ FROM Advisor", con);
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (T.Text == "4. Group")
            {
                cmd = new SqlCommand("SELECT * FROM [Group]", con);
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (T.Text == "5. Project")
            {
                cmd = new SqlCommand("SELECT * FROM Project", con);
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (T.Text == "6. Project Advisor")
            {
                cmd = new SqlCommand("SELECT * FROM ProjectAdvisor", con);
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (T.Text == "7. Group Student")
            {
                cmd = new SqlCommand("SELECT * FROM GroupStudent", con);
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (T.Text == "8. Group Project")
            {
                cmd = new SqlCommand("SELECT * FROM GroupProject", con);
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (T.Text == "9. Evaluation")
            {
                cmd = new SqlCommand("SELECT * FROM Evaluation", con);
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (T.Text == "10. Group Evaluation")
            {
                cmd = new SqlCommand("SELECT * FROM GroupEvaluation", con);
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("! ! ! Selection Pending ! ! !");
            }
        }
    }
}
