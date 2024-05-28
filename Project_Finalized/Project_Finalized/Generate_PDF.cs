using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using CRUD_Operations;
using System.Data.SqlClient;
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;
using System.Collections;

namespace Project_Finalized
{
    public partial class Generate_PDF : Form
    {
        public Generate_PDF()
        {
            InitializeComponent();

            GID.Visible = true;

            var con = Configuration.getInstance().getConnection();
            con.OpenAsync();

            SqlCommand cmd = new SqlCommand("SELECT GroupId FROM GroupEvaluation", con);
            SqlDataReader Data = cmd.ExecuteReader();
            GID.Items.Clear();
            while (Data.Read())
            {
                int data = Data.GetInt32(0);
                GID.Items.Add(data);
            }
            con.Close();
        }

        private void Forward_Click(object sender, EventArgs e)
        {
            if (CB.Text == "Project Details" && GID.Text != "")
            {
                Document document = new Document();
                string filePath = @"C:\Users\waah8\Downloads\Project_Details.pdf";
                PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
                document.Open();

                Paragraph heading = new Paragraph("PROJECT DETAILS", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 24));
                heading.Alignment = Element.ALIGN_CENTER;
                document.Add(heading);
                document.Add(new Chunk("\n"));

                var con = Configuration.getInstance().getConnection();
                con.OpenAsync();

                SqlCommand cmd = new SqlCommand("SELECT Title FROM GroupProject,Project WHERE Id = ProjectId AND GroupId = @GroupId", con);
                cmd.Parameters.AddWithValue("@GroupId", GID.Text);
                object CO = cmd.ExecuteScalar();
                Paragraph statement = new Paragraph($"Title: {CO}");
                statement.Alignment = Element.ALIGN_LEFT;
                document.Add(statement);
                cmd = new SqlCommand("SELECT Description FROM GroupProject,Project WHERE Id = ProjectId AND GroupId = @GroupId", con);
                cmd.Parameters.AddWithValue("@GroupId", GID.Text);
                CO = cmd.ExecuteScalar();
                statement = new Paragraph($"Description: {CO}");
                statement.Alignment = Element.ALIGN_LEFT;
                document.Add(statement);
                cmd = new SqlCommand("SELECT AssignmentDate FROM GroupProject,Project WHERE Id = ProjectId AND GroupId = @GroupId", con);
                cmd.Parameters.AddWithValue("@GroupId", GID.Text);
                CO = cmd.ExecuteScalar();
                statement = new Paragraph($"Assigned On: {CO}");
                statement.Alignment = Element.ALIGN_LEFT;
                document.Add(statement);
                document.Add(new Chunk("\n"));

                heading = new Paragraph("ADVISOR DETAILS", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18));
                heading.Alignment = Element.ALIGN_CENTER;
                document.Add(heading);
                document.Add(new Chunk("\n"));

                cmd = new SqlCommand("SELECT (SELECT FirstName + ' ' + Lastname FROM Person WHERE Advisor.Id = Person.Id) FROM GroupProject,Project,ProjectAdvisor,Advisor WHERE Project.Id = GroupProject.ProjectId AND Project.Id = ProjectAdvisor.ProjectId AND GroupId = @GroupId AND Advisor.Id = ProjectAdvisor.AdvisorId", con);
                cmd.Parameters.AddWithValue("@GroupId", GID.Text);
                CO = cmd.ExecuteScalar();
                statement = new Paragraph($"Name: {CO}");
                statement.Alignment = Element.ALIGN_LEFT;
                document.Add(statement);

                cmd = new SqlCommand("SELECT (SELECT Value FROM Lookup WHERE Designation = Lookup.Id) FROM GroupProject,Project,ProjectAdvisor,Advisor WHERE Project.Id = GroupProject.ProjectId AND Project.Id = ProjectAdvisor.ProjectId AND GroupId = @GroupId AND Advisor.Id = ProjectAdvisor.AdvisorId", con);
                cmd.Parameters.AddWithValue("@GroupId", GID.Text);
                CO = cmd.ExecuteScalar();
                statement = new Paragraph($"Designation: {CO}");
                statement.Alignment = Element.ALIGN_LEFT;
                document.Add(statement);

