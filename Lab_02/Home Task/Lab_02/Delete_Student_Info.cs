using CRUD_Operations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_Home
{
    public partial class Delete_Student_Info : Form
    {
        public Delete_Student_Info()
        {
            InitializeComponent();
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from Student", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Forward_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("DELETE FROM Student WHERE RegistrationNumber = @RegistrationNumber", con);
            if (RN.Text != "")
            {
                cmd.Parameters.AddWithValue("@RegistrationNumber", RN.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("!!! Data Entry Deleted !!!");
                RN.Text = "";
            }
            else
            {
                MessageBox.Show("!!! Invalid Data Entry !!!");
            }
            cmd = new SqlCommand("Select * from Student", con);
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
    }
}
