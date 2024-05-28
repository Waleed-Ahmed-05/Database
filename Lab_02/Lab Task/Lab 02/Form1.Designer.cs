namespace Lab_02
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Add_Info = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.RN = new System.Windows.Forms.TextBox();
            this.N = new System.Windows.Forms.TextBox();
            this.D = new System.Windows.Forms.TextBox();
            this.S = new System.Windows.Forms.TextBox();
            this.CGPA = new System.Windows.Forms.TextBox();
            this.L_01 = new System.Windows.Forms.Label();
            this.L_02 = new System.Windows.Forms.Label();
            this.L_03 = new System.Windows.Forms.Label();
            this.L_04 = new System.Windows.Forms.Label();
            this.L_05 = new System.Windows.Forms.Label();
            this.Update_Info = new System.Windows.Forms.Button();
            this.Remove_Info = new System.Windows.Forms.Button();
            this.Search_Info = new System.Windows.Forms.Button();
            this.A = new System.Windows.Forms.TextBox();
            this.L_06 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Add_Info
            // 
            this.Add_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Info.Location = new System.Drawing.Point(52, 299);
            this.Add_Info.Name = "Add_Info";
            this.Add_Info.Size = new System.Drawing.Size(90, 38);
            this.Add_Info.TabIndex = 0;
            this.Add_Info.Text = "Add";
            this.Add_Info.UseVisualStyleBackColor = true;
            this.Add_Info.Click += new System.EventHandler(this.Add_Info_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(377, 57);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(411, 324);
            this.dataGridView1.TabIndex = 2;
            // 
            // RN
            // 
            this.RN.Location = new System.Drawing.Point(260, 57);
            this.RN.Name = "RN";
            this.RN.Size = new System.Drawing.Size(100, 22);
            this.RN.TabIndex = 3;
            // 
            // N
            // 
            this.N.Location = new System.Drawing.Point(183, 99);
            this.N.Name = "N";
            this.N.Size = new System.Drawing.Size(177, 22);
            this.N.TabIndex = 3;
            // 
            // D
            // 
            this.D.Location = new System.Drawing.Point(183, 142);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(177, 22);
            this.D.TabIndex = 3;
            // 
            // S
            // 
            this.S.Location = new System.Drawing.Point(183, 187);
            this.S.Name = "S";
            this.S.Size = new System.Drawing.Size(177, 22);
            this.S.TabIndex = 3;
            // 
            // CGPA
            // 
            this.CGPA.Location = new System.Drawing.Point(183, 230);
            this.CGPA.Name = "CGPA";
            this.CGPA.Size = new System.Drawing.Size(177, 22);
            this.CGPA.TabIndex = 3;
            // 
            // L_01
            // 
            this.L_01.AutoSize = true;
            this.L_01.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_01.Location = new System.Drawing.Point(37, 57);
            this.L_01.Name = "L_01";
            this.L_01.Size = new System.Drawing.Size(182, 20);
            this.L_01.TabIndex = 4;
            this.L_01.Text = "Registration Number";
            // 
            // L_02
            // 
            this.L_02.AutoSize = true;
            this.L_02.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_02.Location = new System.Drawing.Point(37, 101);
            this.L_02.Name = "L_02";
            this.L_02.Size = new System.Drawing.Size(57, 20);
            this.L_02.TabIndex = 4;
            this.L_02.Text = "Name";
            // 
            // L_03
            // 
            this.L_03.AutoSize = true;
            this.L_03.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_03.Location = new System.Drawing.Point(37, 142);
            this.L_03.Name = "L_03";
            this.L_03.Size = new System.Drawing.Size(107, 20);
            this.L_03.TabIndex = 4;
            this.L_03.Text = "Department";
            // 
            // L_04
            // 
            this.L_04.AutoSize = true;
            this.L_04.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_04.Location = new System.Drawing.Point(37, 189);
            this.L_04.Name = "L_04";
            this.L_04.Size = new System.Drawing.Size(76, 20);
            this.L_04.TabIndex = 4;
            this.L_04.Text = "Session";
            // 
            // L_05
            // 
            this.L_05.AutoSize = true;
            this.L_05.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_05.Location = new System.Drawing.Point(37, 230);
            this.L_05.Name = "L_05";
            this.L_05.Size = new System.Drawing.Size(60, 20);
            this.L_05.TabIndex = 4;
            this.L_05.Text = "CGPA";
            // 
            // Update_Info
            // 
            this.Update_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_Info.Location = new System.Drawing.Point(148, 299);
            this.Update_Info.Name = "Update_Info";
            this.Update_Info.Size = new System.Drawing.Size(90, 38);
            this.Update_Info.TabIndex = 0;
            this.Update_Info.Text = "Update";
            this.Update_Info.UseVisualStyleBackColor = true;
            this.Update_Info.Click += new System.EventHandler(this.Update_Info_Click);
            // 
            // Remove_Info
            // 
            this.Remove_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Remove_Info.Location = new System.Drawing.Point(244, 299);
            this.Remove_Info.Name = "Remove_Info";
            this.Remove_Info.Size = new System.Drawing.Size(90, 38);
            this.Remove_Info.TabIndex = 0;
            this.Remove_Info.Text = "Delete";
            this.Remove_Info.UseVisualStyleBackColor = true;
            this.Remove_Info.Click += new System.EventHandler(this.Remove_Info_Click);
            // 
            // Search_Info
            // 
            this.Search_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_Info.Location = new System.Drawing.Point(148, 343);
            this.Search_Info.Name = "Search_Info";
            this.Search_Info.Size = new System.Drawing.Size(90, 38);
            this.Search_Info.TabIndex = 0;
            this.Search_Info.Text = "Search";
            this.Search_Info.UseVisualStyleBackColor = true;
            this.Search_Info.Click += new System.EventHandler(this.Search_Info_Click);
            // 
            // A
            // 
            this.A.Location = new System.Drawing.Point(183, 271);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(177, 22);
            this.A.TabIndex = 3;
            // 
            // L_06
            // 
            this.L_06.AutoSize = true;
            this.L_06.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_06.Location = new System.Drawing.Point(37, 271);
            this.L_06.Name = "L_06";
            this.L_06.Size = new System.Drawing.Size(78, 20);
            this.L_06.TabIndex = 4;
            this.L_06.Text = "Address";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.L_06);
            this.Controls.Add(this.L_05);
            this.Controls.Add(this.L_04);
            this.Controls.Add(this.L_03);
            this.Controls.Add(this.L_02);
            this.Controls.Add(this.L_01);
            this.Controls.Add(this.A);
            this.Controls.Add(this.CGPA);
            this.Controls.Add(this.S);
            this.Controls.Add(this.D);
            this.Controls.Add(this.N);
            this.Controls.Add(this.RN);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Remove_Info);
            this.Controls.Add(this.Search_Info);
            this.Controls.Add(this.Update_Info);
            this.Controls.Add(this.Add_Info);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add_Info;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox RN;
        private System.Windows.Forms.TextBox N;
        private System.Windows.Forms.TextBox D;
        private System.Windows.Forms.TextBox S;
        private System.Windows.Forms.TextBox CGPA;
        private System.Windows.Forms.Label L_01;
        private System.Windows.Forms.Label L_02;
        private System.Windows.Forms.Label L_03;
        private System.Windows.Forms.Label L_04;
        private System.Windows.Forms.Label L_05;
        private System.Windows.Forms.Button Update_Info;
        private System.Windows.Forms.Button Remove_Info;
        private System.Windows.Forms.Button Search_Info;
        private System.Windows.Forms.TextBox A;
        private System.Windows.Forms.Label L_06;
    }
}

