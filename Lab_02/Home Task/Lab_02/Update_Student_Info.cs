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
    public partial class Update_Student_Info : Form
    {
        public Update_Student_Info()
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
            SqlCommand cmd = new SqlCommand("UPDATE Student SET Name = @Name, Department = @Department, Session = @Session, Address = @Address WHERE RegistrationNumber = @RegistrationNumber", con);
            if (RN.Text != "" && N.Text != "" && D.Text != "" && S.Text != "" && A.Text != "")
            {
                cmd.Parameters.AddWithValue("@RegistrationNumber", RN.Text);
                cmd.Parameters.AddWithValue("@Name", N.Text);
                cmd.Parameters.AddWithValue("@Department", D.Text);
                cmd.Parameters.AddWithValue("@Session", S.Text);
                cmd.Parameters.AddWithValue("@Address", A.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("!!! Data Entry Updated  !!!");
                RN.Text = "";
                N.Text = "";
                D.Text = "";
                S.Text = "";
                A.Text = "";
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
