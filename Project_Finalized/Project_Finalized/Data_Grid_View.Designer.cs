namespace Project_Finalized
{
    partial class Data_Grid_View
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
            this.T = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Backward = new System.Windows.Forms.Button();
            this.Forward = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // T
            // 
            this.T.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.T.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T.FormattingEnabled = true;
            this.T.Items.AddRange(new object[] {
            "1. Person",
            "2. Student",
            "3. Advisor",
            "4. Group",
            "5. Project",
            "6. Project Advisor",
            "7. Group Student",
            "8. Group Project",
            "9. Evaluation",
            "10. Group Evaluation"});
            this.T.Location = new System.Drawing.Point(12, 12);
            this.T.Name = "T";
            this.T.Size = new System.Drawing.Size(220, 33);
            this.T.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(238, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(685, 426);
            this.dataGridView1.TabIndex = 1;
            // 
            // Backward
            // 
            this.Backward.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backward.Location = new System.Drawing.Point(12, 403);
            this.Backward.Name = "Backward";
            this.Backward.Size = new System.Drawing.Size(220, 35);
            this.Backward.TabIndex = 2;
            this.Backward.Text = "Go Back";
            this.Backward.UseVisualStyleBackColor = true;
            this.Backward.Click += new System.EventHandler(this.Backward_Click);
            // 
            // Forward
            // 
            this.Forward.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Forward.Location = new System.Drawing.Point(12, 362);
            this.Forward.Name = "Forward";
            this.Forward.Size = new System.Drawing.Size(220, 35);
            this.Forward.TabIndex = 3;
            this.Forward.Text = "Refresh";
            this.Forward.UseVisualStyleBackColor = true;
            this.Forward.Click += new System.EventHandler(this.Forward_Click);
            // 
            // Data_Grid_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 450);
            this.ControlBox = false;
            this.Controls.Add(this.Forward);
            this.Controls.Add(this.Backward);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.T);
            this.Name = "Data_Grid_View";
            this.Text = "Data_Grid_View";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox T;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Backward;
        private System.Windows.Forms.Button Forward;
    }
}