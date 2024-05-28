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

namespace Project_Finalized
{
    public partial class Group_Project : Form
    {
        public Group_Project()
        {
            InitializeComponent();

            var con = Configuration.getInstance().getConnection();
            con.OpenAsync();

            SqlCommand cmd = new SqlCommand("SELECT Id FROM [Group] WHERE Id NOT IN (SELECT GroupId FROM GroupProject)", con);
            SqlDataReader Data = cmd.ExecuteReader();
            GID.Items.Clear();
            while (Data.Read())
            {
                int data = Data.GetInt32(0);
                GID.Items.Add(data);
            }
            con.Close();

            con.OpenAsync();
            cmd = new SqlCommand("SELECT Id FROM Project WHERE Id NOT IN (SELECT ProjectId FROM GroupProject)", con);
            Data = cmd.ExecuteReader();
            PID.Items.Clear();
            while (Data.Read())
            {
                int data = Data.GetInt32(0);
                PID.Items.Add(data);
            }
            con.Close();
        }

        private void Forward_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            con.OpenAsync();

            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM [Group] WHERE Id = @Id", con);
            cmd.Parameters.AddWithValue("@Id", GID.Text);
            cmd.ExecuteNonQuery();
            int Count_01 = (int)cmd.ExecuteScalar();

            cmd = new SqlCommand("SELECT COUNT(*) FROM Project WHERE Id = @Id", con);
            cmd.Parameters.AddWithValue("@Id", PID.Text);
            cmd.ExecuteNonQuery();
            int Count_02 = (int)cmd.ExecuteScalar();

            cmd = new SqlCommand("SELECT COUNT(*) FROM GroupProject WHERE ProjectId = @ProjectId", con);
            cmd.Parameters.AddWithValue("@ProjectId", PID.Text);
            cmd.ExecuteNonQuery();
            int Count_03 = (int)cmd.ExecuteScalar();

            cmd = new SqlCommand("SELECT COUNT(*) FROM GroupProject WHERE GroupId = @GroupId", con);
            cmd.Parameters.AddWithValue("@GroupId", GID.Text);
            cmd.ExecuteNonQuery();
            int Count_04 = (int)cmd.ExecuteScalar();

            cmd = new SqlCommand("INSERT INTO GroupProject VALUES (@ProjectId,@GroupId,@AssignmentDate)", con);
            if (PID.Text != "" && GID.Text != "" && AD.Text != "" && Count_01 == 1 && Count_02 == 1 && Count_03 == 0 && Count_04 == 0)
            {
                cmd.Parameters.AddWithValue("@ProjectId", PID.Text);
                cmd.Parameters.AddWithValue("@GroupId", GID.Text);
                cmd.Parameters.AddWithValue("@AssignmentDate", AD.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("!!! Data Entry Saved !!!");
                PID.Text = "";
                GID.Text = "";
                AD.Text = "";

                this.Hide();
                Group_Project lms = new Group_Project();
                lms.Show();
            }
            else
            {
                MessageBox.Show("!!! Invalid Entry Saved !!!");
            }
        }

        private void Backward_Click(object sender, EventArgs e)
        {
            this.Hide();
            LMS lms = new LMS();
            lms.Show();
        }

        private void Group_Project_Load(object sender, EventArgs e)
        {

        }
    }
}
