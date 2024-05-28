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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Finalized
{
    public partial class Student_CRUD : Form
    {
        public Student_CRUD()
        {
            InitializeComponent();

            var con = Configuration.getInstance().getConnection();
            con.OpenAsync();

            SqlCommand cmd = new SqlCommand("SELECT Id FROM Student", con);
            SqlDataReader Data = cmd.ExecuteReader();
            ID.Items.Clear();
            while (Data.Read())
            {
                int data = Data.GetInt32(0);
                ID.Items.Add(data);
            }
            con.Close();

            con.OpenAsync();
            cmd = new SqlCommand("SELECT RegistrationNo FROM Student", con);
            Data = cmd.ExecuteReader();
            RNCB.Items.Clear();
            while (Data.Read())
            {
                string data = Data.GetString(0);
                RNCB.Items.Add(data);
            }
            con.Close();

            CB.Text = "Create";

            IDL.Visible = false;
            ID.Visible = false;

            FN.Visible = true;
            FNL.Visible = true;

            LN.Visible = true;
            LNL.Visible = true;

            C.Visible = true;
            CL.Visible = true;

            E.Visible = true;
            EL.Visible = true;

            DOB.Visible = true;
            DOBL.Visible = true;

            G.Visible = true;
            GL.Visible = true;

            RN.Visible = true;
            RNCB.Visible = false;
            RNL.Visible = true;

            Create.Visible = true;
            Delete.Visible = false;
            Update.Visible = false;
        }

        private void Forward_Click(object sender, EventArgs e)
        {
            if (CB.Text == "Create")
            {
                IDL.Visible = false;
                ID.Visible = false;

                FN.Visible = true;
                FNL.Visible = true;

                LN.Visible = true;
                LNL.Visible = true;

                C.Visible = true;
                CL.Visible = true;

                E.Visible = true;
                EL.Visible = true;

                DOB.Visible = true;
                DOBL.Visible = true;

                G.Visible = true;
                GL.Visible = true;

                RN.Visible = true;
                RNCB.Visible= false;
                RNL.Visible = true;

                Create.Visible = true;
                Delete.Visible = false;
                Update.Visible = false;
            }
            else if (CB.Text == "Delete")
            {
                IDL.Visible = true;
                ID.Visible = true;

                FN.Visible = false;
                FNL.Visible = false;

                LN.Visible = false;
                LNL.Visible = false;

                C.Visible = false;
                CL.Visible = false;

                E.Visible = false;
                EL.Visible = false;

                DOB.Visible = false;
                DOBL.Visible = false;

                G.Visible = false;
                GL.Visible = false;

                RN.Visible = false;
                RNCB.Visible = true;
                RNL.Visible = true;

                Create.Visible = false;
                Delete.Visible = true;
                Update.Visible = false;
            }
            else if (CB.Text == "Update")
            {
                IDL.Visible = true;
                ID.Visible = true;

                FN.Visible = true;
                FNL.Visible = true;

                LN.Visible = true;
                LNL.Visible = true;

                C.Visible = true;
                CL.Visible = true;

                E.Visible = true;
                EL.Visible = true;

                DOB.Visible = true;
                DOBL.Visible = true;

                G.Visible = true;
                GL.Visible = true;

                RN.Visible = true;
                RNCB.Visible = false;
                RNL.Visible = true;

                Create.Visible = false;
                Delete.Visible = false;
                Update.Visible = true;
            }
            else
            {
                MessageBox.Show("! ! ! Selection Pending ! ! !");
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            con.OpenAsync();

            SqlCommand cmd = new SqlCommand("Select COUNT(*) FROM Person WHERE Contact = @Contact OR Email = @Email", con);
            cmd.Parameters.AddWithValue("@Contact", C.Text);
            cmd.Parameters.AddWithValue("@Email", E.Text);
            cmd.ExecuteNonQuery();
            int Count_01 = (int)cmd.ExecuteScalar();

            cmd = new SqlCommand("Select COUNT(*) FROM Student WHERE Id = @Id", con);
            cmd.Parameters.AddWithValue("@Id", ID.Text);
            cmd.ExecuteNonQuery();
            int Count_02 = (int)cmd.ExecuteScalar();

            cmd = new SqlCommand("Select COUNT(*) FROM Student WHERE RegistrationNo = @RegistrationNo", con);
            cmd.Parameters.AddWithValue("@RegistrationNo", RN.Text);
            cmd.ExecuteNonQuery();
            int Count_03 = (int)cmd.ExecuteScalar();

            cmd = new SqlCommand("UPDATE Person SET FirstName = @FirstName,LastName = @LastName,Contact = @Contact,Email = @Email,DateOfBirth = @DateOfBirth WHERE Id = @Id ", con);
            if (FN.Text != "" && LN.Text != "" && C.Text != "" && E.Text != "" && DOB.Text != "" && G.Text != "" && RN.Text != "" && Count_01 == 0 && Count_02 == 1 && Count_03 == 0)
            {
                cmd.Parameters.AddWithValue("@Id", ID.Text);
                cmd.Parameters.AddWithValue("@FirstName", FN.Text);
                cmd.Parameters.AddWithValue("@LastName", LN.Text);
                cmd.Parameters.AddWithValue("@Contact", C.Text);
                cmd.Parameters.AddWithValue("@Email", E.Text);
                cmd.Parameters.AddWithValue("@DateOfBirth", DOB.Text);
                if (G.Text == "Male")
                {
                    cmd.Parameters.AddWithValue("@Gender", 1);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Gender", 2);
                }
                cmd.ExecuteNonQuery();

                cmd = new SqlCommand("UPDATE Student SET RegistrationNo = @RegistrationNo WHERE Id = @Id", con);
                cmd.Parameters.AddWithValue("@RegistrationNo", RN.Text);
                cmd.Parameters.AddWithValue("@Id", ID.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("!!! Data Entry Saved !!!");
                ID.Text = "";
                FN.Text = "";
                LN.Text = "";
                C.Text = "";
                E.Text = "";
                DOB.Text = "";
                G.Text = "";
                RN.Text = "";

                this.Hide();
                Student_CRUD lms = new Student_CRUD();
                lms.Show();
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

            SqlCommand cmd = new SqlCommand("Select COUNT(*) FROM Student WHERE RegistrationNo = @RegistrationNo", con);
            cmd.Parameters.AddWithValue("@RegistrationNo", RNCB.Text);
            cmd.ExecuteNonQuery();
            int Count_01 = (int)cmd.ExecuteScalar();

            cmd = new SqlCommand("DELETE FROM Student WHERE RegistrationNo = @RegistrationNo", con);
            if (ID.Text != "" && Count_01 == 1)
            {
                cmd.Parameters.AddWithValue("@RegistrationNo", RNCB.Text);
                cmd.ExecuteNonQuery();

                ID.Items.Remove(ID.Text);
                RNCB.Items.Remove(RNCB.Text);

                MessageBox.Show("!!! Data Entry Deleted !!!");
                ID.Text = "";

                this.Hide();
                Student_CRUD lms = new Student_CRUD();
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

            SqlCommand cmd = new SqlCommand("Select COUNT(*) FROM Person WHERE Contact = @Contact OR Email = @Email", con);
            cmd.Parameters.AddWithValue("@Contact", C.Text);
            cmd.Parameters.AddWithValue("@Email", E.Text);
            cmd.ExecuteNonQuery();
            int Count_01 = (int)cmd.ExecuteScalar();

            cmd = new SqlCommand("Select COUNT(*) FROM Student WHERE RegistrationNo = @RegistrationNo", con);
            cmd.Parameters.AddWithValue("@RegistrationNo", RN.Text);
            cmd.ExecuteNonQuery();
            int Count_02 = (int)cmd.ExecuteScalar();

            cmd = new SqlCommand("Select Id FROM Person WHERE Contact = @Contact OR Email = @Email", con);
            cmd.Parameters.AddWithValue("@Contact", C.Text);
            cmd.Parameters.AddWithValue("@Email", E.Text);
            cmd.ExecuteNonQuery();
            string Id = null;
            object id = cmd.ExecuteScalar();
            if (id != null)
            {
                Id = id.ToString();
            }
            else if (id == null)
            {
                Id = "0";
            }

            cmd = new SqlCommand("Select COUNT(*) FROM Student WHERE Id = @Id", con);
            cmd.Parameters.AddWithValue("@Id", int.Parse(Id));
            cmd.ExecuteNonQuery();
            int Count_03 = (int)cmd.ExecuteScalar();

            cmd = new SqlCommand("INSERT INTO Person VALUES (@FirstName,@LastName,@Contact,@Email,@DateOfBirth,@Gender)", con);
            if (FN.Text != "" && LN.Text != "" && C.Text != "" && E.Text != "" && DOB.Text != "" && G.Text != "" && RN.Text != "" && Count_01 == 0 && Count_02 == 0)
            {
                cmd.Parameters.AddWithValue("@FirstName", FN.Text);
                cmd.Parameters.AddWithValue("@LastName", LN.Text);
                cmd.Parameters.AddWithValue("@Contact", C.Text);
                cmd.Parameters.AddWithValue("@Email", E.Text);
                cmd.Parameters.AddWithValue("@DateOfBirth", DOB.Text);
                if (G.Text == "Male")
                {
                    cmd.Parameters.AddWithValue("@Gender", 1);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Gender", 2);
                }
                cmd.ExecuteNonQuery();

                cmd = new SqlCommand("Select Id FROM Person WHERE FirstName = @FirstName AND LastName = @LastName AND Contact = @Contact AND Email = @Email AND DateOfBirth = @DateOfBirth AND Gender = @Gender", con);
                cmd.Parameters.AddWithValue("@FirstName", FN.Text);
                cmd.Parameters.AddWithValue("@LastName", LN.Text);
                cmd.Parameters.AddWithValue("@Contact", C.Text);
                cmd.Parameters.AddWithValue("@Email", E.Text);
                cmd.Parameters.AddWithValue("@DateOfBirth", DOB.Text);
                if (G.Text == "Male")
                {
                    cmd.Parameters.AddWithValue("@Gender", 1);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Gender", 2);
                }
                cmd.ExecuteNonQuery();
                id = cmd.ExecuteScalar();
                Id = id.ToString();

                ID.Items.Add(id);
                RNCB.Items.Add(RN.Text);

                cmd = new SqlCommand("INSERT INTO Student VALUES (@Id,@RegistrationNo)", con);
                cmd.Parameters.AddWithValue("@Id", int.Parse(Id));
                cmd.Parameters.AddWithValue("@RegistrationNo", RN.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("!!! Data Entry Saved !!!");
                FN.Text = "";
                LN.Text = "";
                C.Text = "";
                E.Text = "";
                DOB.Text = "";
                G.Text = "";
                RN.Text = "";
            }
            else if (FN.Text != "" && LN.Text != "" && C.Text != "" && E.Text != "" && DOB.Text != "" && G.Text != "" && RN.Text != "" && Count_01 >= 1 && Count_02 == 0 && Count_03 == 0)
            {
                cmd = new SqlCommand("INSERT INTO Student VALUES (@Id,@RegistrationNo)", con);
                cmd.Parameters.AddWithValue("@Id", int.Parse(Id));
                cmd.Parameters.AddWithValue("@RegistrationNo", RN.Text);
                cmd.ExecuteNonQuery();

                ID.Items.Add(id);
                RNCB.Items.Add(RN.Text);

                MessageBox.Show("!!! Data Entry Saved !!!");
                FN.Text = "";
                LN.Text = "";
                C.Text = "";
                E.Text = "";
                DOB.Text = "";
                G.Text = "";
                RN.Text = "";
            }
            else
            {
                MessageBox.Show("!!! Invalid Data Entry !!!");
            }
        }

        private void Student_CRUD_Load(object sender, EventArgs e)
        {

        }
    }
}
