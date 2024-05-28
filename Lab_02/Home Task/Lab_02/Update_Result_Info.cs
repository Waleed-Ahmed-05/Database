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
    public partial class Update_Result_Info : Form
    {
        public Update_Result_Info()
        {
            InitializeComponent();
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from Result", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Forward_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("UPDATE Result SET Student_Name = @Student_Name, Course_Name = @Course_Name, Marks = @Marks, Grade = @Grade, Section = @Section, Semester = @Semester, Session = @Session WHERE Student_ID = @Student_ID", con);
            if (SID.Text != "" && SN.Text != "" && CN.Text != "" && M.Text != "" && G.Text != "" && SEC.Text != "" && S.Text != "" && SES.Text != "")
            {
                cmd.Parameters.AddWithValue("@Student_ID", SID.Text);
                cmd.Parameters.AddWithValue("@Student_Name", SN.Text);
                cmd.Parameters.AddWithValue("@Course_Name", CN.Text);
                cmd.Parameters.AddWithValue("@Marks", M.Text);
                cmd.Parameters.AddWithValue("@Grade", G.Text);
                cmd.Parameters.AddWithValue("@Section", SEC.Text);
                cmd.Parameters.AddWithValue("@Semester", S.Text);
                cmd.Parameters.AddWithValue("@Session", SES.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("!!! Data Entry Saved !!!");
                SID.Text = "";
                SN.Text = "";
                CN.Text = "";
                M.Text = "";
                G.Text = "";
                SEC.Text = "";
                S.Text = "";
                SES.Text = "";
            }
            else
            {
                MessageBox.Show("!!! Invalid Data Entry !!!");
            }
            cmd = new SqlCommand("SELECT * FROM Result", con);
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