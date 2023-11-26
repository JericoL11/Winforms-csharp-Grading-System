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
            this.btn_View_Accounts = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btn_registerTeacher = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_View_Accounts
            // 
            this.btn_View_Accounts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_View_Accounts.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_View_Accounts.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_View_Accounts.Location = new System.Drawing.Point(593, 507);
            this.btn_View_Accounts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_View_Accounts.Name = "btn_View_Accounts";
            this.btn_View_Accounts.Size = new System.Drawing.Size(225, 92);
            this.btn_View_Accounts.TabIndex = 5;
            this.btn_View_Accounts.Text = "View Account Records";
            this.btn_View_Accounts.UseVisualStyleBackColor = false;
            this.btn_View_Accounts.Click += new System.EventHandler(this.btn_View_Accounts_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Logout.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.Location = new System.Drawing.Point(1127, 739);
            this.btn_Logout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(162, 37);
            this.btn_Logout.TabIndex = 4;
            this.btn_Logout.Text = "Log-out";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btn_registerTeacher
            // 
            this.btn_registerTeacher.BackColor = System.Drawing.Color.White;
            this.btn_registerTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_registerTeacher.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registerTeacher.Location = new System.Drawing.Point(1066, 507);
            this.btn_registerTeacher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_registerTeacher.Name = "btn_registerTeacher";
            this.btn_registerTeacher.Size = new System.Drawing.Size(225, 92);
            this.btn_registerTeacher.TabIndex = 0;
            this.btn_registerTeacher.Text = "Add Teacher Account";
            this.btn_registerTeacher.UseVisualStyleBackColor = false;
            this.btn_registerTeacher.Click += new System.EventHandler(this.btn_registerTeacher_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(720, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(471, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "A D M I N      P O R T A L\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AdminFormPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.BackgroundImage = global::Int_GradeSystem.Properties.Resources.AdminFormPage_FS_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.btn_View_Accounts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_registerTeacher);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminFormPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminFormPage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_registerTeacher;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btn_View_Accounts;
        private System.Windows.Forms.Label label1;
    }
}