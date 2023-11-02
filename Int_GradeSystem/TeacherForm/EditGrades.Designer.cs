namespace Int_GradeSystem.TeacherForm
{
    partial class EditGrades
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_editGradeBack = new System.Windows.Forms.Button();
            this.btn_EditGrades = new System.Windows.Forms.Button();
            this.dgv_studentList = new System.Windows.Forms.DataGridView();
            this.cmb_GradeLevels = new System.Windows.Forms.ComboBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_StudID = new System.Windows.Forms.Label();
            this.pnl_verification = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_passCode = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_enter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_studentList)).BeginInit();
            this.pnl_verification.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(194, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Grade Level";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(427, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "STUDENT GRADES UPDATE";
            // 
            // btn_editGradeBack
            // 
            this.btn_editGradeBack.ForeColor = System.Drawing.Color.Black;
            this.btn_editGradeBack.Location = new System.Drawing.Point(26, 35);
            this.btn_editGradeBack.Name = "btn_editGradeBack";
            this.btn_editGradeBack.Size = new System.Drawing.Size(99, 38);
            this.btn_editGradeBack.TabIndex = 9;
            this.btn_editGradeBack.Text = "Back";
            this.btn_editGradeBack.UseVisualStyleBackColor = true;
            this.btn_editGradeBack.Click += new System.EventHandler(this.btn_editGradeBack_Click);
            // 
            // btn_EditGrades
            // 
            this.btn_EditGrades.BackColor = System.Drawing.Color.White;
            this.btn_EditGrades.ForeColor = System.Drawing.Color.Black;
            this.btn_EditGrades.Location = new System.Drawing.Point(685, 537);
            this.btn_EditGrades.Name = "btn_EditGrades";
            this.btn_EditGrades.Size = new System.Drawing.Size(105, 50);
            this.btn_EditGrades.TabIndex = 1;
            this.btn_EditGrades.Text = "Edit";
            this.btn_EditGrades.UseVisualStyleBackColor = false;
            this.btn_EditGrades.Click += new System.EventHandler(this.btn_EditGrades_Click);
            // 
            // dgv_studentList
            // 
            this.dgv_studentList.AllowUserToAddRows = false;
            this.dgv_studentList.AllowUserToDeleteRows = false;
            this.dgv_studentList.AllowUserToResizeColumns = false;
            this.dgv_studentList.AllowUserToResizeRows = false;
            this.dgv_studentList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_studentList.BackgroundColor = System.Drawing.Color.White;
            this.dgv_studentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_studentList.Location = new System.Drawing.Point(96, 146);
            this.dgv_studentList.Name = "dgv_studentList";
            this.dgv_studentList.ReadOnly = true;
            this.dgv_studentList.RowHeadersWidth = 51;
            this.dgv_studentList.RowTemplate.Height = 24;
            this.dgv_studentList.Size = new System.Drawing.Size(862, 362);
            this.dgv_studentList.TabIndex = 10;
            this.dgv_studentList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_studentList_CellClick);
            // 
            // cmb_GradeLevels
            // 
            this.cmb_GradeLevels.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_GradeLevels.ForeColor = System.Drawing.Color.Black;
            this.cmb_GradeLevels.FormattingEnabled = true;
            this.cmb_GradeLevels.Items.AddRange(new object[] {
            "1 - Diamond",
            "2 - Rosal",
            "3 - Earth",
            "4 - Hope",
            "5 - Fourier",
            "6 - Hawking"});
            this.cmb_GradeLevels.Location = new System.Drawing.Point(395, 103);
            this.cmb_GradeLevels.Name = "cmb_GradeLevels";
            this.cmb_GradeLevels.Size = new System.Drawing.Size(134, 24);
            this.cmb_GradeLevels.TabIndex = 72;
            this.cmb_GradeLevels.Text = "Select -------";
            this.cmb_GradeLevels.SelectedIndexChanged += new System.EventHandler(this.cmb_GradeLevels_SelectedIndexChanged);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.White;
            this.btn_Delete.ForeColor = System.Drawing.Color.Black;
            this.btn_Delete.Location = new System.Drawing.Point(811, 537);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(105, 50);
            this.btn_Delete.TabIndex = 73;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(695, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 22);
            this.label4.TabIndex = 75;
            this.label4.Text = "Student ID: ";
            // 
            // lbl_StudID
            // 
            this.lbl_StudID.AutoSize = true;
            this.lbl_StudID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StudID.ForeColor = System.Drawing.Color.White;
            this.lbl_StudID.Location = new System.Drawing.Point(812, 101);
            this.lbl_StudID.Name = "lbl_StudID";
            this.lbl_StudID.Size = new System.Drawing.Size(32, 22);
            this.lbl_StudID.TabIndex = 76;
            this.lbl_StudID.Text = "__";
            // 
            // pnl_verification
            // 
            this.pnl_verification.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_verification.BackColor = System.Drawing.Color.Blue;
            this.pnl_verification.Controls.Add(this.btn_enter);
            this.pnl_verification.Controls.Add(this.label3);
            this.pnl_verification.Controls.Add(this.txt_passCode);
            this.pnl_verification.Controls.Add(this.btn_cancel);
            this.pnl_verification.Location = new System.Drawing.Point(344, 251);
            this.pnl_verification.Name = "pnl_verification";
            this.pnl_verification.Size = new System.Drawing.Size(361, 148);
            this.pnl_verification.TabIndex = 77;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(22, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 22);
            this.label3.TabIndex = 81;
            this.label3.Text = "Passcode";
            // 
            // txt_passCode
            // 
            this.txt_passCode.Location = new System.Drawing.Point(151, 35);
            this.txt_passCode.Name = "txt_passCode";
            this.txt_passCode.Size = new System.Drawing.Size(186, 22);
            this.txt_passCode.TabIndex = 80;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.White;
            this.btn_cancel.ForeColor = System.Drawing.Color.Black;
            this.btn_cancel.Location = new System.Drawing.Point(256, 86);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(92, 33);
            this.btn_cancel.TabIndex = 79;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_enter
            // 
            this.btn_enter.BackColor = System.Drawing.Color.White;
            this.btn_enter.ForeColor = System.Drawing.Color.Black;
            this.btn_enter.Location = new System.Drawing.Point(151, 86);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(92, 33);
            this.btn_enter.TabIndex = 82;
            this.btn_enter.Text = "Enter";
            this.btn_enter.UseVisualStyleBackColor = false;
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click);
            // 
            // EditGrades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(1137, 664);
            this.Controls.Add(this.pnl_verification);
            this.Controls.Add(this.lbl_StudID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.cmb_GradeLevels);
            this.Controls.Add(this.dgv_studentList);
            this.Controls.Add(this.btn_EditGrades);
            this.Controls.Add(this.btn_editGradeBack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "EditGrades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditGrades";
            this.Load += new System.EventHandler(this.EditGrades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_studentList)).EndInit();
            this.pnl_verification.ResumeLayout(false);
            this.pnl_verification.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_editGradeBack;
        private System.Windows.Forms.Button btn_EditGrades;
        private System.Windows.Forms.DataGridView dgv_studentList;
        private System.Windows.Forms.ComboBox cmb_GradeLevels;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_StudID;
        private System.Windows.Forms.Panel pnl_verification;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_passCode;
        private System.Windows.Forms.Button btn_enter;
    }
}