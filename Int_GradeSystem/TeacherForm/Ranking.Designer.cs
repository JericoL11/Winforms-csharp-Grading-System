namespace Int_GradeSystem.TeacherForm
{
    partial class Ranking
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_gradelevel = new System.Windows.Forms.ComboBox();
            this.btn_rakingBack = new System.Windows.Forms.Button();
            this.dgv_ranking = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_Terms = new System.Windows.Forms.ComboBox();
            this.btn_View = new System.Windows.Forms.Button();
            this.lbl_term = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ranking)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(213, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Level";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(480, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Terms";
            // 
            // cmb_gradelevel
            // 
            this.cmb_gradelevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_gradelevel.FormattingEnabled = true;
            this.cmb_gradelevel.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cmb_gradelevel.Location = new System.Drawing.Point(343, 112);
            this.cmb_gradelevel.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_gradelevel.Name = "cmb_gradelevel";
            this.cmb_gradelevel.Size = new System.Drawing.Size(98, 26);
            this.cmb_gradelevel.TabIndex = 5;
            this.cmb_gradelevel.Text = "Select ---";
            this.cmb_gradelevel.SelectedIndexChanged += new System.EventHandler(this.cmb_gradelevel_SelectedIndexChanged);
            // 
            // btn_rakingBack
            // 
            this.btn_rakingBack.ForeColor = System.Drawing.Color.Black;
            this.btn_rakingBack.Location = new System.Drawing.Point(28, 30);
            this.btn_rakingBack.Name = "btn_rakingBack";
            this.btn_rakingBack.Size = new System.Drawing.Size(99, 38);
            this.btn_rakingBack.TabIndex = 8;
            this.btn_rakingBack.Text = "Back";
            this.btn_rakingBack.UseVisualStyleBackColor = true;
            this.btn_rakingBack.Click += new System.EventHandler(this.btn_rakingBack_Click);
            // 
            // dgv_ranking
            // 
            this.dgv_ranking.AllowUserToAddRows = false;
            this.dgv_ranking.AllowUserToDeleteRows = false;
            this.dgv_ranking.AllowUserToResizeColumns = false;
            this.dgv_ranking.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_ranking.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_ranking.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_ranking.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ranking.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_ranking.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_ranking.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgv_ranking.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ranking.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_ranking.ColumnHeadersHeight = 29;
            this.dgv_ranking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_ranking.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_ranking.GridColor = System.Drawing.SystemColors.Control;
            this.dgv_ranking.Location = new System.Drawing.Point(190, 230);
            this.dgv_ranking.MultiSelect = false;
            this.dgv_ranking.Name = "dgv_ranking";
            this.dgv_ranking.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ranking.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_ranking.RowHeadersWidth = 51;
            this.dgv_ranking.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_ranking.RowTemplate.Height = 24;
            this.dgv_ranking.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ranking.Size = new System.Drawing.Size(1041, 398);
            this.dgv_ranking.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(185, 192);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "TOP STUDENTS";
            // 
            // cmb_Terms
            // 
            this.cmb_Terms.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Terms.FormattingEnabled = true;
            this.cmb_Terms.Items.AddRange(new object[] {
            "First Grading",
            "Second Grading",
            "Thrid Grading",
            "Fourth Grading"});
            this.cmb_Terms.Location = new System.Drawing.Point(563, 112);
            this.cmb_Terms.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_Terms.Name = "cmb_Terms";
            this.cmb_Terms.Size = new System.Drawing.Size(99, 26);
            this.cmb_Terms.TabIndex = 12;
            this.cmb_Terms.Text = "Select ---";
            this.cmb_Terms.SelectedIndexChanged += new System.EventHandler(this.cmb_Terms_SelectedIndexChanged);
            // 
            // btn_View
            // 
            this.btn_View.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_View.ForeColor = System.Drawing.Color.Black;
            this.btn_View.Location = new System.Drawing.Point(713, 113);
            this.btn_View.Name = "btn_View";
            this.btn_View.Size = new System.Drawing.Size(99, 29);
            this.btn_View.TabIndex = 14;
            this.btn_View.Text = "View";
            this.btn_View.UseVisualStyleBackColor = true;
            this.btn_View.Click += new System.EventHandler(this.btn_View_Click);
            // 
            // lbl_term
            // 
            this.lbl_term.AutoSize = true;
            this.lbl_term.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_term.ForeColor = System.Drawing.Color.White;
            this.lbl_term.Location = new System.Drawing.Point(339, 158);
            this.lbl_term.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_term.Name = "lbl_term";
            this.lbl_term.Size = new System.Drawing.Size(108, 22);
            this.lbl_term.TabIndex = 15;
            this.lbl_term.Text = "Select Level";
            // 
            // Ranking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(1374, 728);
            this.Controls.Add(this.lbl_term);
            this.Controls.Add(this.btn_View);
            this.Controls.Add(this.cmb_Terms);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_ranking);
            this.Controls.Add(this.btn_rakingBack);
            this.Controls.Add(this.cmb_gradelevel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Ranking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ranking";
            this.Load += new System.EventHandler(this.Ranking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ranking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_gradelevel;
        private System.Windows.Forms.Button btn_rakingBack;
        private System.Windows.Forms.DataGridView dgv_ranking;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_Terms;
        private System.Windows.Forms.Button btn_View;
        private System.Windows.Forms.Label lbl_term;
    }
}