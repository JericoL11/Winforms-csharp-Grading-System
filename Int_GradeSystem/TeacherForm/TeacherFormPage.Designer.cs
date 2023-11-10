namespace Int_GradeSystem.TeacherForm
{
    partial class TeacherFormPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherFormPage));
            this.btn_Ranking = new System.Windows.Forms.Button();
            this.btn_editProfile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_editGrades = new System.Windows.Forms.Button();
            this.btn_AdStudents = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_fullName = new System.Windows.Forms.Label();
            this.btn_ViewStudents = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Ranking
            // 
            this.btn_Ranking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Ranking.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Ranking.Location = new System.Drawing.Point(546, 327);
            this.btn_Ranking.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Ranking.Name = "btn_Ranking";
            this.btn_Ranking.Size = new System.Drawing.Size(163, 82);
            this.btn_Ranking.TabIndex = 5;
            this.btn_Ranking.Text = "View Ranking";
            this.btn_Ranking.UseVisualStyleBackColor = false;
            this.btn_Ranking.Click += new System.EventHandler(this.btn_Ranking_Click);
            // 
            // btn_editProfile
            // 
            this.btn_editProfile.BackColor = System.Drawing.Color.LightGray;
            this.btn_editProfile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_editProfile.Location = new System.Drawing.Point(284, 257);
            this.btn_editProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_editProfile.Name = "btn_editProfile";
            this.btn_editProfile.Size = new System.Drawing.Size(123, 27);
            this.btn_editProfile.TabIndex = 4;
            this.btn_editProfile.Text = "Edit Profile";
            this.btn_editProfile.UseVisualStyleBackColor = false;
            this.btn_editProfile.Click += new System.EventHandler(this.btn_editProfile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(401, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "T E A C H E R     P O R T A L";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_editGrades
            // 
            this.btn_editGrades.BackColor = System.Drawing.Color.Snow;
            this.btn_editGrades.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_editGrades.Location = new System.Drawing.Point(361, 327);
            this.btn_editGrades.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_editGrades.Name = "btn_editGrades";
            this.btn_editGrades.Size = new System.Drawing.Size(163, 82);
            this.btn_editGrades.TabIndex = 1;
            this.btn_editGrades.Text = "Edit Grades";
            this.btn_editGrades.UseVisualStyleBackColor = false;
            this.btn_editGrades.Click += new System.EventHandler(this.btn_editGrades_Click);
            // 
            // btn_AdStudents
            // 
            this.btn_AdStudents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_AdStudents.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AdStudents.Location = new System.Drawing.Point(170, 327);
            this.btn_AdStudents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AdStudents.Name = "btn_AdStudents";
            this.btn_AdStudents.Size = new System.Drawing.Size(163, 82);
            this.btn_AdStudents.TabIndex = 0;
            this.btn_AdStudents.Text = "Add Students";
            this.btn_AdStudents.UseVisualStyleBackColor = false;
            this.btn_AdStudents.Click += new System.EventHandler(this.btn_AdStudents_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_logout.Location = new System.Drawing.Point(757, 467);
            this.btn_logout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(117, 32);
            this.btn_logout.TabIndex = 6;
            this.btn_logout.Text = "&Log-out";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(22, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 27);
            this.label2.TabIndex = 7;
            this.label2.Text = "Good day, ";
            // 
            // lbl_fullName
            // 
            this.lbl_fullName.AutoSize = true;
            this.lbl_fullName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_fullName.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fullName.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_fullName.Location = new System.Drawing.Point(154, 22);
            this.lbl_fullName.Name = "lbl_fullName";
            this.lbl_fullName.Size = new System.Drawing.Size(116, 27);
            this.lbl_fullName.TabIndex = 8;
            this.lbl_fullName.Text = "________";
            // 
            // btn_ViewStudents
            // 
            this.btn_ViewStudents.BackColor = System.Drawing.Color.Snow;
            this.btn_ViewStudents.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ViewStudents.Location = new System.Drawing.Point(728, 327);
            this.btn_ViewStudents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ViewStudents.Name = "btn_ViewStudents";
            this.btn_ViewStudents.Size = new System.Drawing.Size(163, 82);
            this.btn_ViewStudents.TabIndex = 9;
            this.btn_ViewStudents.Text = "View Students";
            this.btn_ViewStudents.UseVisualStyleBackColor = false;
            this.btn_ViewStudents.Click += new System.EventHandler(this.btn_ViewStudents_Click);
            // 
            // TeacherFormPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1137, 665);
            this.Controls.Add(this.btn_ViewStudents);
            this.Controls.Add(this.lbl_fullName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_Ranking);
            this.Controls.Add(this.btn_editProfile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_AdStudents);
            this.Controls.Add(this.btn_editGrades);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TeacherFormPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeacherFormPage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TeacherFormPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_editProfile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_editGrades;
        private System.Windows.Forms.Button btn_AdStudents;
        private System.Windows.Forms.Button btn_Ranking;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_fullName;
        private System.Windows.Forms.Button btn_ViewStudents;
    }
}