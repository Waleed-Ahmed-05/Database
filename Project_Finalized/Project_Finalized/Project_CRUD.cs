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
    public partial class Project_CRUD : Form
    {
        public Project_CRUD()
        {
            InitializeComponent();

            PID.Visible = false;
            PIDL.Visible = false;

            T.Visible = true;
            TL.Visible = true;

            D.Visible = true;
            DL.Visible = true;

            AD.Visible = true;
            ADL.Visible = true;

            AID.Visible = true;
            AIDL.Visible = true;

            AR.Visible = true;
            ARL.Visible = true;

            Create.Visible = true;
            Update.Visible = false;
            Delete.Visible = false;

            CB.Text = "Create";

            var con = Configuration.getInstance().getConnection();
            con.OpenAsync();

            SqlCommand cmd = new SqlCommand("SELECT Id FROM Advisor", con);
            SqlDataReader Data = cmd.ExecuteReader();
            AID.Items.Clear();
            while (Data.Read())
            {
                int data = Data.GetInt32(0);
                AID.Items.Add(data);
            }

            con.Close();
            con.OpenAsync();

            cmd = new SqlCommand("SELECT ProjectId FROM ProjectAdvisor", con);
            Data = cmd.ExecuteReader();
            PID.Items.Clear();
            while (Data.Read())
            {
                int data = Data.GetInt32(0);
                PID.Items.Add(data);
            }
            con.Close();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            con.OpenAsync();

            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Project WHERE Description = @Description AND Title = @Title", con);
            cmd.Parameters.AddWithValue("@Description", D.Text);
            cmd.Parameters.AddWithValue("@Title", T.Text);
            cmd.ExecuteNonQuery();
            int Count_01 = (int)cmd.ExecuteScalar();

            cmd = new SqlCommand("SELECT COUNT(*) FROM ProjectAdvisor WHERE AdvisorId = @AdvisorId AND ProjectId = @ProjectId", con);
            cmd.Parameters.AddWithValue("@AdvisorId", AID.Text);
            cmd.Parameters.AddWithValue("@ProjectId", PID.Text);
            cmd.ExecuteNonQuery();
            int Count_02 = (int)cmd.ExecuteScalar();

            cmd = new SqlCommand("UPDATE ProjectAdvisor SET AdvisorId = @AdvisorId,AdvisorRole = @AdvisorRole,AssignmentDate = @AssignmentDate WHERE ProjectId = @ProjectId", con);
            if (D.Text != "" && T.Text != "" && AID.Text != "" && PID.Text != "" && AR.Text != "" && AD.Text != "" && Count_01 == 0 && Count_02 == 1)
            {
                cmd.Parameters.AddWithValue("@AdvisorId", AID.Text);
                cmd.Parameters.AddWithValue("@ProjectId", PID.Text);
                if (AR.Text == "Main Advisor")
                {
                    cmd.Parameters.AddWithValue("@AdvisorRole", 11);
                }
                else if (AR.Text == "Co-Advisor")
                {
                    cmd.Parameters.AddWithValue("@AdvisorRole", 12);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@AdvisorRole", 14);
                }
                cmd.Parameters.AddWithValue("@AssignmentDate", AD.Text);
                cmd.ExecuteNonQuery();

                cmd = new SqlCommand("UPDATE Project SET Description = @Description,Title = @Title WHERE Id = @Id", con);
                cmd.Parameters.AddWithValue("@Id", PID.Text);
                cmd.Parameters.AddWithValue("@Description", D.Text);
                cmd.Parameters.AddWithValue("@Title", T.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("!!! Data Entry Saved !!!");
                D.Text = "";
                T.Text = "";
                AID.Text = "";
                PID.Text = "";
                AR.Text = "";
                AD.Text = "";
            }
            else
            {
                MessageBox.Show("!!! Invalid Data Entry !!!");
            }
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

            SqlCommand cmd = new SqlCommand("Select COUNT(*) FROM ProjectAdvisor WHERE ProjectId = @Id", con);
            cmd.Parameters.AddWithValue("@Id", PID.Text);
            cmd.ExecuteNonQuery();
            int Count_01 = (int)cmd.ExecuteScalar();

            cmd = new SqlCommand("DELETE FROM ProjectAdvisor WHERE ProjectId = @Id", con);
            if (PID.Text != "" && Count_01 == 1)
            {
                cmd.Parameters.AddWithValue("@Id", PID.Text);
                cmd.ExecuteNonQuery();

                PID.Items.Remove(PID.Text);

                MessageBox.Show("!!! Data Entry Deleted !!!");
                PID.Text = "";

                this.Hide();
                Project_CRUD lms = new Project_CRUD();
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

            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Project WHERE Description = @Description AND Title = @Title", con);
            cmd.Parameters.AddWithValue("@Description", D.Text);
            cmd.Parameters.AddWithValue("@Title", T.Text);
            cmd.ExecuteNonQuery();
            int Count_01 = (int)cmd.ExecuteScalar();

            cmd = new SqlCommand("SELECT COUNT(*) FROM ProjectAdvisor WHERE AdvisorId = @AdvisorId", con);
            cmd.Parameters.AddWithValue("@AdvisorId", AID.Text);
            cmd.ExecuteNonQuery();
            int Count_02 = (int)cmd.ExecuteScalar();

            if (D.Text != "" && T.Text != "" && AR.Text != "" && AD.Text != "" && Count_01 == 0)
            {
                cmd = new SqlCommand("INSERT INTO Project VALUES (@Description,@Title)", con);
                cmd.Parameters.AddWithValue("@Description", D.Text);
                cmd.Parameters.AddWithValue("@Title", T.Text);
                cmd.ExecuteNonQuery();

                cmd = new SqlCommand("SELECT Id FROM Project WHERE Description = @Description AND Title = @Title", con);
                cmd.Parameters.AddWithValue("@Description", D.Text);
                cmd.Parameters.AddWithValue("@Title", T.Text);
                cmd.ExecuteNonQuery();
                int Id = (int)cmd.ExecuteScalar();

                cmd = new SqlCommand("INSERT INTO ProjectAdvisor VALUES (@AdvisorId,@ProjectId,@AdvisorRole,@AssignmentDate)", con);
                cmd.Parameters.AddWithValue("@AdvisorId", AID.Text);
                cmd.Parameters.AddWithValue("@ProjectId", Id);
                if (AR.Text == "Main Advisor")
                {
                    cmd.Parameters.AddWithValue("@AdvisorRole", 11);
                }
                else if (AR.Text == "Co - Advisor")
                {
                    cmd.Parameters.AddWithValue("@AdvisorRole", 12);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@AdvisorRole", 14);
                }
                cmd.Parameters.AddWithValue("@AssignmentDate", AD.Text);
                cmd.ExecuteNonQuery();

                PID.Items.Add(Id);

                MessageBox.Show("!!! Data Entry Saved !!!");
                D.Text = "";
                T.Text = "";
                AR.Text = "";
                AD.Text = "";
            }
            else if (D.Text != "" && T.Text != "" && AR.Text != "" && AD.Text != "" && Count_01 == 1 && Count_02 == 0)
            {
                cmd = new SqlCommand("SELECT Id FROM Project WHERE Description = @Description AND Title = @Title", con);
                cmd.Parameters.AddWithValue("@Description", D.Text);
                cmd.Parameters.AddWithValue("@Title", T.Text);
                cmd.ExecuteNonQuery();
                int Id = (int)cmd.ExecuteScalar();

                cmd = new SqlCommand("INSERT INTO ProjectAdvisor VALUES (@AdvisorId,@ProjectId,@AdvisorRole,@AssignmentDate)", con);
                cmd.Parameters.AddWithValue("@AdvisorId", AID.Text);
                cmd.Parameters.AddWithValue("@ProjectId", Id);
                if (AR.Text == "Main Advisor")
                {
                    cmd.Parameters.AddWithValue("@AdvisorRole", 11);
                }
                else if (AR.Text == "Co-Advisor")
                {
                    cmd.Parameters.AddWithValue("@AdvisorRole", 12);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@AdvisorRole", 14);
                }
                cmd.Parameters.AddWithValue("@AssignmentDate", AD.Text);
                cmd.ExecuteNonQuery();

                PID.Items.Add(Id);

                MessageBox.Show("!!! Data Entry Saved !!!");
                D.Text = "";
                T.Text = "";
                AR.Text = "";
                AD.Text = "";
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
                PID.Visible = false;
                PIDL.Visible = false;

                T.Visible = true;
                TL.Visible = true;

                D.Visible = true;
                DL.Visible = true;

                AD.Visible = true;
                ADL.Visible = true;

                AID.Visible = true;
                AIDL.Visible = true;

                AR.Visible = true;
                ARL.Visible = true;

                Create.Visible = true;
                Update.Visible = false;
                Delete.Visible = false;
            }
            else if (CB.Text == "Update")
            {
                PID.Visible = true;
                PIDL.Visible = true;

                T.Visible = true;
                TL.Visible = true;

                D.Visible = true;
                DL.Visible = true;

                AD.Visible = true;
                ADL.Visible = true;

                AID.Visible = true;
                AIDL.Visible = true;

                AR.Visible = true;
                ARL.Visible = true;

                Create.Visible = false;
                Update.Visible = true;
                Delete.Visible = false;
            }
            else if (CB.Text == "Delete")
            {
                PID.Visible = true;
                PIDL.Visible = true;

                T.Visible = false;
                TL.Visible = false;

                D.Visible = false;
                DL.Visible = false;

                AD.Visible = false;
                ADL.Visible = false;

                AID.Visible = false;
                AIDL.Visible = false;

                AR.Visible = false;
                ARL.Visible = false;

                Create.Visible = false;
                Update.Visible = false;
                Delete.Visible = true;
            }
            else
            {
                MessageBox.Show("! ! ! Selection Pending ! ! !");
            }
        }
    }
}
