namespace Int_GradeSystem
{
    partial class Form1
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
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.llnk_AdminForm = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txt_password.Location = new System.Drawing.Point(201, 430);
            this.txt_password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(460, 39);
            this.txt_password.TabIndex = 2;
            this.txt_password.Text = "Password";
            this.txt_password.Enter += new System.EventHandler(this.txt_password_Enter);
            this.txt_password.Leave += new System.EventHandler(this.txt_password_Leave);
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.ForeColor = System.Drawing.Color.Black;
            this.txt_username.Location = new System.Drawing.Point(201, 344);
            this.txt_username.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(460, 39);
            this.txt_username.TabIndex = 1;
            this.txt_username.Text = "Username";
            this.txt_username.TextChanged += new System.EventHandler(this.txt_username_TextChanged);
            this.txt_username.Enter += new System.EventHandler(this.txt_username_Enter);
            this.txt_username.Leave += new System.EventHandler(this.txt_username_Leave);
            // 
            // btn_login
            // 
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_login.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_login.Image = global::Int_GradeSystem.Properties.Resources.Untitled_design;
            this.btn_login.Location = new System.Drawing.Point(353, 527);
            this.btn_login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(159, 49);
            this.btn_login.TabIndex = 3;
            this.btn_login.Text = "&L O G I N";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // llnk_AdminForm
            // 
            this.llnk_AdminForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.llnk_AdminForm.AutoSize = true;
            this.llnk_AdminForm.BackColor = System.Drawing.Color.Transparent;
            this.llnk_AdminForm.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llnk_AdminForm.LinkColor = System.Drawing.Color.MidnightBlue;
            this.llnk_AdminForm.Location = new System.Drawing.Point(490, 922);
            this.llnk_AdminForm.Name = "llnk_AdminForm";
            this.llnk_AdminForm.Size = new System.Drawing.Size(224, 32);
            this.llnk_AdminForm.TabIndex = 0;
            this.llnk_AdminForm.TabStop = true;
            this.llnk_AdminForm.Text = "Sign in as Admin";
            this.llnk_AdminForm.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.llnk_AdminForm.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llnk_AdminForm_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(238, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "TEACHER\'S LOGIN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_exit.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_exit.Image = global::Int_GradeSystem.Properties.Resources.Untitled_design;
            this.btn_exit.Location = new System.Drawing.Point(353, 607);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(159, 49);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "E X I T";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImage = global::Int_GradeSystem.Properties.Resources.Teachers_Form__FS_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.ControlBox = false;
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.llnk_AdminForm);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.txt_password);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.LinkLabel llnk_AdminForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_exit;
    }
}

