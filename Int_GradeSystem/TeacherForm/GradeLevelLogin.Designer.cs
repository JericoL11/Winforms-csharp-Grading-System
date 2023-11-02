namespace Int_GradeSystem.TeacherForm
{
    partial class GradeLevelLogin
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
            this.cmb_GradeLevels = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_enter = new System.Windows.Forms.Button();
            this.pnl_Id = new System.Windows.Forms.Panel();
            this.lbl_teacherID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pnl_Id.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_GradeLevels
            // 
            this.cmb_GradeLevels.ForeColor = System.Drawing.Color.Black;
            this.cmb_GradeLevels.FormattingEnabled = true;
            this.cmb_GradeLevels.Items.AddRange(new object[] {
            "1 - Diamond",
            "2 - Rosal",
            "3 - Earth",
            "4 - Hope",
            "5 - Fourier",
            "6 - Hawking"});
            this.cmb_GradeLevels.Location = new System.Drawing.Point(283, 196);
            this.cmb_GradeLevels.Name = "cmb_GradeLevels";
            this.cmb_GradeLevels.Size = new System.Drawing.Size(134, 24);
            this.cmb_GradeLevels.TabIndex = 64;
            this.cmb_GradeLevels.Text = "1 - Diamond";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(114, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 66;
            this.label3.Text = "Select Grade level";
            // 
            // txt_password
            // 
            this.txt_password.ForeColor = System.Drawing.Color.Black;
            this.txt_password.Location = new System.Drawing.Point(283, 246);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(134, 22);
            this.txt_password.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(119, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 68;
            this.label1.Text = "Pass Code";
            // 
            // btn_enter
            // 
            this.btn_enter.ForeColor = System.Drawing.Color.Black;
            this.btn_enter.Location = new System.Drawing.Point(316, 291);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(81, 30);
            this.btn_enter.TabIndex = 69;
            this.btn_enter.Text = "Enter";
            this.btn_enter.UseVisualStyleBackColor = true;
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click);
            // 
            // pnl_Id
            // 
            this.pnl_Id.Controls.Add(this.lbl_teacherID);
            this.pnl_Id.Controls.Add(this.label2);
            this.pnl_Id.Location = new System.Drawing.Point(96, 78);
            this.pnl_Id.Name = "pnl_Id";
            this.pnl_Id.Size = new System.Drawing.Size(232, 56);
            this.pnl_Id.TabIndex = 71;
            this.pnl_Id.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_Id_Paint);
            // 
            // lbl_teacherID
            // 
            this.lbl_teacherID.AutoSize = true;
            this.lbl_teacherID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_teacherID.Location = new System.Drawing.Point(124, 17);
            this.lbl_teacherID.Name = "lbl_teacherID";
            this.lbl_teacherID.Size = new System.Drawing.Size(21, 20);
            this.lbl_teacherID.TabIndex = 65;
            this.lbl_teacherID.Text = "__";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.Location = new System.Drawing.Point(18, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 64;
            this.label2.Text = "Teacher ID : ";
            // 
            // btn_exit
            // 
            this.btn_exit.ForeColor = System.Drawing.Color.Black;
            this.btn_exit.Location = new System.Drawing.Point(316, 336);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(81, 30);
            this.btn_exit.TabIndex = 72;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel2.Controls.Add(this.pnl_Id);
            this.panel2.Controls.Add(this.btn_exit);
            this.panel2.Controls.Add(this.cmb_GradeLevels);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btn_enter);
            this.panel2.Controls.Add(this.txt_password);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(196, 128);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(687, 466);
            this.panel2.TabIndex = 73;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(460, 16);
            this.label4.TabIndex = 74;
            this.label4.Text = "(ILISI ANG COLOR UG BACKGROUND SA TEACHER FORM PAGE @NIñO)";
            // 
            // GradeLevelLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1155, 712);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GradeLevelLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GradeLevelLogin";
            this.Load += new System.EventHandler(this.GradeLevelLogin_Load);
            this.pnl_Id.ResumeLayout(false);
            this.pnl_Id.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_GradeLevels;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_enter;
        private System.Windows.Forms.Panel pnl_Id;
        private System.Windows.Forms.Label lbl_teacherID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
    }
}