                cmd = new SqlCommand("SELECT (SELECT Value FROM Lookup WHERE AdvisorRole = Lookup.Id) FROM GroupProject,Project,ProjectAdvisor WHERE Project.Id = GroupProject.ProjectId AND Project.Id = ProjectAdvisor.ProjectId AND GroupId = @GroupId", con);
                cmd.Parameters.AddWithValue("@GroupId", GID.Text);
                CO = cmd.ExecuteScalar();
                statement = new Paragraph($"Role: {CO}");
                statement.Alignment = Element.ALIGN_LEFT;
                document.Add(statement);

                cmd = new SqlCommand("SELECT (SELECT Contact FROM Person WHERE Advisor.Id = Person.Id) FROM GroupProject,Project,ProjectAdvisor,Advisor WHERE Project.Id = GroupProject.ProjectId AND Project.Id = ProjectAdvisor.ProjectId AND GroupId = @GroupId AND Advisor.Id = ProjectAdvisor.AdvisorId", con);
                cmd.Parameters.AddWithValue("@GroupId", GID.Text);
                CO = cmd.ExecuteScalar();
                statement = new Paragraph($"Contact: {CO}");
                statement.Alignment = Element.ALIGN_LEFT;
                document.Add(statement);

                cmd = new SqlCommand("SELECT (SELECT Email FROM Person WHERE Advisor.Id = Person.Id) FROM GroupProject,Project,ProjectAdvisor,Advisor WHERE Project.Id = GroupProject.ProjectId AND Project.Id = ProjectAdvisor.ProjectId AND GroupId = @GroupId AND Advisor.Id = ProjectAdvisor.AdvisorId", con);
                cmd.Parameters.AddWithValue("@GroupId", GID.Text);
                CO = cmd.ExecuteScalar();
                statement = new Paragraph($"E-mail: {CO}");
                statement.Alignment = Element.ALIGN_LEFT;
                document.Add(statement);

                document.Add(new Chunk("\n"));
                heading = new Paragraph("GROUP DETAILS", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18));
                heading.Alignment = Element.ALIGN_CENTER;
                document.Add(heading);
                document.Add(new Chunk("\n"));

                cmd = new SqlCommand("SELECT Created_On FROM [Group]", con);
                CO = cmd.ExecuteScalar();
                statement = new Paragraph($"This group was officially created on {CO} .");
                statement.Alignment = Element.ALIGN_CENTER;
                document.Add(statement);
                document.Add(new Chunk("\n"));

                con.Close();
                con.OpenAsync();

                cmd = new SqlCommand("SELECT (SELECT RegistrationNo FROM Student WHERE Id = StudentId) AS [Reg.No],AssignmentDate AS [Assigned On],(SELECT Value FROM Lookup WHERE Status = Lookup.Id) AS Status FROM GroupStudent WHERE GroupId = @GroupId", con);
                cmd.Parameters.AddWithValue("@GroupId", GID.Text);
                SqlDataReader Data = cmd.ExecuteReader();
                PdfPTable table_01 = new PdfPTable(Data.FieldCount);
                for (int i = 0; i < Data.FieldCount; i++)
                {
                    table_01.AddCell(new Phrase(Data.GetName(i), FontFactory.GetFont(FontFactory.HELVETICA_BOLD)));
                }
                while (Data.Read())
                {
                    for (int i = 0; i < Data.FieldCount; i++)
                    {
                        table_01.AddCell(new Phrase(Data[i].ToString()));
                    }
                }
                Data.Close();
                document.Add(table_01);

