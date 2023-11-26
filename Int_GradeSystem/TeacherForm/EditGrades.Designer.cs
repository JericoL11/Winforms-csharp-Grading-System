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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.btn_enter = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_passCode = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_studentList)).BeginInit();
            this.pnl_verification.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(510, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Grade Level";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(690, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(619, 35);
            this.label2.TabIndex = 3;
            this.label2.Text = "S T U D E N T      G R A D E S     U P D A T E";
            // 
            // btn_editGradeBack
            // 
            this.btn_editGradeBack.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editGradeBack.ForeColor = System.Drawing.Color.Black;
            this.btn_editGradeBack.Location = new System.Drawing.Point(27, 34);
            this.btn_editGradeBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_editGradeBack.Name = "btn_editGradeBack";
            this.btn_editGradeBack.Size = new System.Drawing.Size(153, 61);
            this.btn_editGradeBack.TabIndex = 9;
            this.btn_editGradeBack.Text = "Back";
            this.btn_editGradeBack.UseVisualStyleBackColor = true;
            this.btn_editGradeBack.Click += new System.EventHandler(this.btn_editGradeBack_Click);
            // 
            // btn_EditGrades
            // 
            this.btn_EditGrades.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_EditGrades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_EditGrades.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_EditGrades.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EditGrades.ForeColor = System.Drawing.Color.Black;
            this.btn_EditGrades.Location = new System.Drawing.Point(1223, 978);
            this.btn_EditGrades.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_EditGrades.Name = "btn_EditGrades";
            this.btn_EditGrades.Size = new System.Drawing.Size(157, 53);
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
            this.dgv_studentList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_studentList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_studentList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgv_studentList.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_studentList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_studentList.ColumnHeadersHeight = 29;
            this.dgv_studentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_studentList.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_studentList.Location = new System.Drawing.Point(275, 342);
            this.dgv_studentList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_studentList.MultiSelect = false;
            this.dgv_studentList.Name = "dgv_studentList";
            this.dgv_studentList.ReadOnly = true;
            this.dgv_studentList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_studentList.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_studentList.RowTemplate.Height = 24;
            this.dgv_studentList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_studentList.Size = new System.Drawing.Size(1371, 536);
            this.dgv_studentList.TabIndex = 10;
            this.dgv_studentList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_studentList_CellClick);
            this.dgv_studentList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_studentList_CellContentClick);
            // 
            // cmb_GradeLevels
            // 
            this.cmb_GradeLevels.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.cmb_GradeLevels.Location = new System.Drawing.Point(731, 200);
            this.cmb_GradeLevels.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_GradeLevels.Name = "cmb_GradeLevels";
            this.cmb_GradeLevels.Size = new System.Drawing.Size(243, 24);
            this.cmb_GradeLevels.TabIndex = 72;
            this.cmb_GradeLevels.Text = "Select -------";
            this.cmb_GradeLevels.SelectedIndexChanged += new System.EventHandler(this.cmb_GradeLevels_SelectedIndexChanged);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Delete.BackColor = System.Drawing.Color.LightCoral;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Delete.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.Color.Black;
            this.btn_Delete.Location = new System.Drawing.Point(1463, 978);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(157, 53);
            this.btn_Delete.TabIndex = 73;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1172, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 27);
            this.label4.TabIndex = 75;
            this.label4.Text = "Student ID: ";
            // 
            // lbl_StudID
            // 
            this.lbl_StudID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_StudID.AutoSize = true;
            this.lbl_StudID.BackColor = System.Drawing.Color.Transparent;
            this.lbl_StudID.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StudID.ForeColor = System.Drawing.Color.White;
            this.lbl_StudID.Location = new System.Drawing.Point(1300, 197);
            this.lbl_StudID.Name = "lbl_StudID";
            this.lbl_StudID.Size = new System.Drawing.Size(38, 26);
            this.lbl_StudID.TabIndex = 76;
            this.lbl_StudID.Text = "__";
            // 
            // pnl_verification
            // 
            this.pnl_verification.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnl_verification.BackColor = System.Drawing.Color.Blue;
            this.pnl_verification.BackgroundImage = global::Int_GradeSystem.Properties.Resources.Untitled_design1;
            this.pnl_verification.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_verification.Controls.Add(this.btn_enter);
            this.pnl_verification.Controls.Add(this.label3);
            this.pnl_verification.Controls.Add(this.txt_passCode);
            this.pnl_verification.Controls.Add(this.btn_cancel);
            this.pnl_verification.Location = new System.Drawing.Point(761, 539);
            this.pnl_verification.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_verification.Name = "pnl_verification";
            this.pnl_verification.Size = new System.Drawing.Size(437, 165);
            this.pnl_verification.TabIndex = 77;
            this.pnl_verification.Visible = false;
            this.pnl_verification.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_verification_Paint);
            // 
            // btn_enter
            // 
            this.btn_enter.BackColor = System.Drawing.Color.White;
            this.btn_enter.ForeColor = System.Drawing.Color.Black;
            this.btn_enter.Location = new System.Drawing.Point(173, 99);
            this.btn_enter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(97, 37);
            this.btn_enter.TabIndex = 82;
            this.btn_enter.Text = "Enter";
            this.btn_enter.UseVisualStyleBackColor = false;
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 25);
            this.label3.TabIndex = 81;
            this.label3.Text = "Passcode";
            // 
            // txt_passCode
            // 
            this.txt_passCode.Location = new System.Drawing.Point(161, 35);
            this.txt_passCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_passCode.Name = "txt_passCode";
            this.txt_passCode.Size = new System.Drawing.Size(214, 22);
            this.txt_passCode.TabIndex = 80;
            this.txt_passCode.TextChanged += new System.EventHandler(this.txt_passCode_TextChanged);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.White;
            this.btn_cancel.ForeColor = System.Drawing.Color.Black;
            this.btn_cancel.Location = new System.Drawing.Point(278, 99);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(97, 37);
            this.btn_cancel.TabIndex = 79;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // EditGrades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.BackgroundImage = global::Int_GradeSystem.Properties.Resources.Edit_Grades__FS_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
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
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EditGrades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditGrades";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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