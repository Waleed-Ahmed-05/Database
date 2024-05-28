namespace Project_Finalized
{
    partial class Project_CRUD
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
            this.Update = new System.Windows.Forms.Button();
            this.Backward = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Create = new System.Windows.Forms.Button();
            this.AD = new System.Windows.Forms.DateTimePicker();
            this.T = new System.Windows.Forms.TextBox();
            this.ADL = new System.Windows.Forms.Label();
            this.TL = new System.Windows.Forms.Label();
            this.Forward = new System.Windows.Forms.Button();
            this.CB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DL = new System.Windows.Forms.Label();
            this.D = new System.Windows.Forms.TextBox();
            this.AR = new System.Windows.Forms.ComboBox();
            this.ARL = new System.Windows.Forms.Label();
            this.AID = new System.Windows.Forms.ComboBox();
            this.AIDL = new System.Windows.Forms.Label();
            this.PID = new System.Windows.Forms.ComboBox();
            this.PIDL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Update
            // 
            this.Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.Location = new System.Drawing.Point(443, 367);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(118, 39);
            this.Update.TabIndex = 34;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Backward
            // 
            this.Backward.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backward.Location = new System.Drawing.Point(211, 367);
            this.Backward.Name = "Backward";
            this.Backward.Size = new System.Drawing.Size(118, 39);
            this.Backward.TabIndex = 33;
            this.Backward.Text = "Go Back";
            this.Backward.UseVisualStyleBackColor = true;
            this.Backward.Click += new System.EventHandler(this.Backward_Click);
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(443, 367);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(118, 39);
            this.Delete.TabIndex = 32;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Create
            // 
            this.Create.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create.Location = new System.Drawing.Point(443, 367);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(118, 39);
            this.Create.TabIndex = 31;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // AD
            // 
            this.AD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.AD.Location = new System.Drawing.Point(211, 331);
            this.AD.Name = "AD";
            this.AD.Size = new System.Drawing.Size(350, 30);
            this.AD.TabIndex = 29;
            // 
            // T
            // 
            this.T.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T.Location = new System.Drawing.Point(211, 179);
            this.T.Name = "T";
            this.T.Size = new System.Drawing.Size(350, 30);
            this.T.TabIndex = 26;
            // 
            // ADL
            // 
            this.ADL.AutoSize = true;
            this.ADL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADL.Location = new System.Drawing.Point(12, 331);
            this.ADL.Name = "ADL";
            this.ADL.Size = new System.Drawing.Size(176, 25);
            this.ADL.TabIndex = 22;
            this.ADL.Text = "Assignment Date";
            // 
            // TL
            // 
            this.TL.AutoSize = true;
            this.TL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TL.Location = new System.Drawing.Point(12, 184);
            this.TL.Name = "TL";
            this.TL.Size = new System.Drawing.Size(54, 25);
            this.TL.TabIndex = 18;
            this.TL.Text = "Title";
            // 
            // Forward
            // 
            this.Forward.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Forward.Location = new System.Drawing.Point(443, 12);
            this.Forward.Name = "Forward";
            this.Forward.Size = new System.Drawing.Size(118, 39);
            this.Forward.TabIndex = 16;
            this.Forward.Text = "Refresh";
            this.Forward.UseVisualStyleBackColor = true;
            this.Forward.Click += new System.EventHandler(this.Forward_Click);
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
            this.CB.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Select what you wanna do:";
            // 
            // DL
            // 
            this.DL.AutoSize = true;
            this.DL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DL.Location = new System.Drawing.Point(12, 215);
            this.DL.Name = "DL";
            this.DL.Size = new System.Drawing.Size(120, 25);
            this.DL.TabIndex = 18;
            this.DL.Text = "Description";
            // 
            // D
            // 
            this.D.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.D.Location = new System.Drawing.Point(211, 215);
            this.D.Multiline = true;
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(350, 110);
            this.D.TabIndex = 26;
            // 
            // AR
            // 
            this.AR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AR.FormattingEnabled = true;
            this.AR.Items.AddRange(new object[] {
            "Main Advisor",
            "Co-Advisor",
            "Industry Advisor"});
            this.AR.Location = new System.Drawing.Point(211, 140);
            this.AR.Name = "AR";
            this.AR.Size = new System.Drawing.Size(350, 33);
            this.AR.TabIndex = 37;
            // 
            // ARL
            // 
            this.ARL.AutoSize = true;
            this.ARL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ARL.Location = new System.Drawing.Point(12, 143);
            this.ARL.Name = "ARL";
            this.ARL.Size = new System.Drawing.Size(134, 25);
            this.ARL.TabIndex = 36;
            this.ARL.Text = "Advisor Role";
            // 
            // AID
            // 
            this.AID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AID.FormattingEnabled = true;
            this.AID.Items.AddRange(new object[] {
            "Main Advisor",
            "Co-Advisor",
            "Industry Advisor"});
            this.AID.Location = new System.Drawing.Point(211, 101);
            this.AID.Name = "AID";
            this.AID.Size = new System.Drawing.Size(350, 33);
            this.AID.TabIndex = 39;
            // 
            // AIDL
            // 
            this.AIDL.AutoSize = true;
            this.AIDL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AIDL.Location = new System.Drawing.Point(12, 104);
            this.AIDL.Name = "AIDL";
            this.AIDL.Size = new System.Drawing.Size(112, 25);
            this.AIDL.TabIndex = 38;
            this.AIDL.Text = "Advisor ID";
            // 
            // PID
            // 
            this.PID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PID.FormattingEnabled = true;
            this.PID.Items.AddRange(new object[] {
            "Main Advisor",
            "Co-Advisor",
            "Industry Advisor"});
            this.PID.Location = new System.Drawing.Point(211, 62);
            this.PID.Name = "PID";
            this.PID.Size = new System.Drawing.Size(350, 33);
            this.PID.TabIndex = 41;
            // 
            // PIDL
            // 
            this.PIDL.AutoSize = true;
            this.PIDL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PIDL.Location = new System.Drawing.Point(12, 65);
            this.PIDL.Name = "PIDL";
            this.PIDL.Size = new System.Drawing.Size(106, 25);
            this.PIDL.TabIndex = 40;
            this.PIDL.Text = "Project ID";
            // 
            // Project_CRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 411);
            this.ControlBox = false;
            this.Controls.Add(this.PID);
            this.Controls.Add(this.PIDL);
            this.Controls.Add(this.AID);
            this.Controls.Add(this.AIDL);
            this.Controls.Add(this.AR);
            this.Controls.Add(this.ARL);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Backward);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.AD);
            this.Controls.Add(this.D);
            this.Controls.Add(this.T);
            this.Controls.Add(this.ADL);
            this.Controls.Add(this.DL);
            this.Controls.Add(this.TL);
            this.Controls.Add(this.Forward);
            this.Controls.Add(this.CB);
            this.Controls.Add(this.label1);
            this.Name = "Project_CRUD";
            this.Text = "Project_CRUD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Backward;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.DateTimePicker AD;
        private System.Windows.Forms.TextBox T;
        private System.Windows.Forms.Label ADL;
        private System.Windows.Forms.Label TL;
        private System.Windows.Forms.Button Forward;
        private System.Windows.Forms.ComboBox CB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DL;
        private System.Windows.Forms.TextBox D;
        private System.Windows.Forms.ComboBox AR;
        private System.Windows.Forms.Label ARL;
        private System.Windows.Forms.ComboBox AID;
        private System.Windows.Forms.Label AIDL;
        private System.Windows.Forms.ComboBox PID;
        private System.Windows.Forms.Label PIDL;
    }
}