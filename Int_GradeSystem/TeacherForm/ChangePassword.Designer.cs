﻿namespace Int_GradeSystem.TeacherForm
{
    partial class ChangePassword
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_confirmPass = new System.Windows.Forms.TextBox();
            this.txt_newPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_oldPass = new System.Windows.Forms.TextBox();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bnt_Cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_Show = new System.Windows.Forms.Button();
            this.btn_hide = new System.Windows.Forms.Button();
            this.btn_show_new = new System.Windows.Forms.Button();
            this.btn_hide_new = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(486, 487);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 23);
            this.label5.TabIndex = 19;
            this.label5.Text = "Confirm Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(486, 441);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 23);
            this.label4.TabIndex = 18;
            this.label4.Text = "New Password";
            // 
            // txt_confirmPass
            // 
            this.txt_confirmPass.Font = new System.Drawing.Font("Arial", 12F);
            this.txt_confirmPass.Location = new System.Drawing.Point(709, 487);
            this.txt_confirmPass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_confirmPass.Name = "txt_confirmPass";
            this.txt_confirmPass.Size = new System.Drawing.Size(246, 26);
            this.txt_confirmPass.TabIndex = 2;
            // 
            // txt_newPass
            // 
            this.txt_newPass.Font = new System.Drawing.Font("Arial", 12F);
            this.txt_newPass.Location = new System.Drawing.Point(709, 443);
            this.txt_newPass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_newPass.Name = "txt_newPass";
            this.txt_newPass.Size = new System.Drawing.Size(246, 26);
            this.txt_newPass.TabIndex = 1;
            this.txt_newPass.TextChanged += new System.EventHandler(this.txt_newPass_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(486, 396);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 23);
            this.label2.TabIndex = 22;
            this.label2.Text = "Old Password";
            // 
            // txt_oldPass
            // 
            this.txt_oldPass.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_oldPass.Location = new System.Drawing.Point(709, 396);
            this.txt_oldPass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_oldPass.Name = "txt_oldPass";
            this.txt_oldPass.Size = new System.Drawing.Size(246, 26);
            this.txt_oldPass.TabIndex = 0;
            this.txt_oldPass.TextChanged += new System.EventHandler(this.txt_oldPass_TextChanged);
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ID.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold);
            this.lbl_ID.ForeColor = System.Drawing.Color.White;
            this.lbl_ID.Location = new System.Drawing.Point(524, 284);
            this.lbl_ID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(64, 23);
            this.lbl_ID.TabIndex = 28;
            this.lbl_ID.Text = "______";
            this.lbl_ID.Click += new System.EventHandler(this.lbl_ID_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(424, 286);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 23);
            this.label6.TabIndex = 27;
            this.label6.Text = "Teacher ID";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // bnt_Cancel
            // 
            this.bnt_Cancel.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_Cancel.Location = new System.Drawing.Point(479, 565);
            this.bnt_Cancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bnt_Cancel.Name = "bnt_Cancel";
            this.bnt_Cancel.Size = new System.Drawing.Size(77, 37);
            this.bnt_Cancel.TabIndex = 5;
            this.bnt_Cancel.Text = "Cancel";
            this.bnt_Cancel.UseVisualStyleBackColor = true;
            this.bnt_Cancel.Click += new System.EventHandler(this.bnt_Cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(876, 565);
            this.btn_save.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(77, 37);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_Show
            // 
            this.btn_Show.BackColor = System.Drawing.Color.Transparent;
            this.btn_Show.BackgroundImage = global::Int_GradeSystem.Properties.Resources.show;
            this.btn_Show.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Show.Location = new System.Drawing.Point(930, 396);
            this.btn_Show.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Show.Name = "btn_Show";
            this.btn_Show.Size = new System.Drawing.Size(28, 26);
            this.btn_Show.TabIndex = 29;
            this.btn_Show.UseVisualStyleBackColor = false;
            this.btn_Show.Click += new System.EventHandler(this.btn_Show_Click);
            // 
            // btn_hide
            // 
            this.btn_hide.BackColor = System.Drawing.Color.Transparent;
            this.btn_hide.BackgroundImage = global::Int_GradeSystem.Properties.Resources.hide;
            this.btn_hide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_hide.Location = new System.Drawing.Point(930, 396);
            this.btn_hide.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_hide.Name = "btn_hide";
            this.btn_hide.Size = new System.Drawing.Size(28, 26);
            this.btn_hide.TabIndex = 30;
            this.btn_hide.UseVisualStyleBackColor = false;
            this.btn_hide.Click += new System.EventHandler(this.btn_hide_Click);
            // 
            // btn_show_new
            // 
            this.btn_show_new.BackColor = System.Drawing.Color.Transparent;
            this.btn_show_new.BackgroundImage = global::Int_GradeSystem.Properties.Resources.show;
            this.btn_show_new.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_show_new.Location = new System.Drawing.Point(930, 442);
            this.btn_show_new.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_show_new.Name = "btn_show_new";
            this.btn_show_new.Size = new System.Drawing.Size(28, 26);
            this.btn_show_new.TabIndex = 31;
            this.btn_show_new.UseVisualStyleBackColor = false;
            this.btn_show_new.Click += new System.EventHandler(this.btn_show_new_Click);
            // 
            // btn_hide_new
            // 
            this.btn_hide_new.BackColor = System.Drawing.Color.Transparent;
            this.btn_hide_new.BackgroundImage = global::Int_GradeSystem.Properties.Resources.hide;
            this.btn_hide_new.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_hide_new.Location = new System.Drawing.Point(930, 442);
            this.btn_hide_new.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_hide_new.Name = "btn_hide_new";
            this.btn_hide_new.Size = new System.Drawing.Size(28, 26);
            this.btn_hide_new.TabIndex = 32;
            this.btn_hide_new.UseVisualStyleBackColor = false;
            this.btn_hide_new.Click += new System.EventHandler(this.btn_hide_new_Click);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.BackgroundImage = global::Int_GradeSystem.Properties.Resources.Change_Password__FS_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1440, 878);
            this.Controls.Add(this.btn_show_new);
            this.Controls.Add(this.btn_hide_new);
            this.Controls.Add(this.btn_Show);
            this.Controls.Add(this.btn_hide);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.bnt_Cancel);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_oldPass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_confirmPass);
            this.Controls.Add(this.txt_newPass);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ChangePassword";
            this.Load += new System.EventHandler(this.ChangePassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_confirmPass;
        private System.Windows.Forms.TextBox txt_newPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_oldPass;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bnt_Cancel;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_Show;
        private System.Windows.Forms.Button btn_hide;
        private System.Windows.Forms.Button btn_show_new;
        private System.Windows.Forms.Button btn_hide_new;
    }
}