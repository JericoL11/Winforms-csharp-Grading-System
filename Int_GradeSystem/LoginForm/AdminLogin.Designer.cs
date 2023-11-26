namespace Int_GradeSystem
{
    partial class AdminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogin));
            this.llnk_TeacherForm = new System.Windows.Forms.LinkLabel();
            this.txt_AdminPassword = new System.Windows.Forms.TextBox();
            this.btn_AdminLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_AdminUsername = new System.Windows.Forms.TextBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // llnk_TeacherForm
            // 
            this.llnk_TeacherForm.AutoSize = true;
            this.llnk_TeacherForm.BackColor = System.Drawing.Color.Transparent;
            this.llnk_TeacherForm.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llnk_TeacherForm.LinkColor = System.Drawing.Color.MidnightBlue;
            this.llnk_TeacherForm.Location = new System.Drawing.Point(484, 878);
            this.llnk_TeacherForm.Name = "llnk_TeacherForm";
            this.llnk_TeacherForm.Size = new System.Drawing.Size(246, 32);
            this.llnk_TeacherForm.TabIndex = 0;
            this.llnk_TeacherForm.TabStop = true;
            this.llnk_TeacherForm.Text = "Sign in as Teacher";
            this.llnk_TeacherForm.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.llnk_TeacherForm.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llnk_TeacherForm_LinkClicked);
            // 
            // txt_AdminPassword
            // 
            this.txt_AdminPassword.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AdminPassword.ForeColor = System.Drawing.Color.Black;
            this.txt_AdminPassword.Location = new System.Drawing.Point(258, 445);
            this.txt_AdminPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_AdminPassword.Name = "txt_AdminPassword";
            this.txt_AdminPassword.Size = new System.Drawing.Size(386, 34);
            this.txt_AdminPassword.TabIndex = 2;
            this.txt_AdminPassword.Text = "Password";
            this.txt_AdminPassword.Enter += new System.EventHandler(this.txt_AdminPassword_Enter);
            this.txt_AdminPassword.Leave += new System.EventHandler(this.txt_AdminPassword_Leave);
            // 
            // btn_AdminLogin
            // 
            this.btn_AdminLogin.BackColor = System.Drawing.Color.Transparent;
            this.btn_AdminLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_AdminLogin.BackgroundImage")));
            this.btn_AdminLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_AdminLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AdminLogin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AdminLogin.ForeColor = System.Drawing.Color.Black;
            this.btn_AdminLogin.Location = new System.Drawing.Point(365, 538);
            this.btn_AdminLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AdminLogin.Name = "btn_AdminLogin";
            this.btn_AdminLogin.Size = new System.Drawing.Size(159, 49);
            this.btn_AdminLogin.TabIndex = 3;
            this.btn_AdminLogin.Text = "&L O G I N\r\n";
            this.btn_AdminLogin.UseVisualStyleBackColor = false;
            this.btn_AdminLogin.Click += new System.EventHandler(this.btn_AdminLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(263, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADMIN\'S  LOGIN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_AdminUsername
            // 
            this.txt_AdminUsername.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AdminUsername.ForeColor = System.Drawing.Color.Black;
            this.txt_AdminUsername.Location = new System.Drawing.Point(258, 378);
            this.txt_AdminUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_AdminUsername.Name = "txt_AdminUsername";
            this.txt_AdminUsername.Size = new System.Drawing.Size(386, 34);
            this.txt_AdminUsername.TabIndex = 1;
            this.txt_AdminUsername.Text = "Username";
            this.txt_AdminUsername.TextChanged += new System.EventHandler(this.txt_AdminUsername_TextChanged);
            this.txt_AdminUsername.Enter += new System.EventHandler(this.txt_AdminUsername_Enter);
            this.txt_AdminUsername.Leave += new System.EventHandler(this.txt_AdminUsername_Leave_1);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_exit.BackgroundImage")));
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_exit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.Black;
            this.btn_exit.Location = new System.Drawing.Point(365, 611);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(159, 49);
            this.btn_exit.TabIndex = 5;
            this.btn_exit.Text = "E X I T";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Int_GradeSystem.Properties.Resources.Admin_Login_Form__FS_N;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.ControlBox = false;
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.txt_AdminUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.llnk_TeacherForm);
            this.Controls.Add(this.btn_AdminLogin);
            this.Controls.Add(this.txt_AdminPassword);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AdminLogin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdminLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel llnk_TeacherForm;
        private System.Windows.Forms.TextBox txt_AdminPassword;
        private System.Windows.Forms.Button btn_AdminLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_AdminUsername;
        private System.Windows.Forms.Button btn_exit;
    }
}