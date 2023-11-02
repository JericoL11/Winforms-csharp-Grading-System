namespace Int_GradeSystem.TeacherForm
{
    partial class Student_List
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
            this.dgv_studentList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.cmb_GradeLevels = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_studentList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_studentList
            // 
            this.dgv_studentList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_studentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_studentList.Location = new System.Drawing.Point(76, 100);
            this.dgv_studentList.Name = "dgv_studentList";
            this.dgv_studentList.ReadOnly = true;
            this.dgv_studentList.RowHeadersWidth = 51;
            this.dgv_studentList.RowTemplate.Height = 24;
            this.dgv_studentList.Size = new System.Drawing.Size(884, 467);
            this.dgv_studentList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(166, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 24);
            this.label1.TabIndex = 66;
            this.label1.Text = "G R A D E L     L E V E L";
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(1010, 589);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(98, 46);
            this.btn_back.TabIndex = 69;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // cmb_GradeLevels
            // 
            this.cmb_GradeLevels.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_GradeLevels.ForeColor = System.Drawing.Color.Black;
            this.cmb_GradeLevels.FormattingEnabled = true;
            this.cmb_GradeLevels.Items.AddRange(new object[] {
            "1 - Diamond",
            "2 - Rosal",
            "3 - Earth",
            "4 - Hope",
            "5 - Fourier",
            "6 - Hawking"});
            this.cmb_GradeLevels.Location = new System.Drawing.Point(418, 52);
            this.cmb_GradeLevels.Name = "cmb_GradeLevels";
            this.cmb_GradeLevels.Size = new System.Drawing.Size(134, 24);
            this.cmb_GradeLevels.TabIndex = 71;
            this.cmb_GradeLevels.Text = "Select -------";
            this.cmb_GradeLevels.SelectedIndexChanged += new System.EventHandler(this.cmb_GradeLevels_SelectedIndexChanged);
            // 
            // Student_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(1137, 665);
            this.Controls.Add(this.cmb_GradeLevels);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_studentList);
            this.Name = "Student_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student_List";
            this.Load += new System.EventHandler(this.Student_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_studentList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_studentList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.ComboBox cmb_GradeLevels;
    }
}