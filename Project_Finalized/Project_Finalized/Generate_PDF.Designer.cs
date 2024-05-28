namespace Project_Finalized
{
    partial class Generate_PDF
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
            this.Backward = new System.Windows.Forms.Button();
            this.Forward = new System.Windows.Forms.Button();
            this.GIDL = new System.Windows.Forms.Label();
            this.GID = new System.Windows.Forms.ComboBox();
            this.CB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Backward
            // 
            this.Backward.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backward.Location = new System.Drawing.Point(402, 60);
            this.Backward.Name = "Backward";
            this.Backward.Size = new System.Drawing.Size(128, 33);
            this.Backward.TabIndex = 0;
            this.Backward.Text = "Go Back";
            this.Backward.UseVisualStyleBackColor = true;
            this.Backward.Click += new System.EventHandler(this.Backward_Click);
            // 
            // Forward
            // 
            this.Forward.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Forward.Location = new System.Drawing.Point(620, 60);
            this.Forward.Name = "Forward";
            this.Forward.Size = new System.Drawing.Size(128, 33);
            this.Forward.TabIndex = 1;
            this.Forward.Text = "Generate";
            this.Forward.UseVisualStyleBackColor = true;
            this.Forward.Click += new System.EventHandler(this.Forward_Click);
            // 
            // GIDL
            // 
            this.GIDL.AutoSize = true;
            this.GIDL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GIDL.Location = new System.Drawing.Point(25, 64);
            this.GIDL.Name = "GIDL";
            this.GIDL.Size = new System.Drawing.Size(98, 25);
            this.GIDL.TabIndex = 2;
            this.GIDL.Text = "Group ID";
            // 
            // GID
            // 
            this.GID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GID.FormattingEnabled = true;
            this.GID.Location = new System.Drawing.Point(138, 64);
            this.GID.Name = "GID";
            this.GID.Size = new System.Drawing.Size(146, 33);
            this.GID.TabIndex = 3;
            // 
            // CB
            // 
            this.CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB.FormattingEnabled = true;
            this.CB.Items.AddRange(new object[] {
            "Project Details",
            "Evaluation Report",
            "Evaluation Report & Project Details"});
            this.CB.Location = new System.Drawing.Point(402, 13);
            this.CB.Name = "CB";
            this.CB.Size = new System.Drawing.Size(346, 33);
            this.CB.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Select what you wanna generate:";
            // 
            // Generate_PDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 110);
            this.ControlBox = false;
            this.Controls.Add(this.CB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GID);
            this.Controls.Add(this.GIDL);
            this.Controls.Add(this.Forward);
            this.Controls.Add(this.Backward);
            this.Name = "Generate_PDF";
            this.Text = "Generate_PDF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Backward;
        private System.Windows.Forms.Button Forward;
        private System.Windows.Forms.Label GIDL;
        private System.Windows.Forms.ComboBox GID;
        private System.Windows.Forms.ComboBox CB;
        private System.Windows.Forms.Label label1;
    }
}