using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_Home
{
    public partial class LMS : Form
    {
        public LMS()
        {
            InitializeComponent();
        }

        private void Add_Result_Info_Click(object sender, EventArgs e)
        {
            this.Hide();
            New_Result_Info NRI = new New_Result_Info();
            NRI.Show();
        }

        private void Add_Student_Info_Click(object sender, EventArgs e)
        {
            this.Hide();
            New_Student_Info NSI = new New_Student_Info();
            NSI.Show();
        }

        private void Add_Course_Info_Click(object sender, EventArgs e)
        {
            this.Hide();
            New_Course_Info NCI = new New_Course_Info();
            NCI.Show();
        }

        private void Delete_Course_Info_Click(object sender, EventArgs e)
        {
            this.Hide();
            Delete_Course_Info DCI = new Delete_Course_Info();
            DCI.Show();
        }

        private void Delete_Student_Info_Click(object sender, EventArgs e)
        {
            this.Hide();
            Delete_Student_Info DSI = new Delete_Student_Info();
            DSI.Show();
        }

        private void Delete_Result_Info_Click(object sender, EventArgs e)
        {
            this.Hide();
            Delete_Result_Info DRI = new Delete_Result_Info();
            DRI.Show();
        }

        private void Update_Result_Info_Click(object sender, EventArgs e)
        {
            this.Hide();
            Update_Result_Info URI = new Update_Result_Info();
            URI.Show();
        }

        private void Update_Student_Info_Click(object sender, EventArgs e)
        {
            this.Hide();
            Update_Student_Info USI = new Update_Student_Info();
            USI.Show();
        }

        private void Update_Course_Info_Click(object sender, EventArgs e)
        {
            this.Hide();
            Update_Course_Info UCI = new Update_Course_Info();
            UCI.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}