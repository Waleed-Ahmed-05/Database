namespace Project_Finalized
{
    partial class Student_CRUD
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
            this.label1 = new System.Windows.Forms.Label();
            this.CB = new System.Windows.Forms.ComboBox();
            this.Forward = new System.Windows.Forms.Button();
            this.FNL = new System.Windows.Forms.Label();
            this.LNL = new System.Windows.Forms.Label();
            this.CL = new System.Windows.Forms.Label();
            this.EL = new System.Windows.Forms.Label();
            this.GL = new System.Windows.Forms.Label();
            this.DOBL = new System.Windows.Forms.Label();
            this.RNL = new System.Windows.Forms.Label();
            this.FN = new System.Windows.Forms.TextBox();
            this.LN = new System.Windows.Forms.TextBox();
            this.E = new System.Windows.Forms.TextBox();
            this.DOB = new System.Windows.Forms.DateTimePicker();
            this.G = new System.Windows.Forms.ComboBox();
            this.C = new System.Windows.Forms.TextBox();
            this.Create = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Backward = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.IDL = new System.Windows.Forms.Label();
            this.RNCB = new System.Windows.Forms.ComboBox();
            this.ID = new System.Windows.Forms.ComboBox();
            this.RN = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select what you wanna do:";
            // 
            // CB
            // 
            this.CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB.FormattingEnabled = true;
            this.CB.Items.AddRange(new object[] {
            "Create",
            "Delete",
            "Update"});
            this.CB.Location = new System.Drawing.Point(316, 12);
            this.CB.Name = "CB";
            this.CB.Size = new System.Drawing.Size(121, 33);
            this.CB.TabIndex = 1;
            // 
            // Forward
            // 
            this.Forward.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Forward.Location = new System.Drawing.Point(443, 12);
            this.Forward.Name = "Forward";
            this.Forward.Size = new System.Drawing.Size(118, 39);
            this.Forward.TabIndex = 2;
            this.Forward.Text = "Refresh";
            this.Forward.UseVisualStyleBackColor = true;
            this.Forward.Click += new System.EventHandler(this.Forward_Click);
            // 
            // FNL
            // 
            this.FNL.AutoSize = true;
            this.FNL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FNL.Location = new System.Drawing.Point(12, 143);
            this.FNL.Name = "FNL";
            this.FNL.Size = new System.Drawing.Size(116, 25);
            this.FNL.TabIndex = 3;
            this.FNL.Text = "First Name";
            // 
            // LNL
            // 
            this.LNL.AutoSize = true;
            this.LNL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNL.Location = new System.Drawing.Point(12, 179);
            this.LNL.Name = "LNL";
            this.LNL.Size = new System.Drawing.Size(115, 25);
            this.LNL.TabIndex = 3;
            this.LNL.Text = "Last Name";
            // 
            // CL
            // 
            this.CL.AutoSize = true;
            this.CL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CL.Location = new System.Drawing.Point(12, 251);
            this.CL.Name = "CL";
            this.CL.Size = new System.Drawing.Size(87, 25);
            this.CL.TabIndex = 3;
            this.CL.Text = "Contact";
            // 
            // EL
            // 
            this.EL.AutoSize = true;
            this.EL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EL.Location = new System.Drawing.Point(12, 287);
            this.EL.Name = "EL";
            this.EL.Size = new System.Drawing.Size(73, 25);
            this.EL.TabIndex = 3;
            this.EL.Text = "E-mail";
            // 
            // GL
            // 
            this.GL.AutoSize = true;
            this.GL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GL.Location = new System.Drawing.Point(12, 323);
            this.GL.Name = "GL";
            this.GL.Size = new System.Drawing.Size(83, 25);
            this.GL.TabIndex = 3;
            this.GL.Text = "Gender";
            // 
            // DOBL
            // 
            this.DOBL.AutoSize = true;
            this.DOBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOBL.Location = new System.Drawing.Point(12, 215);
            this.DOBL.Name = "DOBL";
            this.DOBL.Size = new System.Drawing.Size(131, 25);
            this.DOBL.TabIndex = 3;
            this.DOBL.Text = "Date of Birth";
            // 
            // RNL
            // 
            this.RNL.AutoSize = true;
            this.RNL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RNL.Location = new System.Drawing.Point(12, 107);
            this.RNL.Name = "RNL";
            this.RNL.Size = new System.Drawing.Size(159, 25);
            this.RNL.TabIndex = 3;
            this.RNL.Text = "Registration No";
            // 
            // FN
            // 
            this.FN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FN.Location = new System.Drawing.Point(211, 143);
            this.FN.Name = "FN";
            this.FN.Size = new System.Drawing.Size(350, 30);
            this.FN.TabIndex = 4;
            // 
            // LN
            // 
            this.LN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LN.Location = new System.Drawing.Point(211, 179);
            this.LN.Name = "LN";
            this.LN.Size = new System.Drawing.Size(350, 30);
            this.LN.TabIndex = 4;
            // 
            // E
            // 
            this.E.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.E.Location = new System.Drawing.Point(211, 287);
            this.E.Name = "E";
            this.E.Size = new System.Drawing.Size(350, 30);
            this.E.TabIndex = 4;
            // 
            // DOB
            // 
            this.DOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DOB.Location = new System.Drawing.Point(211, 215);
            this.DOB.Name = "DOB";
            this.DOB.Size = new System.Drawing.Size(350, 30);
            this.DOB.TabIndex = 5;
            // 
            // G
            // 
            this.G.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.G.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G.FormattingEnabled = true;
            this.G.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.G.Location = new System.Drawing.Point(211, 323);
            this.G.Name = "G";
            this.G.Size = new System.Drawing.Size(350, 33);
            this.G.TabIndex = 6;
            // 
            // C
            // 
            this.C.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C.Location = new System.Drawing.Point(211, 251);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(350, 30);
            this.C.TabIndex = 4;
            // 
            // Create
            // 
            this.Create.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create.Location = new System.Drawing.Point(443, 362);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(118, 39);
            this.Create.TabIndex = 7;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(443, 362);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(118, 39);
            this.Delete.TabIndex = 8;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Backward
            // 
            this.Backward.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backward.Location = new System.Drawing.Point(211, 362);
            this.Backward.Name = "Backward";
            this.Backward.Size = new System.Drawing.Size(118, 39);
            this.Backward.TabIndex = 9;
            this.Backward.Text = "Go Back";
            this.Backward.UseVisualStyleBackColor = true;
            this.Backward.Click += new System.EventHandler(this.Backward_Click);
            // 
            // Update
            // 
            this.Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.Location = new System.Drawing.Point(443, 362);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(118, 39);
            this.Update.TabIndex = 10;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // IDL
            // 
            this.IDL.AutoSize = true;
            this.IDL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDL.Location = new System.Drawing.Point(12, 65);
            this.IDL.Name = "IDL";
            this.IDL.Size = new System.Drawing.Size(33, 25);
            this.IDL.TabIndex = 3;
            this.IDL.Text = "ID";
            // 
            // RNCB
            // 
            this.RNCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RNCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RNCB.FormattingEnabled = true;
            this.RNCB.Items.AddRange(new object[] {
            "Create",
            "Delete",
            "Update"});
            this.RNCB.Location = new System.Drawing.Point(211, 104);
            this.RNCB.Name = "RNCB";
            this.RNCB.Size = new System.Drawing.Size(350, 33);
            this.RNCB.TabIndex = 11;
            // 
            // ID
            // 
            this.ID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.FormattingEnabled = true;
            this.ID.Items.AddRange(new object[] {
            "Create",
            "Delete",
            "Update"});
            this.ID.Location = new System.Drawing.Point(211, 65);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(350, 33);
            this.ID.TabIndex = 12;
            // 
            // RN
            // 
            this.RN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RN.Location = new System.Drawing.Point(211, 104);
            this.RN.Name = "RN";
            this.RN.Size = new System.Drawing.Size(350, 30);
            this.RN.TabIndex = 13;
            // 
            // Student_CRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 409);
            this.ControlBox = false;
            this.Controls.Add(this.RN);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.RNCB);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Backward);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.G);
            this.Controls.Add(this.DOB);
            this.Controls.Add(this.C);
            this.Controls.Add(this.E);
            this.Controls.Add(this.LN);
            this.Controls.Add(this.FN);
            this.Controls.Add(this.IDL);
            this.Controls.Add(this.RNL);
            this.Controls.Add(this.DOBL);
            this.Controls.Add(this.GL);
            this.Controls.Add(this.EL);
            this.Controls.Add(this.CL);
            this.Controls.Add(this.LNL);
            this.Controls.Add(this.FNL);
            this.Controls.Add(this.Forward);
            this.Controls.Add(this.CB);
            this.Controls.Add(this.label1);
            this.Name = "Student_CRUD";
            this.Text = "Student";
            this.Load += new System.EventHandler(this.Student_CRUD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CB;
        private System.Windows.Forms.Button Forward;
        private System.Windows.Forms.Label FNL;
        private System.Windows.Forms.Label LNL;
        private System.Windows.Forms.Label CL;
        private System.Windows.Forms.Label EL;
        private System.Windows.Forms.Label GL;
        private System.Windows.Forms.Label DOBL;
        private System.Windows.Forms.Label RNL;
        private System.Windows.Forms.TextBox FN;
        private System.Windows.Forms.TextBox LN;
        private System.Windows.Forms.TextBox E;
        private System.Windows.Forms.DateTimePicker DOB;
        private System.Windows.Forms.ComboBox G;
        private System.Windows.Forms.TextBox C;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Backward;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Label IDL;
        private System.Windows.Forms.ComboBox RNCB;
        private System.Windows.Forms.ComboBox ID;
        private System.Windows.Forms.TextBox RN;
    }
}