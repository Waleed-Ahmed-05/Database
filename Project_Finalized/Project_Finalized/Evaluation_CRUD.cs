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
    public partial class Evaluation_CRUD : Form
    {
        public Evaluation_CRUD()
        {
            InitializeComponent();

            CB.Text = "Create";

            N.Visible = true;
            NL.Visible = true;

            TM.Visible = true;
            TML.Visible = true;

            TW.Visible = true;
            TWL.Visible = true;

            GID.Visible = true;
            GID_2.Visible = false;
            GIDL.Visible = true;

            OM.Visible = true;
            OML.Visible = true;

            ED.Visible = true;
            EDL.Visible = true;

            EID.Visible = false;
            EIDL.Visible = false;

            Create.Visible = true;
            Update.Visible = false;

            var con = Configuration.getInstance().getConnection();
            con.OpenAsync();

            SqlCommand cmd = new SqlCommand("SELECT GroupId FROM GroupProject WHERE GroupId NOT IN (SELECT GroupId FROM GroupEvaluation)", con);
            SqlDataReader Data = cmd.ExecuteReader();
            GID.Items.Clear();
            while (Data.Read())
            {
                int data = Data.GetInt32(0);
                GID.Items.Add(data);
            }
            con.Close();

            con.OpenAsync(); 
            cmd = new SqlCommand("SELECT EvaluationId FROM GroupEvaluation", con);
            Data = cmd.ExecuteReader();
            EID.Items.Clear();
            while (Data.Read())
            {
                int data = Data.GetInt32(0);
                EID.Items.Add(data);
            }
            con.Close();

            con.OpenAsync();
            cmd = new SqlCommand("SELECT GroupId FROM GroupProject", con);
            Data = cmd.ExecuteReader();
            GID_2.Items.Clear();
            while (Data.Read())
            {
                int data = Data.GetInt32(0);
                GID_2.Items.Add(data);
            }
            con.Close();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            con.OpenAsync();

            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM GroupEvaluation WHERE GroupId = @GroupId", con);
            cmd.Parameters.AddWithValue("@GroupId", GID_2.Text);
            cmd.ExecuteNonQuery();
            int Count_01 = (int)cmd.ExecuteScalar();

            cmd = new SqlCommand("SELECT COUNT(*) FROM [Group] WHERE Id = @Id", con);
            cmd.Parameters.AddWithValue("@Id", GID_2.Text);
            cmd.ExecuteNonQuery();
            int Count_02 = (int)cmd.ExecuteScalar();

            cmd = new SqlCommand("SELECT COUNT(*) FROM Evaluation WHERE Id = @Id", con);
            cmd.Parameters.AddWithValue("@Id", EID.Text);
            cmd.ExecuteNonQuery();
            int Count_03 = (int)cmd.ExecuteScalar();

            cmd = new SqlCommand("UPDATE Evaluation SET Name = @Name,TotalMarks = @TotalMarks,TotalWeightage = @TotalWeightage WHERE Id = @Id", con);
            if (N.Text != "" && TM.Text != "" && TW.Text != "" && GID_2.Text != "" && EID.Text != "" && OM.Text != "" && ED.Text != "" && Count_01 == 1 && Count_02 >= 1 && Count_03 == 1)
            {
                cmd.Parameters.AddWithValue("@Name", N.Text);
                cmd.Parameters.AddWithValue("@TotalMarks", TM.Text);
                cmd.Parameters.AddWithValue("@TotalWeightage", TW.Text);
                cmd.Parameters.AddWithValue("@Id", EID.Text);
                cmd.ExecuteNonQuery();

                cmd = new SqlCommand("UPDATE GroupEvaluation SET ObtainedMarks = @ObtainedMarks,EvaluationDate = @EvaluationDate WHERE EvaluationId = @EvaluationId AND GroupId = @GroupId", con);
                cmd.Parameters.AddWithValue("@EvaluationId", EID.Text);
                cmd.Parameters.AddWithValue("@GroupId", GID_2.Text);
                cmd.Parameters.AddWithValue("@ObtainedMarks", OM.Text);
                cmd.Parameters.AddWithValue("@EvaluationDate", ED.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("!!! Data Entry Saved !!!");
                N.Text = "";
                TM.Text = "";
                TW.Text = "";
                EID.Text = "";
                GID_2.Text = "";
                OM.Text = "";
                ED.Text = "";
            }
            else
            {
                MessageBox.Show("!!! Invalid Entry Saved !!!");
            }
        }

        private void Backward_Click(object sender, EventArgs e)
        {
            this.Hide();
            LMS lMS = new LMS();
            lMS.Show();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            con.OpenAsync();

            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Evaluation WHERE Name = @Name", con);
            cmd.Parameters.AddWithValue("@Name", N.Text);
            cmd.ExecuteNonQuery();
            int Count_01 = (int)cmd.ExecuteScalar();

            cmd = new SqlCommand("SELECT COUNT(*) FROM GroupEvaluation WHERE GroupId = @GroupId", con);
            cmd.Parameters.AddWithValue("@GroupId", GID.Text);
            cmd.ExecuteNonQuery();
            int Count_02 = (int)cmd.ExecuteScalar();

            cmd = new SqlCommand("SELECT COUNT(*) FROM [Group] WHERE Id = @Id", con);
            cmd.Parameters.AddWithValue("@Id", GID.Text);
            cmd.ExecuteNonQuery();
            int Count_04 = (int)cmd.ExecuteScalar();

            cmd = new SqlCommand("INSERT INTO Evaluation VALUES (@Name,@TotalMarks,@TotalWeightage)", con);
            if (N.Text != "" && TM.Text != "" && TW.Text != "" && GID.Text != "" && OM.Text != "" && ED.Text != "" && Count_01 == 0 && Count_02 == 0 && Count_04 >= 1)
            {
                cmd.Parameters.AddWithValue("@Name", N.Text);
                cmd.Parameters.AddWithValue("@TotalMarks", TM.Text);
                cmd.Parameters.AddWithValue("@TotalWeightage", TW.Text);
                cmd.ExecuteNonQuery();

                cmd = new SqlCommand("SELECT Id FROM Evaluation WHERE Name = @Name", con);
                cmd.Parameters.AddWithValue("@Name", N.Text);
                cmd.Parameters.AddWithValue("@TotalMarks", TM.Text);
                cmd.Parameters.AddWithValue("@TotalWeightage", TW.Text);
                cmd.ExecuteNonQuery();
                int Id = (int)cmd.ExecuteScalar();

                cmd = new SqlCommand("INSERT INTO GroupEvaluation VALUES(@GroupId,@EvaluationId,@ObtainedMarks,@EvaluationDate)", con);
                cmd.Parameters.AddWithValue("@EvaluationId", Id);
                cmd.Parameters.AddWithValue("@GroupId", GID.Text);
                cmd.Parameters.AddWithValue("@ObtainedMarks", OM.Text);
                cmd.Parameters.AddWithValue("@EvaluationDate", ED.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("!!! Data Entry Saved !!!");
                N.Text = "";
                TM.Text = "";
                TW.Text = "";
                GID.Text = "";
                OM.Text = "";
                ED.Text = "";

                this.Hide();
                Evaluation_CRUD lMS = new Evaluation_CRUD();
                lMS.Show();
            }
            else
            {
                MessageBox.Show("!!! Invalid Entry Saved !!!");
            }
        }

        private void Forward_Click(object sender, EventArgs e)
        {
            if (CB.Text == "Create")
            {
                N.Visible = true;
                NL.Visible = true;

                TM.Visible = true;
                TML.Visible = true;

                TW.Visible = true;
                TWL.Visible = true;

                GID.Visible = true;
                GID_2.Visible = false;
                GIDL.Visible = true;

                OM.Visible = true;
                OML.Visible = true;

                ED.Visible = true;
                EDL.Visible = true;

                EID.Visible = false;
                EIDL.Visible = false;

                Create.Visible = true;
                Update.Visible = false;
            }
            else if (CB.Text == "Update")
            {
                N.Visible = true;
                NL.Visible = true;

                TM.Visible = true;
                TML.Visible = true;

                TW.Visible = true;
                TWL.Visible = true;

                GID.Visible = false;
                GID_2.Visible = true;
                GIDL.Visible = true;

                OM.Visible = true;
                OML.Visible = true;

                ED.Visible = true;
                EDL.Visible = true;

                EID.Visible = true;
                EIDL.Visible = true;

                Create.Visible = false;
                Update.Visible = true;
            }
            else 
            {
                MessageBox.Show("! ! ! Selection Pending ! ! !");
            }
        }
    }
}
