using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Finalized
{
    public partial class LMS : Form
    {
        public LMS()
        {
            InitializeComponent();
        }

        private void DGV_Click(object sender, EventArgs e)
        {
            this.Hide();
            Data_Grid_View lms = new Data_Grid_View();
            lms.Show();
        }

        private void Terminate_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void S_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student_CRUD lms = new Student_CRUD();
            lms.Show();
        }

        private void A_Click(object sender, EventArgs e)
        {
            this.Hide();
            Advisor_CRUD lms = new Advisor_CRUD();
            lms.Show();
        }

        private void P_Click(object sender, EventArgs e)
        {
            this.Hide();
            Project_CRUD lms = new Project_CRUD();
            lms.Show();
        }

        private void G_Click(object sender, EventArgs e)
        {
            this.Hide();
            Group_CRUD lms = new Group_CRUD();
            lms.Show();
        }

        private void GP_Click(object sender, EventArgs e)
        {
            this.Hide();
            Group_Project lms = new Group_Project();
            lms.Show();
        }

        private void E_Click(object sender, EventArgs e)
        {
            this.Hide();
            Evaluation_CRUD lms = new Evaluation_CRUD();
            lms.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Generate_PDF lms = new Generate_PDF();
            lms.Show();
        }
    }
}
