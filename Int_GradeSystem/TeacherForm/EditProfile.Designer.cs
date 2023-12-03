﻿namespace Int_GradeSystem.AdminForm
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
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(395, 439);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 20);
            this.label7.TabIndex = 38;
            this.label7.Text = "Phone No.";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(941, 326);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 37;
            this.label6.Text = "Lastname";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(662, 327);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 20);
            this.label5.TabIndex = 36;
            this.label5.Text = "Middle Name (Optional)";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(395, 329);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = "Firstname";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(600, 191);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(380, 40);
            this.label3.TabIndex = 34;
            this.label3.Text = "Basic Information Form";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(393, 544);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Gender";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(662, 439);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Birthdate : (dd/mm/yyyy)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_email
            // 
            this.txt_email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(662, 579);
            this.txt_email.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(176, 24);
            this.txt_email.TabIndex = 30;
            this.txt_email.TextChanged += new System.EventHandler(this.txt_email_TextChanged);
            // 
            // gb_gender
            // 
            this.gb_gender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gb_gender.BackColor = System.Drawing.Color.Transparent;
            this.gb_gender.Controls.Add(this.rbtn_female);
            this.gb_gender.Controls.Add(this.rbtn_male);
            this.gb_gender.Location = new System.Drawing.Point(394, 575);
            this.gb_gender.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gb_gender.Name = "gb_gender";
            this.gb_gender.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gb_gender.Size = new System.Drawing.Size(146, 32);
            this.gb_gender.TabIndex = 29;
            this.gb_gender.TabStop = false;
            this.gb_gender.Enter += new System.EventHandler(this.gb_gender_Enter);
            // 
            // rbtn_female
            // 
            this.rbtn_female.AutoSize = true;
            this.rbtn_female.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_female.Location = new System.Drawing.Point(72, 7);
            this.rbtn_female.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtn_female.Name = "rbtn_female";
            this.rbtn_female.Size = new System.Drawing.Size(72, 21);
            this.rbtn_female.TabIndex = 1;
            this.rbtn_female.TabStop = true;
            this.rbtn_female.Text = "Female";
            this.rbtn_female.UseVisualStyleBackColor = true;
            this.rbtn_female.CheckedChanged += new System.EventHandler(this.rbtn_female_CheckedChanged);
            this.rbtn_female.Click += new System.EventHandler(this.rbtn_female_Click);
            // 
            // rbtn_male
            // 
            this.rbtn_male.AutoSize = true;
            this.rbtn_male.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_male.Location = new System.Drawing.Point(13, 9);
            this.rbtn_male.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtn_male.Name = "rbtn_male";
            this.rbtn_male.Size = new System.Drawing.Size(56, 21);
            this.rbtn_male.TabIndex = 0;
            this.rbtn_male.TabStop = true;
            this.rbtn_male.Text = "Male";
            this.rbtn_male.UseVisualStyleBackColor = true;
            this.rbtn_male.CheckedChanged += new System.EventHandler(this.rbtn_male_CheckedChanged);
            this.rbtn_male.Click += new System.EventHandler(this.rbtn_male_Click);
            // 
            // txt_lastName
            // 
            this.txt_lastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_lastName.Enabled = false;
            this.txt_lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lastName.Location = new System.Drawing.Point(941, 358);
            this.txt_lastName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_lastName.Name = "txt_lastName";
            this.txt_lastName.Size = new System.Drawing.Size(156, 24);
            this.txt_lastName.TabIndex = 24;
            this.txt_lastName.TextChanged += new System.EventHandler(this.txt_lastName_TextChanged);
            // 
            // txt_middleName
            // 
            this.txt_middleName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_middleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_middleName.Location = new System.Drawing.Point(662, 360);
            this.txt_middleName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_middleName.Name = "txt_middleName";
            this.txt_middleName.Size = new System.Drawing.Size(176, 24);
            this.txt_middleName.TabIndex = 23;
            this.txt_middleName.TextChanged += new System.EventHandler(this.txt_middleName_TextChanged);
            this.txt_middleName.Enter += new System.EventHandler(this.txt_middleName_Enter);
            this.txt_middleName.Leave += new System.EventHandler(this.txt_middleName_Leave);
            // 
            // txt_firstName
            // 
            this.txt_firstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_firstName.Enabled = false;
            this.txt_firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_firstName.Location = new System.Drawing.Point(396, 362);
            this.txt_firstName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_firstName.Name = "txt_firstName";
            this.txt_firstName.Size = new System.Drawing.Size(163, 24);
            this.txt_firstName.TabIndex = 22;
            this.txt_firstName.TextChanged += new System.EventHandler(this.txt_firstName_TextChanged);
            // 
            // btn_editProfileBack
            // 
            this.btn_editProfileBack.BackColor = System.Drawing.Color.White;
            this.btn_editProfileBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_editProfileBack.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editProfileBack.ForeColor = System.Drawing.Color.Black;
            this.btn_editProfileBack.Location = new System.Drawing.Point(50, 41);
            this.btn_editProfileBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_editProfileBack.Name = "btn_editProfileBack";
            this.btn_editProfileBack.Size = new System.Drawing.Size(90, 46);
            this.btn_editProfileBack.TabIndex = 45;
            this.btn_editProfileBack.Text = "Back";
            this.btn_editProfileBack.UseVisualStyleBackColor = false;
            this.btn_editProfileBack.Click += new System.EventHandler(this.btn_editProfileBack_Click);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(350, 253);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 20);
            this.label11.TabIndex = 47;
            this.label11.Text = "Teacher ID :";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // lbl_teacherID
            // 
            this.lbl_teacherID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_teacherID.AutoSize = true;
            this.lbl_teacherID.BackColor = System.Drawing.Color.Transparent;
            this.lbl_teacherID.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_teacherID.Location = new System.Drawing.Point(426, 251);
            this.lbl_teacherID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_teacherID.Name = "lbl_teacherID";
            this.lbl_teacherID.Size = new System.Drawing.Size(45, 20);
            this.lbl_teacherID.TabIndex = 48;
            this.lbl_teacherID.Text = "______";
            this.lbl_teacherID.Click += new System.EventHandler(this.lbl_teacherID_Click);
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_save.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_save.Location = new System.Drawing.Point(1084, 778);
            this.btn_save.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(120, 46);
            this.btn_save.TabIndex = 49;
            this.btn_save.Text = "SAVE";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(662, 544);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 20);
            this.label8.TabIndex = 39;
            this.label8.Text = "Email Address";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(941, 439);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 20);
            this.label12.TabIndex = 50;
            this.label12.Text = "Age: ";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // lbl_Age
            // 
            this.lbl_Age.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Age.AutoSize = true;
            this.lbl_Age.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Age.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Age.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_Age.Location = new System.Drawing.Point(990, 473);
            this.lbl_Age.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Age.Name = "lbl_Age";
            this.lbl_Age.Size = new System.Drawing.Size(18, 19);
            this.lbl_Age.TabIndex = 51;
            this.lbl_Age.Text = "_";
            this.lbl_Age.Click += new System.EventHandler(this.lbl_Age_Click);
            // 
            // dtp_bdate
            // 
            this.dtp_bdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp_bdate.CalendarFont = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_bdate.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_bdate.Location = new System.Drawing.Point(662, 470);
            this.dtp_bdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtp_bdate.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.dtp_bdate.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dtp_bdate.Name = "dtp_bdate";
            this.dtp_bdate.Size = new System.Drawing.Size(218, 24);
            this.dtp_bdate.TabIndex = 52;
            this.dtp_bdate.ValueChanged += new System.EventHandler(this.dtp_bdate_ValueChanged);
            this.dtp_bdate.Leave += new System.EventHandler(this.dtp_bdate_Leave);
            // 
            // txt_phoneNumber
            // 
            this.txt_phoneNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_phoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_phoneNumber.Location = new System.Drawing.Point(396, 470);
            this.txt_phoneNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_phoneNumber.MaxLength = 11;
            this.txt_phoneNumber.Name = "txt_phoneNumber";
            this.txt_phoneNumber.Size = new System.Drawing.Size(163, 24);
            this.txt_phoneNumber.TabIndex = 53;
            this.txt_phoneNumber.TextChanged += new System.EventHandler(this.txt_phoneNumber_TextChanged);
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
            this.pnl_width.Location = new System.Drawing.Point(50, 824);
            this.pnl_width.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnl_width.Name = "pnl_width";
            this.pnl_width.Size = new System.Drawing.Size(300, 27);
            this.pnl_width.TabIndex = 54;
            this.pnl_width.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_width_Paint);
            // 
            // pnl_loading
            // 
            this.pnl_loading.BackColor = System.Drawing.Color.Lime;
            this.pnl_loading.Location = new System.Drawing.Point(50, 796);
            this.pnl_loading.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnl_loading.Name = "pnl_loading";
            this.pnl_loading.Size = new System.Drawing.Size(170, 27);
            this.pnl_loading.TabIndex = 56;
            this.pnl_loading.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_loading_Paint);
            // 
            // btn_changePass
            // 
            this.btn_changePass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_changePass.BackColor = System.Drawing.Color.White;
            this.btn_changePass.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_changePass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_changePass.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_changePass.Location = new System.Drawing.Point(941, 575);
            this.btn_changePass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_changePass.Name = "btn_changePass";
            this.btn_changePass.Size = new System.Drawing.Size(110, 24);
            this.btn_changePass.TabIndex = 57;
            this.btn_changePass.Text = "Change Password";
            this.btn_changePass.UseVisualStyleBackColor = false;
            this.btn_changePass.Click += new System.EventHandler(this.btn_changePass_Click);
            // 
            // EditProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.BackgroundImage = global::Int_GradeSystem.Properties.Resources.Edit_Profile__FS_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1440, 878);
            this.ControlBox = false;
            this.Controls.Add(this.btn_changePass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_editProfileBack);
            this.Controls.Add(this.pnl_loading);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_firstName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pnl_width);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_middleName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_phoneNumber);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_lastName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtp_bdate);
            this.Controls.Add(this.lbl_teacherID);
            this.Controls.Add(this.gb_gender);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_Age);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label12);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
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