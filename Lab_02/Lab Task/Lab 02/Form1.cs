using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from Student", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void Update_Info_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("UPDATE Student SET Name = @Name, Department = @Department, Session = @Session, CGPA = @CGPA, Address = @Address WHERE RegistrationNumber = @RegistrationNumber", con);
            if (RN.Text != "" && N.Text != "" && D.Text != "" && S.Text != "" && CGPA.Text != "" && A.Text != "")
            {
                cmd.Parameters.AddWithValue("@RegistrationNumber", RN.Text);
                cmd.Parameters.AddWithValue("@Name", N.Text);
                cmd.Parameters.AddWithValue("@Department", D.Text);
                cmd.Parameters.AddWithValue("@Session", S.Text);
                cmd.Parameters.AddWithValue("@CGPA", CGPA.Text);
                cmd.Parameters.AddWithValue("@Address", A.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("!!! Data Entry Updated  !!!");
                RN.Text = "";
                N.Text = "";
                D.Text = "";
                S.Text = "";
                CGPA.Text = "";
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
        private void Remove_Info_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("DELETE FROM Student WHERE RegistrationNumber = @RegistrationNumber", con);
            if (RN.Text != "" && N.Text != "" && D.Text != "" && S.Text != "" && CGPA.Text != "" && A.Text != "")
            {
                cmd.Parameters.AddWithValue("@RegistrationNumber", RN.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("!!! Data Entry Deleted !!!");
                RN.Text = "";
                N.Text = "";
                D.Text = "";
                S.Text = "";
                CGPA.Text = "";
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
        private void Search_Info_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT Count(*) FROM Student WHERE RegistrationNumber = @RegistrationNumber", con);
            cmd.Parameters.AddWithValue("@RegistrationNumber", RN.Text);
            int Count = (int)cmd.ExecuteScalar();
            if (Count > 0 && RN.Text != "")
            {
                MessageBox.Show("!!! Data Entry Found !!!");
            }
            else
            {
                MessageBox.Show("!!! Invalid Data Entry !!!");
            
            }
        }
        private void Add_Info_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("INSERT INTO Student VALUES (@RegistrationNumber, @Name, @Department, @Session, @CGPA, @Address)", con);
            if (RN.Text != "" && N.Text != "" && D.Text != "" && S.Text != "" && CGPA.Text != "" && A.Text != "")
            {
                cmd.Parameters.AddWithValue("@RegistrationNumber", RN.Text);
                cmd.Parameters.AddWithValue("@Name", N.Text);
                cmd.Parameters.AddWithValue("@Department", D.Text);
                cmd.Parameters.AddWithValue("@Session", S.Text);
                cmd.Parameters.AddWithValue("@CGPA", CGPA.Text);
                cmd.Parameters.AddWithValue("@Address", A.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("!!! Data Entry Saved !!!");
                RN.Text = "";
                N.Text = "";
                D.Text = "";
                S.Text = "";
                CGPA.Text = "";
                A.Text = "";
            }
            else
            {
                MessageBox.Show("!!! Invalid Data Entry !!!");
            }
            cmd = new SqlCommand("SELECT * FROM Student", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
