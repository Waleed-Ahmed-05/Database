namespace Project_Finalized
{
    partial class Evaluation_CRUD
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
            this.TM = new System.Windows.Forms.TextBox();
            this.Update = new System.Windows.Forms.Button();
            this.Backward = new System.Windows.Forms.Button();
            this.Create = new System.Windows.Forms.Button();
            this.GID = new System.Windows.Forms.ComboBox();
            this.ED = new System.Windows.Forms.DateTimePicker();
            this.TW = new System.Windows.Forms.TextBox();
            this.NL = new System.Windows.Forms.Label();
            this.TML = new System.Windows.Forms.Label();
            this.EDL = new System.Windows.Forms.Label();
            this.GIDL = new System.Windows.Forms.Label();
            this.TWL = new System.Windows.Forms.Label();
            this.Forward = new System.Windows.Forms.Button();
            this.CB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.N = new System.Windows.Forms.TextBox();
            this.OM = new System.Windows.Forms.TextBox();
            this.OML = new System.Windows.Forms.Label();
            this.EID = new System.Windows.Forms.ComboBox();
            this.EIDL = new System.Windows.Forms.Label();
            this.GID_2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // TM
            // 
            this.TM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TM.Location = new System.Drawing.Point(211, 192);
            this.TM.Name = "TM";
            this.TM.Size = new System.Drawing.Size(344, 30);
            this.TM.TabIndex = 37;
            // 
            // Update
            // 
            this.Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.Location = new System.Drawing.Point(420, 336);
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
            this.Backward.Location = new System.Drawing.Point(211, 336);
            this.Backward.Name = "Backward";
            this.Backward.Size = new System.Drawing.Size(118, 39);
            this.Backward.TabIndex = 33;
            this.Backward.Text = "Go Back";
            this.Backward.UseVisualStyleBackColor = true;
            this.Backward.Click += new System.EventHandler(this.Backward_Click);
            // 
            // Create
            // 
            this.Create.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create.Location = new System.Drawing.Point(420, 336);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(118, 39);
            this.Create.TabIndex = 31;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // GID
            // 
            this.GID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GID.FormattingEnabled = true;
            this.GID.Location = new System.Drawing.Point(211, 117);
            this.GID.Name = "GID";
            this.GID.Size = new System.Drawing.Size(344, 33);
            this.GID.TabIndex = 30;
            // 
            // ED
            // 
            this.ED.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ED.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ED.Location = new System.Drawing.Point(211, 300);
            this.ED.Name = "ED";
            this.ED.Size = new System.Drawing.Size(344, 30);
            this.ED.TabIndex = 29;
            // 
            // TW
            // 
            this.TW.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TW.Location = new System.Drawing.Point(211, 228);
            this.TW.Name = "TW";
            this.TW.Size = new System.Drawing.Size(344, 30);
            this.TW.TabIndex = 25;
            // 
            // NL
            // 
            this.NL.AutoSize = true;
            this.NL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NL.Location = new System.Drawing.Point(12, 159);
            this.NL.Name = "NL";
            this.NL.Size = new System.Drawing.Size(68, 25);
            this.NL.TabIndex = 24;
            this.NL.Text = "Name";
            // 
            // TML
            // 
            this.TML.AutoSize = true;
            this.TML.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TML.Location = new System.Drawing.Point(12, 197);
            this.TML.Name = "TML";
            this.TML.Size = new System.Drawing.Size(126, 25);
            this.TML.TabIndex = 23;
            this.TML.Text = "Total Marks";
            // 
            // EDL
            // 
            this.EDL.AutoSize = true;
            this.EDL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EDL.Location = new System.Drawing.Point(12, 300);
            this.EDL.Name = "EDL";
            this.EDL.Size = new System.Drawing.Size(164, 25);
            this.EDL.TabIndex = 22;
            this.EDL.Text = "Evaluation Date";
            // 
            // GIDL
            // 
            this.GIDL.AutoSize = true;
            this.GIDL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GIDL.Location = new System.Drawing.Point(12, 125);
            this.GIDL.Name = "GIDL";
            this.GIDL.Size = new System.Drawing.Size(98, 25);
            this.GIDL.TabIndex = 21;
            this.GIDL.Text = "Group ID";
            // 
            // TWL
            // 
            this.TWL.AutoSize = true;
            this.TWL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TWL.Location = new System.Drawing.Point(12, 233);
            this.TWL.Name = "TWL";
            this.TWL.Size = new System.Drawing.Size(171, 25);
            this.TWL.TabIndex = 17;
            this.TWL.Text = "Total Weightage";
            // 
            // Forward
            // 
            this.Forward.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Forward.Location = new System.Drawing.Point(437, 8);
            this.Forward.Name = "Forward";
            this.Forward.Size = new System.Drawing.Size(118, 33);
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
            "Update"});
            this.CB.Location = new System.Drawing.Point(310, 8);
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
            // N
            // 
            this.N.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.N.Location = new System.Drawing.Point(211, 156);
            this.N.Name = "N";
            this.N.Size = new System.Drawing.Size(344, 30);
            this.N.TabIndex = 37;
            // 
            // OM
            // 
            this.OM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OM.Location = new System.Drawing.Point(211, 264);
            this.OM.Name = "OM";
            this.OM.Size = new System.Drawing.Size(344, 30);
            this.OM.TabIndex = 39;
            // 
            // OML
            // 
            this.OML.AutoSize = true;
            this.OML.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OML.Location = new System.Drawing.Point(12, 264);
            this.OML.Name = "OML";
            this.OML.Size = new System.Drawing.Size(165, 25);
            this.OML.TabIndex = 38;
            this.OML.Text = "Obtained Marks";
            // 
            // EID
            // 
            this.EID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EID.FormattingEnabled = true;
            this.EID.Location = new System.Drawing.Point(211, 78);
            this.EID.Name = "EID";
            this.EID.Size = new System.Drawing.Size(344, 33);
            this.EID.TabIndex = 41;
            // 
            // EIDL
            // 
            this.EIDL.AutoSize = true;
            this.EIDL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EIDL.Location = new System.Drawing.Point(12, 86);
            this.EIDL.Name = "EIDL";
            this.EIDL.Size = new System.Drawing.Size(140, 25);
            this.EIDL.TabIndex = 40;
            this.EIDL.Text = "Evaluation ID";
            // 
            // GID_2
            // 
            this.GID_2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GID_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GID_2.FormattingEnabled = true;
            this.GID_2.Location = new System.Drawing.Point(211, 117);
            this.GID_2.Name = "GID_2";
            this.GID_2.Size = new System.Drawing.Size(344, 33);
            this.GID_2.TabIndex = 42;
            // 
            // Evaluation_CRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 386);
            this.ControlBox = false;
            this.Controls.Add(this.GID_2);
            this.Controls.Add(this.EID);
            this.Controls.Add(this.EIDL);
            this.Controls.Add(this.OM);
            this.Controls.Add(this.OML);
            this.Controls.Add(this.N);
            this.Controls.Add(this.TM);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Backward);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.GID);
            this.Controls.Add(this.ED);
            this.Controls.Add(this.TW);
            this.Controls.Add(this.NL);
            this.Controls.Add(this.TML);
            this.Controls.Add(this.EDL);
            this.Controls.Add(this.GIDL);
            this.Controls.Add(this.TWL);
            this.Controls.Add(this.Forward);
            this.Controls.Add(this.CB);
            this.Controls.Add(this.label1);
            this.Name = "Evaluation_CRUD";
            this.Text = "Evaluation_CRUD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TM;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Backward;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.ComboBox GID;
        private System.Windows.Forms.DateTimePicker ED;
        private System.Windows.Forms.TextBox TW;
        private System.Windows.Forms.Label NL;
        private System.Windows.Forms.Label TML;
        private System.Windows.Forms.Label EDL;
        private System.Windows.Forms.Label GIDL;
        private System.Windows.Forms.Label TWL;
        private System.Windows.Forms.Button Forward;
        private System.Windows.Forms.ComboBox CB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox N;
        private System.Windows.Forms.TextBox OM;
        private System.Windows.Forms.Label OML;
        private System.Windows.Forms.ComboBox EID;
        private System.Windows.Forms.Label EIDL;
        private System.Windows.Forms.ComboBox GID_2;
    }
}