using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Int_GradeSystem.AdminForm
{
    public partial class AccntRecords : Form
    {
        public AccntRecords()
        {
            InitializeComponent();
        }
        //DATABASE
        DataClasses1DataContext data = new DataClasses1DataContext();

        //ErrorClass
        MessageAlert alert= new MessageAlert();

        //stored variable for Selected ID
        public string SelectedID { get; set; } = string.Empty;

      
        private void AccntRecords_Load(object sender, EventArgs e)
        {
            ViewReload();
        }

        private void btn_recordsBack_Click(object sender, EventArgs e)
        {
            AdminFormPage af = new AdminFormPage();
            this.Close();
            af.Show();
        }

       
        private void btn_edit_Click(object sender, EventArgs e)
        {
            var Database = data.tbl_TeacherAccs
                            .FirstOrDefault(t => t.teacherId.ToString() == txt_IDselector.Text);

            //condition if found, proceed store procedure method
            if(Database != null)
            {
   
                //assigning of data to UpdatePassword variables
                UpdatePassoword Upd = new UpdatePassoword();
                Upd.ID = Database.teacherId.ToString();
                Upd.firstname = Database.firstname;
                Upd.lastname = Database.lastname;
                Upd.email = Database.email;
                Upd.ShowDialog();

            }
            else
            {
                alert.id_Notfound();
            }
        }
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            ViewReload();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

            //checking the database if the ID is available
            var Database = data.tbl_TeacherAccs
                .FirstOrDefault(t => t.teacherId.ToString() == txt_IDselector.Text);


            //for information - assigning of information from database tbl_TeacherInfos
            var database_Info = data.tbl_TeacherInfos
                                .FirstOrDefault(i => i.FK_teacherId == int.Parse(txt_IDselector.Text));


            if (string.IsNullOrEmpty(txt_IDselector.Text))
            {
                alert.Select_ID();
            }
            else if(Database != null && database_Info != null)
            {
                switch (SelectedID)
                {
                    case null:
                        alert.Select_ID();
                        break;

                    default:

                        //Notifying the user for final decision
                        var ResultDialog = MessageBox.Show($"Do you want to delete the selected ID \"{SelectedID}\" ?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (ResultDialog == DialogResult.Yes)
                        {
                            //Stored Procedure Function
                            data.SP_adm_DeleteAccountBothTables(int.Parse(txt_IDselector.Text));
                            ViewReload();
                        }
                        else
                        {
                            break;
                        }
                        break;
                }
            }

            //with existing data from another table
            else if (Database != null && database_Info == null)
            {
                switch (SelectedID)
                {
                    case null:
                        alert.Select_ID();
                        break;

                    default:

                        //Notifying the user for final decision
                        var ResultDialog = MessageBox.Show($"Do you want to delete the selected ID \"{SelectedID}\" ?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (ResultDialog == DialogResult.Yes)
                        {
                            //Stored Procedure Function
                            data.SP_adm_DeleteAccount(int.Parse(txt_IDselector.Text));
                          
                            ViewReload();
                        }
                        else
                        {
                            break;
                        }
                        break;
                }
            }
            else
            {
                alert.id_Notfound();
            }
        }

        #region==  VIEW RELOADER function ==
        public void ViewReload()
        {
            dgv_Accounts.DataSource = data.SP_View_TeacherAcc();
            txt_IDselector.Clear();
        }
        #endregion


        private void dgv_Accounts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        //EVENT HANDLER FOR THE Clickable cell
        private void dgv_Accounts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
           
            if (e.ColumnIndex == 0 && e.RowIndex >= 0 || e.ColumnIndex == 1 && e.RowIndex >= 0 ||
                e.ColumnIndex == 2 && e.RowIndex >= 0 || e.ColumnIndex == 3 && e.RowIndex >= 0 ||
                e.ColumnIndex == 4 && e.RowIndex >= 0 || e.ColumnIndex == 5 && e.RowIndex >= 0)
            {
                // Handle the click action for the clickable cells
                string clickedValue = dgv_Accounts.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_IDselector.Text = clickedValue;

                //assigning of local variable
                SelectedID = clickedValue;
            }
            else
            {
                alert.Invalid_Selection();
            }
        }

   
    }
}

