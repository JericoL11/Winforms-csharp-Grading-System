namespace Int_GradeSystem.AdminForm
{
    partial class AccntRecords
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
            this.btn_recordsBack = new System.Windows.Forms.Button();
            this.dgv_Accounts = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_edit = new System.Windows.Forms.Button();
            this.txt_IDselector = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Accounts)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_recordsBack
            // 
            this.btn_recordsBack.BackColor = System.Drawing.Color.White;
            this.btn_recordsBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_recordsBack.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_recordsBack.Location = new System.Drawing.Point(1353, 344);
            this.btn_recordsBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_recordsBack.Name = "btn_recordsBack";
            this.btn_recordsBack.Size = new System.Drawing.Size(150, 89);
            this.btn_recordsBack.TabIndex = 3;
            this.btn_recordsBack.Text = "Back";
            this.btn_recordsBack.UseVisualStyleBackColor = false;
            this.btn_recordsBack.Click += new System.EventHandler(this.btn_recordsBack_Click);
            // 
            // dgv_Accounts
            // 
            this.dgv_Accounts.AllowUserToAddRows = false;
            this.dgv_Accounts.AllowUserToDeleteRows = false;
            this.dgv_Accounts.AllowUserToResizeColumns = false;
            this.dgv_Accounts.AllowUserToResizeRows = false;
            this.dgv_Accounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Accounts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Accounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Accounts.Location = new System.Drawing.Point(386, 344);
            this.dgv_Accounts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Accounts.Name = "dgv_Accounts";
            this.dgv_Accounts.ReadOnly = true;
            this.dgv_Accounts.RowHeadersWidth = 51;
            this.dgv_Accounts.RowTemplate.Height = 24;
            this.dgv_Accounts.Size = new System.Drawing.Size(915, 531);
            this.dgv_Accounts.TabIndex = 4;
            this.dgv_Accounts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Accounts_CellClick);
            this.dgv_Accounts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Accounts_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(415, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(460, 52);
            this.label1.TabIndex = 6;
            this.label1.Text = "REGISTERED ACCOUNTS";
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_edit.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.Location = new System.Drawing.Point(1353, 673);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(150, 89);
            this.btn_edit.TabIndex = 7;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // txt_IDselector
            // 
            this.txt_IDselector.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IDselector.Location = new System.Drawing.Point(1074, 280);
            this.txt_IDselector.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_IDselector.Name = "txt_IDselector";
            this.txt_IDselector.Size = new System.Drawing.Size(129, 28);
            this.txt_IDselector.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(996, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 40);
            this.label2.TabIndex = 9;
            this.label2.Text = "ID:";
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_refresh.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.Location = new System.Drawing.Point(1353, 457);
            this.btn_refresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(150, 89);
            this.btn_refresh.TabIndex = 1;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_delete.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(1353, 786);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(150, 89);
            this.btn_delete.TabIndex = 10;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // AccntRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.BackgroundImage = global::Int_GradeSystem.Properties.Resources.AccntRecords_FS_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.ControlBox = false;
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_IDselector);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_Accounts);
            this.Controls.Add(this.btn_recordsBack);
            this.Controls.Add(this.btn_refresh);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AccntRecords";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccntRecords";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AccntRecords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Accounts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_recordsBack;
        private System.Windows.Forms.DataGridView dgv_Accounts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.TextBox txt_IDselector;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_delete;
    }
}