﻿namespace Int_GradeSystem.TeacherForm
{
    partial class AddStudent
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
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtn_Studfemale = new System.Windows.Forms.RadioButton();
            this.rbtn_Studmale = new System.Windows.Forms.RadioButton();
            this.txt_StudlastName = new System.Windows.Forms.TextBox();
            this.txt_StudmiddleName = new System.Windows.Forms.TextBox();
            this.txt_StudfirstName = new System.Windows.Forms.TextBox();
            this.btn_StudRegister = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_bdate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_teacherID = new System.Windows.Forms.Label();
            this.pnl_id = new System.Windows.Forms.Panel();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.lbl_GradeAndSec = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_age = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.pnl_id.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label8.Location = new System.Drawing.Point(96, 406);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 20);
            this.label8.TabIndex = 55;
            this.label8.Text = "Grade And Section";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label6.Location = new System.Drawing.Point(767, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 53;
            this.label6.Text = "Lastname";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label5.Location = new System.Drawing.Point(440, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 52;
            this.label5.Text = "Middle Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label4.Location = new System.Drawing.Point(96, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 51;
            this.label4.Text = "Firstname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.Location = new System.Drawing.Point(436, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 50;
            this.label2.Text = "Gender";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtn_Studfemale);
            this.groupBox1.Controls.Add(this.rbtn_Studmale);
            this.groupBox1.Location = new System.Drawing.Point(444, 307);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(213, 37);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbtn_Studfemale
            // 
            this.rbtn_Studfemale.AutoSize = true;
            this.rbtn_Studfemale.Location = new System.Drawing.Point(113, 11);
            this.rbtn_Studfemale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtn_Studfemale.Name = "rbtn_Studfemale";
            this.rbtn_Studfemale.Size = new System.Drawing.Size(74, 20);
            this.rbtn_Studfemale.TabIndex = 8;
            this.rbtn_Studfemale.TabStop = true;
            this.rbtn_Studfemale.Text = "Female";
            this.rbtn_Studfemale.UseVisualStyleBackColor = true;
            this.rbtn_Studfemale.Click += new System.EventHandler(this.rbtn_Studfemale_Click);
            // 
            // rbtn_Studmale
            // 
            this.rbtn_Studmale.AutoSize = true;
            this.rbtn_Studmale.Location = new System.Drawing.Point(29, 11);
            this.rbtn_Studmale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtn_Studmale.Name = "rbtn_Studmale";
            this.rbtn_Studmale.Size = new System.Drawing.Size(58, 20);
            this.rbtn_Studmale.TabIndex = 7;
            this.rbtn_Studmale.TabStop = true;
            this.rbtn_Studmale.Text = "Male";
            this.rbtn_Studmale.UseVisualStyleBackColor = true;
            this.rbtn_Studmale.Click += new System.EventHandler(this.rbtn_Studmale_Click);
            // 
            // txt_StudlastName
            // 
            this.txt_StudlastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_StudlastName.Location = new System.Drawing.Point(769, 224);
            this.txt_StudlastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_StudlastName.Name = "txt_StudlastName";
            this.txt_StudlastName.Size = new System.Drawing.Size(268, 28);
            this.txt_StudlastName.TabIndex = 3;
            // 
            // txt_StudmiddleName
            // 
            this.txt_StudmiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_StudmiddleName.Location = new System.Drawing.Point(444, 224);
            this.txt_StudmiddleName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_StudmiddleName.Name = "txt_StudmiddleName";
            this.txt_StudmiddleName.Size = new System.Drawing.Size(268, 28);
            this.txt_StudmiddleName.TabIndex = 2;
            // 
            // txt_StudfirstName
            // 
            this.txt_StudfirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_StudfirstName.Location = new System.Drawing.Point(101, 224);
            this.txt_StudfirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_StudfirstName.Name = "txt_StudfirstName";
            this.txt_StudfirstName.Size = new System.Drawing.Size(268, 28);
            this.txt_StudfirstName.TabIndex = 1;
            // 
            // btn_StudRegister
            // 
            this.btn_StudRegister.ForeColor = System.Drawing.Color.Black;
            this.btn_StudRegister.Location = new System.Drawing.Point(872, 492);
            this.btn_StudRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_StudRegister.Name = "btn_StudRegister";
            this.btn_StudRegister.Size = new System.Drawing.Size(165, 53);
            this.btn_StudRegister.TabIndex = 9;
            this.btn_StudRegister.Text = "Register";
            this.btn_StudRegister.UseVisualStyleBackColor = true;
            this.btn_StudRegister.Click += new System.EventHandler(this.btn_StudRegister_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(94, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 41);
            this.label3.TabIndex = 59;
            this.label3.Text = "NEW STUDENT";
            // 
            // dtp_bdate
            // 
            this.dtp_bdate.Location = new System.Drawing.Point(101, 322);
            this.dtp_bdate.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.dtp_bdate.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtp_bdate.Name = "dtp_bdate";
            this.dtp_bdate.Size = new System.Drawing.Size(233, 22);
            this.dtp_bdate.TabIndex = 5;
            this.dtp_bdate.Enter += new System.EventHandler(this.dtp_bdate_Enter);
            this.dtp_bdate.Leave += new System.EventHandler(this.dtp_bdate_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label9.Location = new System.Drawing.Point(97, 292);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(175, 20);
            this.label9.TabIndex = 61;
            this.label9.Text = "Birthdate : (dd/mm/yyyy)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.Location = new System.Drawing.Point(18, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 64;
            this.label1.Text = "Teacher ID : ";
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
            // pnl_id
            // 
            this.pnl_id.Controls.Add(this.lbl_teacherID);
            this.pnl_id.Controls.Add(this.label1);
            this.pnl_id.Location = new System.Drawing.Point(23, 16);
            this.pnl_id.Name = "pnl_id";
            this.pnl_id.Size = new System.Drawing.Size(232, 56);
            this.pnl_id.TabIndex = 66;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.ForeColor = System.Drawing.Color.Black;
            this.btn_Cancel.Location = new System.Drawing.Point(872, 572);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(165, 53);
            this.btn_Cancel.TabIndex = 10;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // lbl_GradeAndSec
            // 
            this.lbl_GradeAndSec.AutoSize = true;
            this.lbl_GradeAndSec.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GradeAndSec.Location = new System.Drawing.Point(246, 401);
            this.lbl_GradeAndSec.Name = "lbl_GradeAndSec";
            this.lbl_GradeAndSec.Size = new System.Drawing.Size(171, 25);
            this.lbl_GradeAndSec.TabIndex = 69;
            this.lbl_GradeAndSec.Text = "Grade And Section";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label10.Location = new System.Drawing.Point(765, 307);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 20);
            this.label10.TabIndex = 70;
            this.label10.Text = "Age";
            // 
            // lbl_age
            // 
            this.lbl_age.AutoSize = true;
            this.lbl_age.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_age.Location = new System.Drawing.Point(807, 307);
            this.lbl_age.Name = "lbl_age";
            this.lbl_age.Size = new System.Drawing.Size(21, 20);
            this.lbl_age.TabIndex = 71;
            this.lbl_age.Text = "__";
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(1137, 665);
            this.Controls.Add(this.lbl_age);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbl_GradeAndSec);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.pnl_id);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtp_bdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_StudRegister);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_StudlastName);
            this.Controls.Add(this.txt_StudmiddleName);
            this.Controls.Add(this.txt_StudfirstName);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddStudent";
            this.Load += new System.EventHandler(this.AddStudent_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnl_id.ResumeLayout(false);
            this.pnl_id.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtn_Studfemale;
        private System.Windows.Forms.RadioButton rbtn_Studmale;
        private System.Windows.Forms.TextBox txt_StudlastName;
        private System.Windows.Forms.TextBox txt_StudmiddleName;
        private System.Windows.Forms.TextBox txt_StudfirstName;
        private System.Windows.Forms.Button btn_StudRegister;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_bdate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_teacherID;
        private System.Windows.Forms.Panel pnl_id;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label lbl_GradeAndSec;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_age;
    }
}