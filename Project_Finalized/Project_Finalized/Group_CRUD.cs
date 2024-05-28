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
    public partial class Group_CRUD : Form
    {
        public Group_CRUD()
        {
            InitializeComponent();

            var con = Configuration.getInstance().getConnection();
            con.OpenAsync();

            SqlCommand cmd = new SqlCommand("SELECT Id FROM [Group] WHERE (SELECT COUNT(*) FROM GroupStudent WHERE Id = GroupId) < 4 ", con);
            SqlDataReader Data = cmd.ExecuteReader();
            GID.Items.Clear();
            while (Data.Read())
            {
                int data = Data.GetInt32(0);
                GID.Items.Add(data);
            }
            con.Close();

            con.OpenAsync();
            cmd = new SqlCommand("SELECT id FROM student WHERE id NOT IN (Select StudentId from GroupStudent)", con);
            Data = cmd.ExecuteReader();
            SID.Items.Clear();
            while (Data.Read())
            {
                int data = Data.GetInt32(0);
                SID.Items.Add(data);
            }
            con.Close();

            con.OpenAsync();
            cmd = new SqlCommand("SELECT StudentId FROM GroupStudent", con);
            Data = cmd.ExecuteReader();
            SID_2.Items.Clear();
            while (Data.Read())
            {
                int data = Data.GetInt32(0);
                SID_2.Items.Add(data);
            }
            con.Close();

            CB.Text = "Create";

            GID.Visible = true;
            GIDL.Visible = true;

            SID.Visible = true;
            SID_2.Visible = false;
            SIDL.Visible = true;

            S.Visible = true;
            SL.Visible = true;

            AD.Visible = true;
            ADL.Visible = true;

            CO.Visible = true;
            COL.Visible = true;

            Create.Visible = true;
            Delete.Visible = false;
        }

        private void Backward_Click(object sender, EventArgs e)
        {
            this.Hide();
            LMS lms = new LMS();
            lms.Show();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            con.OpenAsync();

            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM GroupStudent WHERE GroupId= @GroupId AND StudentId = @StudentId", con);
            cmd.Parameters.AddWithValue("@GroupId", GID.Text);
            cmd.Parameters.AddWithValue("@StudentId", SID_2.Text);
            cmd.ExecuteNonQuery();
            int Count_01 = (int)cmd.ExecuteScalar();

            cmd = new SqlCommand("DELETE FROM GroupStudent WHERE StudentId = @StudentId", con);
            if (GID.Text != "" && SID_2.Text != "" && Count_01 == 1)
            {
                cmd.Parameters.AddWithValue("@StudentId", SID_2.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("!!! Data Entry Deleted !!!");
                GID.Text = "";

                this.Hide();
                Group_CRUD lms = new Group_CRUD();
                lms.Show();
            }
            else
            {
                MessageBox.Show("!!! Invalid Data Entry !!!");
            }
        }

        private void Create_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            con.OpenAsync();

            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM GroupStudent WHERE StudentId = @StudentId", con);
            cmd.Parameters.AddWithValue("@StudentId", SID.Text);
            cmd.ExecuteNonQuery();
            int Count_01 = (int)cmd.ExecuteScalar();

            cmd = new SqlCommand("SELECT COUNT(*) FROM GroupStudent WHERE GroupId = @GroupId", con);
            cmd.Parameters.AddWithValue("@GroupId", GID.Text);
            cmd.ExecuteNonQuery();
            int Count_02 = (int)cmd.ExecuteScalar();

            cmd = new SqlCommand("SELECT COUNT(*) FROM Student WHERE Id = @Id", con);
            cmd.Parameters.AddWithValue("@Id", SID.Text);
            cmd.ExecuteNonQuery();
            int Count_03 = (int)cmd.ExecuteScalar();

            cmd = new SqlCommand("SELECT COUNT(*) FROM [Group] WHERE Id = @Id", con);
            cmd.Parameters.AddWithValue("@Id", GID.Text);
            cmd.ExecuteNonQuery();
            int Count_04 = (int)cmd.ExecuteScalar();

            cmd = new SqlCommand("INSERT INTO [Group] VALUES (@Created_On)", con);
            if (GID.Text != "" && SID.Text != "" && S.Text != "" && AD.Text != "" && CO.Text != "" && Count_01 == 0 && Count_03 == 1 && Count_04 == 0)
            {
                cmd.Parameters.AddWithValue("@Created_On", CO.Text);
                cmd.ExecuteNonQuery();

                cmd = new SqlCommand("SELECT Id FROM [Group] WHERE Id = @Id", con);
                cmd.Parameters.AddWithValue("@Id", GID.Text);
                cmd.ExecuteNonQuery();
                int Id = (int)cmd.ExecuteScalar();

                cmd = new SqlCommand("INSERT INTO GroupStudent VALUES(@GroupId,@StudentId,@Status,@AssignmentDate)", con);
                cmd.Parameters.AddWithValue("@GroupId", Id);
                cmd.Parameters.AddWithValue("@StudentId", SID.Text);
                if (S.Text == "Active")
                {
                    cmd.Parameters.AddWithValue("@Status", 3);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Status", 4);
                }
                cmd.Parameters.AddWithValue("@AssignmentDate", AD.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("!!! Data Entry Saved !!!");
                GID.Text = "";
                SID.Text = "";
                S.Text = "";
                AD.Text = "";

                this.Hide();
                Group_CRUD lms = new Group_CRUD();
                lms.Show();
            }
            else if (GID.Text != "" && SID.Text != "" && S.Text != "" && AD.Text != "" && CO.Text != "" && Count_01 == 0 && Count_02 < 4 && Count_03 == 1 && Count_04 == 1)
            {
                cmd = new SqlCommand("INSERT INTO GroupStudent VALUES(@GroupId,@StudentId,@Status,@AssignmentDate)", con);
                cmd.Parameters.AddWithValue("@GroupId", GID.Text);
                cmd.Parameters.AddWithValue("@StudentId", SID.Text);
                if (S.Text == "Active")
                {
                    cmd.Parameters.AddWithValue("@Status", 3);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Status", 4);
                }
                cmd.Parameters.AddWithValue("@AssignmentDate", AD.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("!!! Data Entry Saved !!!");
                GID.Text = "";
                SID.Text = "";
                S.Text = "";
                AD.Text = "";

                this.Hide();
                Group_CRUD lms = new Group_CRUD();
                lms.Show();
            }
            else
            {
                MessageBox.Show("!!! Invalid Data Entry !!!");
            }
        }

        private void Forward_Click(object sender, EventArgs e)
        {
            if (CB.Text == "Create")
            {
                GID.Visible = true;
                GIDL.Visible = true;

                SID.Visible = true;
                SID_2.Visible = false;
                SIDL.Visible = true;

                S.Visible = true;
                SL.Visible = true;

                AD.Visible = true;
                ADL.Visible = true;

                CO.Visible = true;
                COL.Visible = true;

                Create.Visible = true;
                Delete.Visible = false;
            }
            else if (CB.Text == "Delete")
            {
                GID.Visible = true;
                GIDL.Visible = true;

                SID.Visible = false;
                SID_2.Visible = true;
                SIDL.Visible = true;

                S.Visible = false;
                SL.Visible = false;

                AD.Visible = false;
                ADL.Visible = false;

                CO.Visible = false;
                COL.Visible = false;

                Create.Visible = false;
                Delete.Visible = true;
            }
            else
            {
                MessageBox.Show("! ! ! Selection Pending ! ! !");
            }
        }
    }
}
