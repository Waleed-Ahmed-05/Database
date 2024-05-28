namespace Project_Finalized
{
    partial class Group_Project
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
            this.PID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AD = new System.Windows.Forms.DateTimePicker();
            this.Backward = new System.Windows.Forms.Button();
            this.Forward = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GID
            // 
            this.GID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GID.FormattingEnabled = true;
            this.GID.Items.AddRange(new object[] {
            "Main Advisor",
            "Co-Advisor",
            "Industry Advisor"});
            this.GID.Location = new System.Drawing.Point(211, 6);
            this.GID.Name = "GID";
            this.GID.Size = new System.Drawing.Size(226, 33);
            this.GID.TabIndex = 62;
            // 
            // GIDL
            // 
            this.GIDL.AutoSize = true;
            this.GIDL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GIDL.Location = new System.Drawing.Point(12, 9);
            this.GIDL.Name = "GIDL";
            this.GIDL.Size = new System.Drawing.Size(98, 25);
            this.GIDL.TabIndex = 61;
            this.GIDL.Text = "Group ID";
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
            this.PID.Location = new System.Drawing.Point(211, 45);
            this.PID.Name = "PID";
            this.PID.Size = new System.Drawing.Size(226, 33);
            this.PID.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 63;
            this.label1.Text = "Project ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 25);
            this.label2.TabIndex = 65;
            this.label2.Text = "Assignment Date";
            // 
            // AD
            // 
            this.AD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.AD.Location = new System.Drawing.Point(211, 84);
            this.AD.Name = "AD";
            this.AD.Size = new System.Drawing.Size(226, 30);
            this.AD.TabIndex = 66;
            // 
            // Backward
            // 
            this.Backward.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backward.Location = new System.Drawing.Point(17, 124);
            this.Backward.Name = "Backward";
            this.Backward.Size = new System.Drawing.Size(120, 40);
            this.Backward.TabIndex = 67;
            this.Backward.Text = "Go Back";
            this.Backward.UseVisualStyleBackColor = true;
            this.Backward.Click += new System.EventHandler(this.Backward_Click);
            // 
            // Forward
            // 
            this.Forward.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Forward.Location = new System.Drawing.Point(329, 124);
            this.Forward.Name = "Forward";
            this.Forward.Size = new System.Drawing.Size(108, 40);
            this.Forward.TabIndex = 68;
            this.Forward.Text = "Create";
            this.Forward.UseVisualStyleBackColor = true;
            this.Forward.Click += new System.EventHandler(this.Forward_Click);
            // 
            // Group_Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 170);
            this.ControlBox = false;
            this.Controls.Add(this.Forward);
            this.Controls.Add(this.Backward);
            this.Controls.Add(this.AD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GID);
            this.Controls.Add(this.GIDL);
            this.Name = "Group_Project";
            this.Text = "Group_Project";
            this.Load += new System.EventHandler(this.Group_Project_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox GID;
        private System.Windows.Forms.Label GIDL;
        private System.Windows.Forms.ComboBox PID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker AD;
        private System.Windows.Forms.Button Backward;
        private System.Windows.Forms.Button Forward;
    }
}