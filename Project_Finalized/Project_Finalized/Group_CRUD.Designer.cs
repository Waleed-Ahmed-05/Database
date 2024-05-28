namespace Project_Finalized
{
    partial class Group_CRUD
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
            this.GID = new System.Windows.Forms.ComboBox();
            this.GIDL = new System.Windows.Forms.Label();
            this.Backward = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Create = new System.Windows.Forms.Button();
            this.AD = new System.Windows.Forms.DateTimePicker();
            this.ADL = new System.Windows.Forms.Label();
            this.SL = new System.Windows.Forms.Label();
            this.Forward = new System.Windows.Forms.Button();
            this.CB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SID = new System.Windows.Forms.ComboBox();
            this.SIDL = new System.Windows.Forms.Label();
            this.S = new System.Windows.Forms.ComboBox();
            this.CO = new System.Windows.Forms.DateTimePicker();
            this.COL = new System.Windows.Forms.Label();
            this.SID_2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // GID
            // 
            this.GID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GID.FormattingEnabled = true;
            this.GID.Items.AddRange(new object[] {
            "Main Advisor",
            "Co-Advisor",
            "Industry Advisor"});
            this.GID.Location = new System.Drawing.Point(211, 62);
            this.GID.Name = "GID";
            this.GID.Size = new System.Drawing.Size(350, 33);
            this.GID.TabIndex = 60;
            // 
            // GIDL
            // 
            this.GIDL.AutoSize = true;
            this.GIDL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GIDL.Location = new System.Drawing.Point(12, 65);
            this.GIDL.Name = "GIDL";
            this.GIDL.Size = new System.Drawing.Size(98, 25);
            this.GIDL.TabIndex = 59;
            this.GIDL.Text = "Group ID";
            // 
            // Backward
            // 
            this.Backward.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backward.Location = new System.Drawing.Point(211, 251);
            this.Backward.Name = "Backward";
            this.Backward.Size = new System.Drawing.Size(118, 39);
            this.Backward.TabIndex = 53;
            this.Backward.Text = "Go Back";
            this.Backward.UseVisualStyleBackColor = true;
            this.Backward.Click += new System.EventHandler(this.Backward_Click);
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(443, 251);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(118, 39);
            this.Delete.TabIndex = 52;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Create
            // 
            this.Create.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create.Location = new System.Drawing.Point(443, 251);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(118, 39);
            this.Create.TabIndex = 51;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // AD
            // 
            this.AD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.AD.Location = new System.Drawing.Point(211, 179);
            this.AD.Name = "AD";
            this.AD.Size = new System.Drawing.Size(350, 30);
            this.AD.TabIndex = 50;
            // 
            // ADL
            // 
            this.ADL.AutoSize = true;
            this.ADL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADL.Location = new System.Drawing.Point(12, 179);
            this.ADL.Name = "ADL";
            this.ADL.Size = new System.Drawing.Size(176, 25);
            this.ADL.TabIndex = 47;
            this.ADL.Text = "Assignment Date";
            // 
            // SL
            // 
            this.SL.AutoSize = true;
            this.SL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SL.Location = new System.Drawing.Point(12, 140);
            this.SL.Name = "SL";
            this.SL.Size = new System.Drawing.Size(74, 25);
            this.SL.TabIndex = 45;
            this.SL.Text = "Status";
            // 
            // Forward
            // 
            this.Forward.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Forward.Location = new System.Drawing.Point(443, 12);
            this.Forward.Name = "Forward";
            this.Forward.Size = new System.Drawing.Size(118, 39);
            this.Forward.TabIndex = 44;
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
            "Delete"});
            this.CB.Location = new System.Drawing.Point(316, 12);
            this.CB.Name = "CB";
            this.CB.Size = new System.Drawing.Size(121, 33);
            this.CB.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 25);
            this.label1.TabIndex = 42;
            this.label1.Text = "Select what you wanna do:";
            // 
            // SID
            // 
            this.SID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SID.FormattingEnabled = true;
            this.SID.Items.AddRange(new object[] {
            "Main Advisor",
            "Co-Advisor",
            "Industry Advisor"});
            this.SID.Location = new System.Drawing.Point(211, 101);
            this.SID.Name = "SID";
            this.SID.Size = new System.Drawing.Size(350, 33);
            this.SID.TabIndex = 62;
            // 
            // SIDL
            // 
            this.SIDL.AutoSize = true;
            this.SIDL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SIDL.Location = new System.Drawing.Point(12, 101);
            this.SIDL.Name = "SIDL";
            this.SIDL.Size = new System.Drawing.Size(114, 25);
            this.SIDL.TabIndex = 61;
            this.SIDL.Text = "Student ID";
            // 
            // S
            // 
            this.S.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.S.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.S.FormattingEnabled = true;
            this.S.Items.AddRange(new object[] {
            "Active",
            "InActive"});
            this.S.Location = new System.Drawing.Point(211, 140);
            this.S.Name = "S";
            this.S.Size = new System.Drawing.Size(350, 33);
            this.S.TabIndex = 63;
            // 
            // CO
            // 
            this.CO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CO.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.CO.Location = new System.Drawing.Point(211, 215);
            this.CO.Name = "CO";
            this.CO.Size = new System.Drawing.Size(350, 30);
            this.CO.TabIndex = 65;
            // 
            // COL
            // 
            this.COL.AutoSize = true;
            this.COL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COL.Location = new System.Drawing.Point(12, 215);
            this.COL.Name = "COL";
            this.COL.Size = new System.Drawing.Size(124, 25);
            this.COL.TabIndex = 64;
            this.COL.Text = "Created On\r\n";
            // 
            // SID_2
            // 
            this.SID_2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SID_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SID_2.FormattingEnabled = true;
            this.SID_2.Location = new System.Drawing.Point(211, 101);
            this.SID_2.Name = "SID_2";
            this.SID_2.Size = new System.Drawing.Size(350, 33);
            this.SID_2.TabIndex = 66;
            // 
            // Group_CRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 301);
            this.ControlBox = false;
            this.Controls.Add(this.SID_2);
            this.Controls.Add(this.CO);
            this.Controls.Add(this.COL);
            this.Controls.Add(this.S);
            this.Controls.Add(this.SID);
            this.Controls.Add(this.SIDL);
            this.Controls.Add(this.GID);
            this.Controls.Add(this.GIDL);
            this.Controls.Add(this.Backward);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.AD);
            this.Controls.Add(this.ADL);
            this.Controls.Add(this.SL);
            this.Controls.Add(this.Forward);
            this.Controls.Add(this.CB);
            this.Controls.Add(this.label1);
            this.Name = "Group_CRUD";
            this.Text = "Group_CRUD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox GID;
        private System.Windows.Forms.Label GIDL;
        private System.Windows.Forms.Button Backward;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.DateTimePicker AD;
        private System.Windows.Forms.Label ADL;
        private System.Windows.Forms.Label SL;
        private System.Windows.Forms.Button Forward;
        private System.Windows.Forms.ComboBox CB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SID;
        private System.Windows.Forms.Label SIDL;
        private System.Windows.Forms.ComboBox S;
        private System.Windows.Forms.DateTimePicker CO;
        private System.Windows.Forms.Label COL;
        private System.Windows.Forms.ComboBox SID_2;
    }
}