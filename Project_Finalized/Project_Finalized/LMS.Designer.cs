namespace Project_Finalized
{
    partial class LMS
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
            this.DGV = new System.Windows.Forms.Button();
            this.Terminate = new System.Windows.Forms.Button();
            this.S = new System.Windows.Forms.Button();
            this.A = new System.Windows.Forms.Button();
            this.P = new System.Windows.Forms.Button();
            this.G = new System.Windows.Forms.Button();
            this.GP = new System.Windows.Forms.Button();
            this.E = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DGV
            // 
            this.DGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGV.Location = new System.Drawing.Point(339, 12);
            this.DGV.Name = "DGV";
            this.DGV.Size = new System.Drawing.Size(94, 69);
            this.DGV.TabIndex = 0;
            this.DGV.Text = "View Data";
            this.DGV.UseVisualStyleBackColor = true;
            this.DGV.Click += new System.EventHandler(this.DGV_Click);
            // 
            // Terminate
            // 
            this.Terminate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Terminate.Location = new System.Drawing.Point(694, 395);
            this.Terminate.Name = "Terminate";
            this.Terminate.Size = new System.Drawing.Size(94, 43);
            this.Terminate.TabIndex = 1;
            this.Terminate.Text = "Exit";
            this.Terminate.UseVisualStyleBackColor = true;
            this.Terminate.Click += new System.EventHandler(this.Terminate_Click);
            // 
            // S
            // 
            this.S.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.S.Location = new System.Drawing.Point(81, 96);
            this.S.Name = "S";
            this.S.Size = new System.Drawing.Size(115, 69);
            this.S.TabIndex = 2;
            this.S.Text = "Student CRUD";
            this.S.UseVisualStyleBackColor = true;
            this.S.Click += new System.EventHandler(this.S_Click);
            // 
            // A
            // 
            this.A.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A.Location = new System.Drawing.Point(331, 96);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(115, 69);
            this.A.TabIndex = 3;
            this.A.Text = "Advisor CRUD";
            this.A.UseVisualStyleBackColor = true;
            this.A.Click += new System.EventHandler(this.A_Click);
            // 
            // P
            // 
            this.P.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P.Location = new System.Drawing.Point(594, 96);
            this.P.Name = "P";
            this.P.Size = new System.Drawing.Size(115, 69);
            this.P.TabIndex = 4;
            this.P.Text = "Project CRUD";
            this.P.UseVisualStyleBackColor = true;
            this.P.Click += new System.EventHandler(this.P_Click);
            // 
            // G
            // 
            this.G.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G.Location = new System.Drawing.Point(204, 171);
            this.G.Name = "G";
            this.G.Size = new System.Drawing.Size(115, 69);
            this.G.TabIndex = 5;
            this.G.Text = "Group CRUD";
            this.G.UseVisualStyleBackColor = true;
            this.G.Click += new System.EventHandler(this.G_Click);
            // 
            // GP
            // 
            this.GP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GP.Location = new System.Drawing.Point(459, 171);
            this.GP.Name = "GP";
            this.GP.Size = new System.Drawing.Size(126, 69);
            this.GP.TabIndex = 6;
            this.GP.Text = "Group Project";
            this.GP.UseVisualStyleBackColor = true;
            this.GP.Click += new System.EventHandler(this.GP_Click);
            // 
            // E
            // 
            this.E.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.E.Location = new System.Drawing.Point(321, 252);
            this.E.Name = "E";
            this.E.Size = new System.Drawing.Size(140, 69);
            this.E.TabIndex = 7;
            this.E.Text = "Evaluation CRUD";
            this.E.UseVisualStyleBackColor = true;
            this.E.Click += new System.EventHandler(this.E_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(321, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 69);
            this.button1.TabIndex = 8;
            this.button1.Text = "Generate PDF";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.E);
            this.Controls.Add(this.GP);
            this.Controls.Add(this.G);
            this.Controls.Add(this.P);
            this.Controls.Add(this.A);
            this.Controls.Add(this.S);
            this.Controls.Add(this.Terminate);
            this.Controls.Add(this.DGV);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LMS";
            this.ShowIcon = false;
            this.Text = "LMS";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DGV;
        private System.Windows.Forms.Button Terminate;
        private System.Windows.Forms.Button S;
        private System.Windows.Forms.Button A;
        private System.Windows.Forms.Button P;
        private System.Windows.Forms.Button G;
        private System.Windows.Forms.Button GP;
        private System.Windows.Forms.Button E;
        private System.Windows.Forms.Button button1;
    }
}