                document.Add(new Chunk("\n"));
                heading = new Paragraph("GROUP MEMBERS", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18));
                heading.Alignment = Element.ALIGN_CENTER;
                document.Add(heading);
                document.Add(new Chunk("\n"));

                cmd = new SqlCommand("SELECT RegistrationNo AS [Reg.No],FirstName + ' ' + LastName AS Name,Contact,Email AS [E-mail],(SELECT Value FROM Lookup WHERE Gender = Lookup.Id) AS Gender FROM GroupStudent,Student,Person WHERE GroupId = @GroupId AND Student.Id = GroupStudent.StudentId AND Student.Id = Person.Id", con);
                cmd.Parameters.AddWithValue("@GroupId", GID.Text);
                Data = cmd.ExecuteReader();
                PdfPTable table_02 = new PdfPTable(Data.FieldCount);
                for (int i = 0; i < Data.FieldCount; i++)
                {
                    table_02.AddCell(new Phrase(Data.GetName(i), FontFactory.GetFont(FontFactory.HELVETICA_BOLD)));
                }
                while (Data.Read())
                {
                    for (int i = 0; i < Data.FieldCount; i++)
                    {
                        table_02.AddCell(new Phrase(Data[i].ToString()));
                    }
                }
                Data.Close();
                document.Add(table_02);

                document.Close();

                document.Close();
                MessageBox.Show("! ! ! PDF Successfully Generated ! ! !");
            }
            else if (CB.Text == "Evaluation Report" && GID.Text != "")
            {
                Document document = new Document();
                string filePath = @"C:\Users\waah8\Downloads\GroupEvaluation_Report.pdf";
                PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
                document.Open();

                Paragraph heading = new Paragraph("GROUP EVALUATION REPORT", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 24));
                heading.Alignment = Element.ALIGN_CENTER;
                document.Add(heading);
                document.Add(new Chunk("\n"));
                heading = new Paragraph("EVALUATION DETAILS", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18));
                heading.Alignment = Element.ALIGN_CENTER;
                document.Add(heading);
                document.Add(new Chunk("\n"));


                var con = Configuration.getInstance().getConnection();
                con.OpenAsync();

                SqlCommand cmd = new SqlCommand("SELECT Name,TotalMarks AS Total,TotalWeightage AS Weightage,ObtainedMarks AS Obtained,EvaluationDate AS [Evaluated On] FROM Evaluation,GroupEvaluation WHERE Id = EvaluationId AND GroupId = @GroupId", con);
                cmd.Parameters.AddWithValue("@GroupId", GID.Text);
                SqlDataReader Data = cmd.ExecuteReader();
                PdfPTable table = new PdfPTable(Data.FieldCount);
                for (int i = 0; i < Data.FieldCount; i++)
                {
                    table.AddCell(new Phrase(Data.GetName(i), FontFactory.GetFont(FontFactory.HELVETICA_BOLD)));
                }
                while (Data.Read())
                {
                    for (int i = 0; i < Data.FieldCount; i++)
                    {
                        table.AddCell(new Phrase(Data[i].ToString()));
                    }
                }
                Data.Close();
                document.Add(table);
                document.Add(new Chunk("\n"));
                heading = new Paragraph("GROUP DETAILS", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18));
                heading.Alignment = Element.ALIGN_CENTER;
                document.Add(heading);
                document.Add(new Chunk("\n"));

                cmd = new SqlCommand("SELECT Created_On FROM [Group]", con);
                object CO = cmd.ExecuteScalar();
                Paragraph statement = new Paragraph($"This group was officially created on {CO} .");
                statement.Alignment = Element.ALIGN_CENTER;
                document.Add(statement);
                document.Add(new Chunk("\n"));

                con.Close();
                con.OpenAsync();

                cmd = new SqlCommand("SELECT (SELECT RegistrationNo FROM Student WHERE Id = StudentId) AS [Reg.No],AssignmentDate AS [Assigned On],(SELECT Value FROM Lookup WHERE Status = Lookup.Id) AS Status FROM GroupStudent WHERE GroupId = @GroupId", con);
                cmd.Parameters.AddWithValue("@GroupId", GID.Text);
                Data = cmd.ExecuteReader();
                PdfPTable table_01 = new PdfPTable(Data.FieldCount);
                for (int i = 0; i < Data.FieldCount; i++)
                {
                    table_01.AddCell(new Phrase(Data.GetName(i), FontFactory.GetFont(FontFactory.HELVETICA_BOLD)));
                }
                while (Data.Read())
                {
                    for (int i = 0; i < Data.FieldCount; i++)
                    {
                        table_01.AddCell(new Phrase(Data[i].ToString()));
                    }
                }
                Data.Close();
                document.Add(table_01);

                document.Add(new Chunk("\n"));
                heading = new Paragraph("GROUP MEMBERS", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18));
                heading.Alignment = Element.ALIGN_CENTER;
                document.Add(heading);
                document.Add(new Chunk("\n"));

                cmd = new SqlCommand("SELECT RegistrationNo AS [Reg.No],FirstName + ' ' + LastName AS Name,Contact,Email AS [E-mail],(SELECT Value FROM Lookup WHERE Gender = Lookup.Id) AS Gender FROM GroupStudent,Student,Person WHERE GroupId = @GroupId AND Student.Id = GroupStudent.StudentId AND Student.Id = Person.Id", con);
                cmd.Parameters.AddWithValue("@GroupId", GID.Text);
                Data = cmd.ExecuteReader();
                PdfPTable table_02 = new PdfPTable(Data.FieldCount);
                for (int i = 0; i < Data.FieldCount; i++)
                {
                    table_02.AddCell(new Phrase(Data.GetName(i), FontFactory.GetFont(FontFactory.HELVETICA_BOLD)));
                }
                while (Data.Read())
                {
                    for (int i = 0; i < Data.FieldCount; i++)
                    {
                        table_02.AddCell(new Phrase(Data[i].ToString()));
                    }
                }
                Data.Close();
                document.Add(table_02);

                document.Close();

                MessageBox.Show("! ! ! PDF Successfully Generated ! ! !");
            }
            else if (CB.Text == "Evaluation Report & Project Details")
            {
                Document document = new Document();
                string filePath = @"C:\Users\waah8\Downloads\Report.pdf";
                PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
                document.Open();

                Paragraph heading = new Paragraph("GROUP REPORT", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 24));
                heading.Alignment = Element.ALIGN_CENTER;
                document.Add(heading);
                document.Add(new Chunk("\n"));

                var con = Configuration.getInstance().getConnection();
                con.OpenAsync();

                SqlCommand cmd = new SqlCommand("SELECT Title FROM GroupProject,Project WHERE Id = ProjectId AND GroupId = @GroupId", con);
                cmd.Parameters.AddWithValue("@GroupId", GID.Text);
                object CO = cmd.ExecuteScalar();
                Paragraph statement = new Paragraph($"Title: {CO}");
                statement.Alignment = Element.ALIGN_LEFT;
                document.Add(statement);

                cmd = new SqlCommand("SELECT Description FROM GroupProject,Project WHERE Id = ProjectId AND GroupId = @GroupId", con);
                cmd.Parameters.AddWithValue("@GroupId", GID.Text);
                CO = cmd.ExecuteScalar();
                statement = new Paragraph($"Description: {CO}");
                statement.Alignment = Element.ALIGN_LEFT;
                document.Add(statement);

                cmd = new SqlCommand("SELECT AssignmentDate FROM GroupProject,Project WHERE Id = ProjectId AND GroupId = @GroupId", con);
                cmd.Parameters.AddWithValue("@GroupId", GID.Text);
                CO = cmd.ExecuteScalar();
                statement = new Paragraph($"Assigned On: {CO}");
                statement.Alignment = Element.ALIGN_LEFT;
                document.Add(statement);

                heading = new Paragraph("ADVISOR DETAILS", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18));
                heading.Alignment = Element.ALIGN_CENTER;
                document.Add(heading);

                cmd = new SqlCommand("SELECT (SELECT FirstName + ' ' + Lastname FROM Person WHERE Advisor.Id = Person.Id) FROM GroupProject,Project,ProjectAdvisor,Advisor WHERE Project.Id = GroupProject.ProjectId AND Project.Id = ProjectAdvisor.ProjectId AND GroupId = @GroupId AND Advisor.Id = ProjectAdvisor.AdvisorId", con);
                cmd.Parameters.AddWithValue("@GroupId", GID.Text);
                CO = cmd.ExecuteScalar();
                statement = new Paragraph($"Name: {CO}");
                statement.Alignment = Element.ALIGN_LEFT;
                document.Add(statement);

                cmd = new SqlCommand("SELECT (SELECT Value FROM Lookup WHERE Designation = Lookup.Id) FROM GroupProject,Project,ProjectAdvisor,Advisor WHERE Project.Id = GroupProject.ProjectId AND Project.Id = ProjectAdvisor.ProjectId AND GroupId = @GroupId AND Advisor.Id = ProjectAdvisor.AdvisorId", con);
                cmd.Parameters.AddWithValue("@GroupId", GID.Text);
                CO = cmd.ExecuteScalar();
                statement = new Paragraph($"Designation: {CO}");
                statement.Alignment = Element.ALIGN_LEFT;
                document.Add(statement);

                cmd = new SqlCommand("SELECT (SELECT Value FROM Lookup WHERE AdvisorRole = Lookup.Id) FROM GroupProject,Project,ProjectAdvisor WHERE Project.Id = GroupProject.ProjectId AND Project.Id = ProjectAdvisor.ProjectId AND GroupId = @GroupId", con);
                cmd.Parameters.AddWithValue("@GroupId", GID.Text);
                CO = cmd.ExecuteScalar();
                statement = new Paragraph($"Role: {CO}");
                statement.Alignment = Element.ALIGN_LEFT;
                document.Add(statement);

                cmd = new SqlCommand("SELECT (SELECT Contact FROM Person WHERE Advisor.Id = Person.Id) FROM GroupProject,Project,ProjectAdvisor,Advisor WHERE Project.Id = GroupProject.ProjectId AND Project.Id = ProjectAdvisor.ProjectId AND GroupId = @GroupId AND Advisor.Id = ProjectAdvisor.AdvisorId", con);
                cmd.Parameters.AddWithValue("@GroupId", GID.Text);
                CO = cmd.ExecuteScalar();
                statement = new Paragraph($"Contact: {CO}");
                statement.Alignment = Element.ALIGN_LEFT;
                document.Add(statement);

                cmd = new SqlCommand("SELECT (SELECT Email FROM Person WHERE Advisor.Id = Person.Id) FROM GroupProject,Project,ProjectAdvisor,Advisor WHERE Project.Id = GroupProject.ProjectId AND Project.Id = ProjectAdvisor.ProjectId AND GroupId = @GroupId AND Advisor.Id = ProjectAdvisor.AdvisorId", con);
                cmd.Parameters.AddWithValue("@GroupId", GID.Text);
                CO = cmd.ExecuteScalar();
                statement = new Paragraph($"E-mail: {CO}");
                statement.Alignment = Element.ALIGN_LEFT;
                document.Add(statement);

                heading = new Paragraph("GROUP DETAILS", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18));
                heading.Alignment = Element.ALIGN_CENTER;
                document.Add(heading);

                cmd = new SqlCommand("SELECT Created_On FROM [Group]", con);
                CO = cmd.ExecuteScalar();
                statement = new Paragraph($"This group was officially created on {CO} .");
                statement.Alignment = Element.ALIGN_CENTER;
                document.Add(statement);
                document.Add(new Chunk("\n"));

                con.Close();
                con.OpenAsync();

                cmd = new SqlCommand("SELECT (SELECT RegistrationNo FROM Student WHERE Id = StudentId) AS [Reg.No],AssignmentDate AS [Assigned On],(SELECT Value FROM Lookup WHERE Status = Lookup.Id) AS Status FROM GroupStudent WHERE GroupId = @GroupId", con);
                cmd.Parameters.AddWithValue("@GroupId", GID.Text);
                SqlDataReader Data = cmd.ExecuteReader();
                PdfPTable table_01 = new PdfPTable(Data.FieldCount);
                for (int i = 0; i < Data.FieldCount; i++)
                {
                    table_01.AddCell(new Phrase(Data.GetName(i), FontFactory.GetFont(FontFactory.HELVETICA_BOLD)));
                }
                while (Data.Read())
                {
                    for (int i = 0; i < Data.FieldCount; i++)
                    {
                        table_01.AddCell(new Phrase(Data[i].ToString()));
                    }
                }
                Data.Close();
                document.Add(table_01);

                document.Add(new Chunk("\n"));
                heading = new Paragraph("GROUP MEMBERS", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18));
                heading.Alignment = Element.ALIGN_CENTER;
                document.Add(heading);
                document.Add(new Chunk("\n"));

                cmd = new SqlCommand("SELECT RegistrationNo AS [Reg.No],FirstName + ' ' + LastName AS Name,Contact,Email AS [E-mail],(SELECT Value FROM Lookup WHERE Gender = Lookup.Id) AS Gender FROM GroupStudent,Student,Person WHERE GroupId = @GroupId AND Student.Id = GroupStudent.StudentId AND Student.Id = Person.Id", con);
                cmd.Parameters.AddWithValue("@GroupId", GID.Text);
                Data = cmd.ExecuteReader();
                PdfPTable table_02 = new PdfPTable(Data.FieldCount);
                for (int i = 0; i < Data.FieldCount; i++)
                {
                    table_02.AddCell(new Phrase(Data.GetName(i), FontFactory.GetFont(FontFactory.HELVETICA_BOLD)));
                }
                while (Data.Read())
                {
                    for (int i = 0; i < Data.FieldCount; i++)
                    {
                        table_02.AddCell(new Phrase(Data[i].ToString()));
                    }
                }
                Data.Close();
                document.Add(table_02);

                document.Add(new Chunk("\n"));
                heading = new Paragraph("EVALUATION DETAILS", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18));
                heading.Alignment = Element.ALIGN_CENTER;
                document.Add(heading);
                document.Add(new Chunk("\n"));

                cmd = new SqlCommand("SELECT Name,TotalMarks AS Total,TotalWeightage AS Weightage,ObtainedMarks AS Obtained,EvaluationDate AS [Evaluated On] FROM Evaluation,GroupEvaluation WHERE Id = EvaluationId AND GroupId = @GroupId", con);
                cmd.Parameters.AddWithValue("@GroupId", GID.Text);
                Data = cmd.ExecuteReader();
                PdfPTable table = new PdfPTable(Data.FieldCount);
                for (int i = 0; i < Data.FieldCount; i++)
                {
                    table.AddCell(new Phrase(Data.GetName(i), FontFactory.GetFont(FontFactory.HELVETICA_BOLD)));
                }
                while (Data.Read())
                {
                    for (int i = 0; i < Data.FieldCount; i++)
                    {
                        table.AddCell(new Phrase(Data[i].ToString()));
                    }
                }
                Data.Close();
                document.Add(table);

                document.Close();
                MessageBox.Show("! ! ! PDF Successfully Generated ! ! !");
            }
            else
            {
                MessageBox.Show("! ! ! Selection Pending ! ! !");
            }
        }

        private void Backward_Click(object sender, EventArgs e)
        {
            this.Hide();
            LMS lMS = new LMS();
            lMS.Show();
        }
    }
}
