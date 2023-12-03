namespace Int_GradeSystem.AdminForm
{
    partial class RegisterTeacherAcc
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
            this.txt_firstname = new System.Windows.Forms.TextBox();
            this.txt_regPassword = new System.Windows.Forms.TextBox();
            this.txt_regConfirmPass = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Register = new System.Windows.Forms.Button();
            this.btn_regTeacherBack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_lastname = new System.Windows.Forms.TextBox();
            this.btn_Show = new System.Windows.Forms.Button();
            this.btn_hide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_firstname
            // 
            this.txt_firstname.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_firstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_firstname.Location = new System.Drawing.Point(253, 228);
            this.txt_firstname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_firstname.Name = "txt_firstname";
            this.txt_firstname.Size = new System.Drawing.Size(258, 26);
            this.txt_firstname.TabIndex = 0;
            this.txt_firstname.TextChanged += new System.EventHandler(this.txt_firstname_TextChanged);
            // 
            // txt_regPassword
            // 
            this.txt_regPassword.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_regPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_regPassword.Location = new System.Drawing.Point(253, 561);
            this.txt_regPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_regPassword.Name = "txt_regPassword";
            this.txt_regPassword.Size = new System.Drawing.Size(258, 26);
            this.txt_regPassword.TabIndex = 4;
            this.txt_regPassword.TextChanged += new System.EventHandler(this.txt_regPassword_TextChanged);
            // 
            // txt_regConfirmPass
            // 
            this.txt_regConfirmPass.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_regConfirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_regConfirmPass.Location = new System.Drawing.Point(253, 667);
            this.txt_regConfirmPass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_regConfirmPass.Name = "txt_regConfirmPass";
            this.txt_regConfirmPass.Size = new System.Drawing.Size(258, 26);
            this.txt_regConfirmPass.TabIndex = 5;
            this.txt_regConfirmPass.TextChanged += new System.EventHandler(this.txt_regConfirmPass_TextChanged);
            // 
            // txt_email
            // 
            this.txt_email.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_email.Location = new System.Drawing.Point(253, 454);
            this.txt_email.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(258, 26);
            this.txt_email.TabIndex = 3;
            this.txt_email.TextChanged += new System.EventHandler(this.txt_email_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(80, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Create Account";
            // 
            // btn_Register
            // 
            this.btn_Register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Register.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Register.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Register.Location = new System.Drawing.Point(916, 561);
            this.btn_Register.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(148, 69);
            this.btn_Register.TabIndex = 6;
            this.btn_Register.Text = "Register";
            this.btn_Register.UseVisualStyleBackColor = false;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // btn_regTeacherBack
            // 
            this.btn_regTeacherBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_regTeacherBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_regTeacherBack.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_regTeacherBack.Location = new System.Drawing.Point(916, 702);
            this.btn_regTeacherBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_regTeacherBack.Name = "btn_regTeacherBack";
            this.btn_regTeacherBack.Size = new System.Drawing.Size(148, 59);
            this.btn_regTeacherBack.TabIndex = 7;
            this.btn_regTeacherBack.Text = "Back";
            this.btn_regTeacherBack.UseVisualStyleBackColor = false;
            this.btn_regTeacherBack.Click += new System.EventHandler(this.btn_regTeacherBack_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(250, 193);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "First name";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(250, 421);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Email";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(250, 526);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Password";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(250, 634);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Confirm Password";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(250, 314);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "Last name";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txt_lastname
            // 
            this.txt_lastname.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_lastname.Location = new System.Drawing.Point(253, 344);
            this.txt_lastname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_lastname.Name = "txt_lastname";
            this.txt_lastname.Size = new System.Drawing.Size(258, 26);
            this.txt_lastname.TabIndex = 1;
            this.txt_lastname.TextChanged += new System.EventHandler(this.txt_lastname_TextChanged);
            // 
            // btn_Show
            // 
            this.btn_Show.BackColor = System.Drawing.Color.Transparent;
            this.btn_Show.BackgroundImage = global::Int_GradeSystem.Properties.Resources.show;
            this.btn_Show.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Show.Location = new System.Drawing.Point(603, 553);
            this.btn_Show.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Show.Name = "btn_Show";
            this.btn_Show.Size = new System.Drawing.Size(26, 25);
            this.btn_Show.TabIndex = 81;
            this.btn_Show.UseVisualStyleBackColor = false;
            this.btn_Show.Click += new System.EventHandler(this.btn_Show_Click);
            // 
            // btn_hide
            // 
            this.btn_hide.BackColor = System.Drawing.Color.Transparent;
            this.btn_hide.BackgroundImage = global::Int_GradeSystem.Properties.Resources.hide;
            this.btn_hide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_hide.Location = new System.Drawing.Point(603, 553);
            this.btn_hide.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_hide.Name = "btn_hide";
            this.btn_hide.Size = new System.Drawing.Size(26, 25);
            this.btn_hide.TabIndex = 82;
            this.btn_hide.UseVisualStyleBackColor = false;
            this.btn_hide.Click += new System.EventHandler(this.btn_hide_Click);
            // 
            // RegisterTeacherAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.BackgroundImage = global::Int_GradeSystem.Properties.Resources.RegisterTeacherAcc_FS_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1455, 878);
            this.Controls.Add(this.btn_Show);
            this.Controls.Add(this.btn_hide);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_lastname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_regTeacherBack);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_regConfirmPass);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_regPassword);
            this.Controls.Add(this.txt_firstname);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RegisterTeacherAcc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterTeacherAcc";
            this.Load += new System.EventHandler(this.RegisterTeacherAcc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_firstname;
        private System.Windows.Forms.TextBox txt_regPassword;
        private System.Windows.Forms.TextBox txt_regConfirmPass;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.Button btn_regTeacherBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_lastname;
        private System.Windows.Forms.Button btn_Show;
        private System.Windows.Forms.Button btn_hide;
    }
}