namespace Int_GradeSystem.AdminForm
{
    partial class EditProfile
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
            this.components = new System.ComponentModel.Container();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.gb_gender = new System.Windows.Forms.GroupBox();
            this.rbtn_female = new System.Windows.Forms.RadioButton();
            this.rbtn_male = new System.Windows.Forms.RadioButton();
            this.txt_lastName = new System.Windows.Forms.TextBox();
            this.txt_middleName = new System.Windows.Forms.TextBox();
            this.txt_firstName = new System.Windows.Forms.TextBox();
            this.btn_editProfileBack = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_teacherID = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_Age = new System.Windows.Forms.Label();
            this.dtp_bdate = new System.Windows.Forms.DateTimePicker();
            this.txt_phoneNumber = new System.Windows.Forms.TextBox();
            this.timer_Checker = new System.Windows.Forms.Timer(this.components);
            this.pnl_width = new System.Windows.Forms.Panel();
            this.pnl_loading = new System.Windows.Forms.Panel();
            this.btn_changePass = new System.Windows.Forms.Button();
            this.gb_gender.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label7.Location = new System.Drawing.Point(95, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 38;
            this.label7.Text = "Phone No.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label6.Location = new System.Drawing.Point(765, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 37;
            this.label6.Text = "Lastname";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label5.Location = new System.Drawing.Point(438, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 20);
            this.label5.TabIndex = 36;
            this.label5.Text = "Middle Name (Optional)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label4.Location = new System.Drawing.Point(95, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = "Firstname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.label3.Location = new System.Drawing.Point(94, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(273, 31);
            this.label3.TabIndex = 34;
            this.label3.Text = "Basic Information Form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.Location = new System.Drawing.Point(765, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Gender";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.Location = new System.Drawing.Point(456, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Birthdate : (dd/mm/yyyy)";
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(471, 403);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(297, 28);
            this.txt_email.TabIndex = 30;
            // 
            // gb_gender
            // 
            this.gb_gender.Controls.Add(this.rbtn_female);
            this.gb_gender.Controls.Add(this.rbtn_male);
            this.gb_gender.Location = new System.Drawing.Point(751, 338);
            this.gb_gender.Name = "gb_gender";
            this.gb_gender.Size = new System.Drawing.Size(187, 37);
            this.gb_gender.TabIndex = 29;
            this.gb_gender.TabStop = false;
            // 
            // rbtn_female
            // 
            this.rbtn_female.AutoSize = true;
            this.rbtn_female.Location = new System.Drawing.Point(96, 9);
            this.rbtn_female.Name = "rbtn_female";
            this.rbtn_female.Size = new System.Drawing.Size(74, 20);
            this.rbtn_female.TabIndex = 1;
            this.rbtn_female.TabStop = true;
            this.rbtn_female.Text = "Female";
            this.rbtn_female.UseVisualStyleBackColor = true;
            this.rbtn_female.Click += new System.EventHandler(this.rbtn_female_Click);
            // 
            // rbtn_male
            // 
            this.rbtn_male.AutoSize = true;
            this.rbtn_male.Location = new System.Drawing.Point(17, 11);
            this.rbtn_male.Name = "rbtn_male";
            this.rbtn_male.Size = new System.Drawing.Size(58, 20);
            this.rbtn_male.TabIndex = 0;
            this.rbtn_male.TabStop = true;
            this.rbtn_male.Text = "Male";
            this.rbtn_male.UseVisualStyleBackColor = true;
            this.rbtn_male.Click += new System.EventHandler(this.rbtn_male_Click);
            // 
            // txt_lastName
            // 
            this.txt_lastName.Enabled = false;
            this.txt_lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lastName.Location = new System.Drawing.Point(768, 269);
            this.txt_lastName.Name = "txt_lastName";
            this.txt_lastName.Size = new System.Drawing.Size(268, 28);
            this.txt_lastName.TabIndex = 24;
            // 
            // txt_middleName
            // 
            this.txt_middleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_middleName.Location = new System.Drawing.Point(442, 269);
            this.txt_middleName.Name = "txt_middleName";
            this.txt_middleName.Size = new System.Drawing.Size(268, 28);
            this.txt_middleName.TabIndex = 23;
            this.txt_middleName.Enter += new System.EventHandler(this.txt_middleName_Enter);
            this.txt_middleName.Leave += new System.EventHandler(this.txt_middleName_Leave);
            // 
            // txt_firstName
            // 
            this.txt_firstName.Enabled = false;
            this.txt_firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_firstName.Location = new System.Drawing.Point(99, 269);
            this.txt_firstName.Name = "txt_firstName";
            this.txt_firstName.Size = new System.Drawing.Size(268, 28);
            this.txt_firstName.TabIndex = 22;
            // 
            // btn_editProfileBack
            // 
            this.btn_editProfileBack.ForeColor = System.Drawing.Color.Black;
            this.btn_editProfileBack.Location = new System.Drawing.Point(12, 24);
            this.btn_editProfileBack.Name = "btn_editProfileBack";
            this.btn_editProfileBack.Size = new System.Drawing.Size(99, 38);
            this.btn_editProfileBack.TabIndex = 45;
            this.btn_editProfileBack.Text = "Back";
            this.btn_editProfileBack.UseVisualStyleBackColor = true;
            this.btn_editProfileBack.Click += new System.EventHandler(this.btn_editProfileBack_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label11.Location = new System.Drawing.Point(95, 203);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 20);
            this.label11.TabIndex = 47;
            this.label11.Text = "Teacher ID :";
            // 
            // lbl_teacherID
            // 
            this.lbl_teacherID.AutoSize = true;
            this.lbl_teacherID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_teacherID.Location = new System.Drawing.Point(187, 203);
            this.lbl_teacherID.Name = "lbl_teacherID";
            this.lbl_teacherID.Size = new System.Drawing.Size(45, 20);
            this.lbl_teacherID.TabIndex = 48;
            this.lbl_teacherID.Text = "______";
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_save.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_save.Location = new System.Drawing.Point(961, 577);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(146, 58);
            this.btn_save.TabIndex = 49;
            this.btn_save.Text = "SAVE";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label8.Location = new System.Drawing.Point(357, 411);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 20);
            this.label8.TabIndex = 39;
            this.label8.Text = "Email Address";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label12.Location = new System.Drawing.Point(96, 411);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 20);
            this.label12.TabIndex = 50;
            this.label12.Text = "Age: ";
            // 
            // lbl_Age
            // 
            this.lbl_Age.AutoSize = true;
            this.lbl_Age.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Age.ForeColor = System.Drawing.Color.Lime;
            this.lbl_Age.Location = new System.Drawing.Point(142, 411);
            this.lbl_Age.Name = "lbl_Age";
            this.lbl_Age.Size = new System.Drawing.Size(0, 20);
            this.lbl_Age.TabIndex = 51;
            // 
            // dtp_bdate
            // 
            this.dtp_bdate.Location = new System.Drawing.Point(460, 353);
            this.dtp_bdate.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.dtp_bdate.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dtp_bdate.Name = "dtp_bdate";
            this.dtp_bdate.Size = new System.Drawing.Size(233, 22);
            this.dtp_bdate.TabIndex = 52;
            this.dtp_bdate.Leave += new System.EventHandler(this.dtp_bdate_Leave);
            // 
            // txt_phoneNumber
            // 
            this.txt_phoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_phoneNumber.Location = new System.Drawing.Point(99, 353);
            this.txt_phoneNumber.MaxLength = 11;
            this.txt_phoneNumber.Name = "txt_phoneNumber";
            this.txt_phoneNumber.Size = new System.Drawing.Size(268, 28);
            this.txt_phoneNumber.TabIndex = 53;
            this.txt_phoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_phoneNumber_KeyPress);
            // 
            // timer_Checker
            // 
            this.timer_Checker.Interval = 5;
            this.timer_Checker.Tick += new System.EventHandler(this.timer_Checker_Tick);
            // 
            // pnl_width
            // 
            this.pnl_width.BackColor = System.Drawing.Color.White;
            this.pnl_width.Location = new System.Drawing.Point(12, 641);
            this.pnl_width.Name = "pnl_width";
            this.pnl_width.Size = new System.Drawing.Size(201, 11);
            this.pnl_width.TabIndex = 54;
            // 
            // pnl_loading
            // 
            this.pnl_loading.BackColor = System.Drawing.Color.Lime;
            this.pnl_loading.Location = new System.Drawing.Point(12, 624);
            this.pnl_loading.Name = "pnl_loading";
            this.pnl_loading.Size = new System.Drawing.Size(26, 11);
            this.pnl_loading.TabIndex = 56;
            // 
            // btn_changePass
            // 
            this.btn_changePass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_changePass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_changePass.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_changePass.Location = new System.Drawing.Point(99, 478);
            this.btn_changePass.Name = "btn_changePass";
            this.btn_changePass.Size = new System.Drawing.Size(146, 29);
            this.btn_changePass.TabIndex = 57;
            this.btn_changePass.Text = "Change Password";
            this.btn_changePass.UseVisualStyleBackColor = true;
            this.btn_changePass.Click += new System.EventHandler(this.btn_changePass_Click);
            // 
            // EditProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(1137, 664);
            this.Controls.Add(this.btn_changePass);
            this.Controls.Add(this.pnl_loading);
            this.Controls.Add(this.pnl_width);
            this.Controls.Add(this.txt_phoneNumber);
            this.Controls.Add(this.dtp_bdate);
            this.Controls.Add(this.lbl_Age);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.lbl_teacherID);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btn_editProfileBack);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.gb_gender);
            this.Controls.Add(this.txt_lastName);
            this.Controls.Add(this.txt_middleName);
            this.Controls.Add(this.txt_firstName);
            this.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Name = "EditProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditProfile";
            this.Load += new System.EventHandler(this.EditProfile_Load);
            this.gb_gender.ResumeLayout(false);
            this.gb_gender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.GroupBox gb_gender;
        private System.Windows.Forms.RadioButton rbtn_female;
        private System.Windows.Forms.RadioButton rbtn_male;
        private System.Windows.Forms.TextBox txt_lastName;
        private System.Windows.Forms.TextBox txt_middleName;
        private System.Windows.Forms.TextBox txt_firstName;
        private System.Windows.Forms.Button btn_editProfileBack;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbl_teacherID;
        private System.Windows.Forms.Button btn_save;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl_Age;
        private System.Windows.Forms.DateTimePicker dtp_bdate;
        private System.Windows.Forms.TextBox txt_phoneNumber;
        private System.Windows.Forms.Timer timer_Checker;
        private System.Windows.Forms.Panel pnl_width;
        private System.Windows.Forms.Panel pnl_loading;
        private System.Windows.Forms.Button btn_changePass;
    }
}