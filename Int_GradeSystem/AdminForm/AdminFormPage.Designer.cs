namespace Int_GradeSystem.AdminForm
{
    partial class AdminFormPage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_registerTeacher = new System.Windows.Forms.Button();
            this.btn_View_Accounts = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.btn_View_Accounts);
            this.panel1.Controls.Add(this.btn_Logout);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_registerTeacher);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 667);
            this.panel1.TabIndex = 1;
            // 
            // btn_Logout
            // 
            this.btn_Logout.Location = new System.Drawing.Point(46, 609);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(122, 27);
            this.btn_Logout.TabIndex = 4;
            this.btn_Logout.Text = "Log-out";
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "ADMIN";
            // 
            // btn_registerTeacher
            // 
            this.btn_registerTeacher.Location = new System.Drawing.Point(21, 192);
            this.btn_registerTeacher.Name = "btn_registerTeacher";
            this.btn_registerTeacher.Size = new System.Drawing.Size(163, 83);
            this.btn_registerTeacher.TabIndex = 0;
            this.btn_registerTeacher.Text = "Add Teacher Account";
            this.btn_registerTeacher.UseVisualStyleBackColor = true;
            this.btn_registerTeacher.Click += new System.EventHandler(this.btn_registerTeacher_Click);
            // 
            // btn_View_Accounts
            // 
            this.btn_View_Accounts.Location = new System.Drawing.Point(24, 292);
            this.btn_View_Accounts.Name = "btn_View_Accounts";
            this.btn_View_Accounts.Size = new System.Drawing.Size(163, 83);
            this.btn_View_Accounts.TabIndex = 5;
            this.btn_View_Accounts.Text = "View Account Records";
            this.btn_View_Accounts.UseVisualStyleBackColor = true;
            this.btn_View_Accounts.Click += new System.EventHandler(this.btn_View_Accounts_Click);
            // 
            // AdminFormPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(1137, 664);
            this.Controls.Add(this.panel1);
            this.Name = "AdminFormPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminFormPage";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_registerTeacher;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btn_View_Accounts;
    }
}