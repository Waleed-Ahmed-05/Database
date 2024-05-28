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

namespace Lab2_Home
{
    public partial class Update_Course_Info : Form
    {
        public Update_Course_Info()
        {
            InitializeComponent();
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from Course", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Forward_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("UPDATE Course SET Course_Name = @Course_Name, Student_Name = @Student_Name, Teacher_Name = @Teacher_Name, Semester = @Semester WHERE Course_ID = @Course_ID", con);
            if (CID.Text != "" && CN.Text != "" && SN.Text != "" && TN.Text != "" && S.Text != "")
            {
                cmd.Parameters.AddWithValue("@Course_ID", CID.Text);
                cmd.Parameters.AddWithValue("@Course_Name", CN.Text);
                cmd.Parameters.AddWithValue("@Student_Name", SN.Text);
                cmd.Parameters.AddWithValue("@Teacher_Name", TN.Text);
                cmd.Parameters.AddWithValue("@Semester", S.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("!!! Data Entry Updated  !!!");
                CID.Text = "";
                CN.Text = "";
                SN.Text = "";
                TN.Text = "";
                S.Text = "";
            }
            else
            {
                MessageBox.Show("!!! Invalid Data Entry !!!");
            }
            cmd = new SqlCommand("Select * from Course", con);
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
