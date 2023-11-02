namespace Int_GradeSystem.TeacherForm
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
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(89, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 18);
            this.label5.TabIndex = 19;
            this.label5.Text = "Confirm Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(89, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "New Password";
            // 
            // txt_confirmPass
            // 
            this.txt_confirmPass.Location = new System.Drawing.Point(261, 207);
            this.txt_confirmPass.Name = "txt_confirmPass";
            this.txt_confirmPass.Size = new System.Drawing.Size(223, 22);
            this.txt_confirmPass.TabIndex = 2;
            // 
            // txt_newPass
            // 
            this.txt_newPass.Location = new System.Drawing.Point(261, 168);
            this.txt_newPass.Name = "txt_newPass";
            this.txt_newPass.Size = new System.Drawing.Size(223, 22);
            this.txt_newPass.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(89, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 18);
            this.label2.TabIndex = 22;
            this.label2.Text = "Old Password";
            // 
            // txt_oldPass
            // 
            this.txt_oldPass.Location = new System.Drawing.Point(261, 114);
            this.txt_oldPass.Name = "txt_oldPass";
            this.txt_oldPass.Size = new System.Drawing.Size(223, 22);
            this.txt_oldPass.TabIndex = 0;
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.ForeColor = System.Drawing.Color.White;
            this.lbl_ID.Location = new System.Drawing.Point(204, 55);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(62, 18);
            this.lbl_ID.TabIndex = 28;
            this.lbl_ID.Text = "______";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(89, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 18);
            this.label6.TabIndex = 27;
            this.label6.Text = "Teacher ID";
            // 
            // bnt_Cancel
            // 
            this.bnt_Cancel.Location = new System.Drawing.Point(492, 324);
            this.bnt_Cancel.Name = "bnt_Cancel";
            this.bnt_Cancel.Size = new System.Drawing.Size(89, 36);
            this.bnt_Cancel.TabIndex = 5;
            this.bnt_Cancel.Text = "Cancel";
            this.bnt_Cancel.UseVisualStyleBackColor = true;
            this.bnt_Cancel.Click += new System.EventHandler(this.bnt_Cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(492, 276);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(89, 36);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(610, 382);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
    }
}