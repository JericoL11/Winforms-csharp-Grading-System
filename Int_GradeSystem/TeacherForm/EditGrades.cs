using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Int_GradeSystem.TeacherForm
{
    public partial class EditGrades : Form
    {
        //database instantiation
        DataClasses1DataContext data = new DataClasses1DataContext();

        MessageAlert alert = new MessageAlert();

        // reciever of userID from Teacher's home page
        public string ID { get; set; }

        //NUllable Student ID property
        public int? SelectedID { get; set; }


        //NUllable Student Grade holder
        public int? gradelevel { get; set; }

        public string section { get; set; }


        //passcode 
        public string Passcode { get; set; }

        private Timer refreshTimer;
        public EditGrades()
        {
            InitializeComponent();

            //fix screen flickering
            this.DoubleBuffered = true;

        }

        //for enablign controls
        void FormControlsEnabled()
        {
            //enabling background controls
            btn_editGradeBack.Enabled = true;
            cmb_GradeLevels.Enabled = true;
            btn_EditGrades.Enabled = true;
            btn_Delete.Enabled = true;
            dgv_studentList.Enabled = true;
        }
        private void EditGrades_Load(object sender, EventArgs e)
        {
            //hiding password by default
            txt_passCode.UseSystemPasswordChar = true;

            pnl_verification.Visible = false;
        }
        private void cmb_GradeLevels_SelectedIndexChanged(object sender, EventArgs e)
        {

            //sELECT * FROM TABLE 
            switch (cmb_GradeLevels.Text)
            {
                //selected Grade and sec
                case "1 - Diamond":
                    {
                        //assigning of gradelevel, section and passcode property;
                        gradelevel = 1;
                        section = "Diamond";
                        Passcode = "one";

                        //table display
                        dgv_studentList.DataSource = data.SP_stud_ViewStudents(gradelevel);
                    }
                    break;
                case "2 - Rosal":
                    {
                        gradelevel = 2;
                        section = "Rosal";
                        Passcode = "two";
                        dgv_studentList.DataSource = data.SP_stud_ViewStudents(gradelevel);
                    }
                    break;
                case "3 - Earth":
                    {
                        gradelevel = 3;
                        section = "Earth";
                        Passcode = "three";
                        dgv_studentList.DataSource = data.SP_stud_ViewStudents(gradelevel);
                    }
                    break;
                case "4 - Hope":
                    {
                        gradelevel = 4;
                        section = "Hope";
                        Passcode = "four";
                        dgv_studentList.DataSource = data.SP_stud_ViewStudents(gradelevel);
                    }
                    break;
                case "5 - Fourier":
                    {
                        gradelevel = 5;
                        section = "Fourier";
                        Passcode = "five";
                        dgv_studentList.DataSource = data.SP_stud_ViewStudents(gradelevel);
                    }
                    break;
                case "6 - Hawking":
                    {
                        gradelevel = 6;
                        section = "Hawking";
                        Passcode = "six";
                        dgv_studentList.DataSource = data.SP_stud_ViewStudents(gradelevel);
                    }
                    break;
                default:
                    gradelevel = null;
                    break;
            }
        }

      

        private void dgv_studentList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0 || e.ColumnIndex == 1 && e.RowIndex >= 0 ||
              e.ColumnIndex == 2 && e.RowIndex >= 0 || e.ColumnIndex == 3 && e.RowIndex >= 0 ||
              e.ColumnIndex == 4 && e.RowIndex >= 0 || e.ColumnIndex == 5 && e.RowIndex >= 0 ||
              e.ColumnIndex == 6 && e.RowIndex >= 0 || e.ColumnIndex == 7 && e.RowIndex >= 0 ||
              e.ColumnIndex == 8 && e.RowIndex >= 0 || e.ColumnIndex == 9 && e.RowIndex >= 0 ||
              e.ColumnIndex == 10 && e.RowIndex >= 0 || e.ColumnIndex == 11 && e.RowIndex >= 0 || 
              e.ColumnIndex == 12 && e.RowIndex >= 0)
            {
                // Handle the click action for the clickable cells
                string clickedValue = dgv_studentList.Rows[e.RowIndex].Cells[0].Value.ToString();
                lbl_StudID.Text = clickedValue;

                //assigning of local variable
                SelectedID = int.Parse(clickedValue);
            }
            else
            {
                alert.Invalid_Selection();
            }
        }

        private void btn_editGradeBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Edit Grade security

        private void btn_enter_Click(object sender, EventArgs e)
        {
            //cheching the passcode if empty
            if (string.IsNullOrWhiteSpace(txt_passCode.Text))
            {
                alert.InputPasscode();
            }
            else
            {
                switch (gradelevel)
                {
                    case 1:
                        if (txt_passCode.Text != Passcode)
                        {
                            alert.Incorrect_Passcode();
                        }

                        else
                        {
                            if (SelectedID == null || SelectedID == 0 || gradelevel == null || section == null)
                            {
                                alert.Select_ID();
                            }

                            else
                            {
                                InputGrades ig = new InputGrades();
                                //PASSING OF TEACHER'S ID

                                ig.ID = ID;

                                //Passing of selected grade level
                                ig.gradelevel = gradelevel;
                                ig.section = section;
                                //passing of student ID
                                ig.SelectedID = SelectedID;
                                ig.ShowDialog();
                                txt_passCode.Clear();
                                pnl_verification.Visible = false;

                                FormControlsEnabled();

                            }
                        }
                        break;

                    case 2:
                        if (txt_passCode.Text != Passcode)
                        {
                            alert.Incorrect_Passcode();
                        }

                        else
                        {
                            if (SelectedID == null || SelectedID == 0 || gradelevel == null || section == null)
                            {
                                alert.Select_ID();
                            }

                            else
                            {
                                InputGrades ig = new InputGrades();
                                //PASSING OF TEACHER'S ID
                                ig.ID = ID;

                                //Passing of selected grade level
                                ig.gradelevel = gradelevel;
                                ig.section = section;
                                //passing of student ID
                                ig.SelectedID = SelectedID;
                                ig.ShowDialog();
                                txt_passCode.Clear();
                                pnl_verification.Visible = false;
                                FormControlsEnabled();
                            }
                        }
                        break;

                    case 3:
                        if (txt_passCode.Text != Passcode)
                        {
                            alert.Incorrect_Passcode();
                        }

                        else
                        {
                            if (SelectedID == null || SelectedID == 0 || gradelevel == null || section == null)
                            {
                                alert.Select_ID();
                            }

                            else
                            {
                                InputGrades ig = new InputGrades();

                                //PASSING OF TEACHER'S ID
                                ig.ID = ID;

                                //Passing of selected grade level
                                ig.gradelevel = gradelevel;
                                ig.section = section;
                                //passing of student ID
                                ig.SelectedID = SelectedID;

                                ig.ShowDialog();
                                txt_passCode.Clear();
                                pnl_verification.Visible = false;
                                FormControlsEnabled();
                            }
                        }
                        break;

                    case 4:
                        if (txt_passCode.Text != Passcode)
                        {
                            alert.Incorrect_Passcode();
                        }

                        else
                        {
                            if (SelectedID == null || SelectedID == 0 || gradelevel == null || section == null)
                            {
                                alert.Select_ID();
                            }

                            else
                            {
                                InputGrades ig = new InputGrades();
                                //PASSING OF TEACHER'S ID
                                ig.ID = ID;

                                //Passing of selected grade level
                                ig.gradelevel = gradelevel;
                                ig.section = section;
                                //passing of student ID
                                ig.SelectedID = SelectedID;
                                ig.ShowDialog();
                                txt_passCode.Clear();
                                pnl_verification.Visible = false;
                                FormControlsEnabled();
                            }
                        }
                        break;

                    case 5:
                        if (txt_passCode.Text != Passcode)
                        {
                            alert.Incorrect_Passcode();
                        }

                        else
                        {
                            if (SelectedID == null || SelectedID == 0 || gradelevel == null || section == null)
                            {
                                alert.Select_ID();
                            }

                            else
                            {
                                InputGrades ig = new InputGrades();
                                //PASSING OF TEACHER'S ID
                                ig.ID = ID;

                                //Passing of selected grade level
                                ig.gradelevel = gradelevel;
                                ig.section = section;
                                //passing of student ID
                                ig.SelectedID = SelectedID;
                                ig.ShowDialog();
                                txt_passCode.Clear();
                                pnl_verification.Visible = false;
                                FormControlsEnabled();
                            }
                        }
                        break;

                    case 6:
                        if (txt_passCode.Text != Passcode)
                        {
                            alert.Incorrect_Passcode();
                        }

                        else
                        {
                            if (SelectedID == null || SelectedID == 0 || gradelevel == null || section == null)
                            {
                                alert.Select_ID();
                            }

                            else
                            {
                                InputGrades ig = new InputGrades();
                                //PASSING OF TEACHER'S ID
                                ig.ID = ID;

                                //Passing of selected grade level
                                ig.gradelevel = gradelevel;
                                ig.section = section;
                                //passing of student ID
                                ig.SelectedID = SelectedID;
                                ig.ShowDialog();
                                txt_passCode.Clear();
                                pnl_verification.Visible = false;
                                FormControlsEnabled();
                            }
                        }
                        break;
                    default:
                        //throw code here if needed
                        break;
                }
            }
       
            
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            txt_passCode.UseSystemPasswordChar = true;

            btn_enter.Visible = false;
            btn_pnldelete.Visible = true;
            if (cmb_GradeLevels.Text == "Select -------" || string.IsNullOrEmpty(cmb_GradeLevels.Text) || SelectedID == null)
            {
                alert.Select_ID();

            }
            else
            {
                //disabling background controls
                btn_editGradeBack.Enabled = false;
                cmb_GradeLevels.Enabled = false;
                btn_EditGrades.Enabled = false;
                btn_Delete.Enabled = false;
                dgv_studentList.Enabled = false;

                pnl_verification.Visible = true;

                txt_passCode.Focus();

              
            }

        }

        private void btn_EditGrades_Click(object sender, EventArgs e)

        {
            txt_passCode.UseSystemPasswordChar= true;
        
            btn_pnldelete.Visible = false;
            btn_enter.Visible = true;
            if (cmb_GradeLevels.Text == "Select -------" || string.IsNullOrEmpty(cmb_GradeLevels.Text) || SelectedID == null)
            {
                alert.Select_ID();

            }
            else
            {
                //disabling background controls
             btn_editGradeBack.Enabled = false;
             cmb_GradeLevels.Enabled = false;
             btn_EditGrades.Enabled = false;
             btn_Delete.Enabled = false;
             dgv_studentList.Enabled = false;

             pnl_verification.Visible = true;

                txt_passCode.Focus();
            }
          
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            //enabling background controls
            btn_editGradeBack.Enabled = true;
            cmb_GradeLevels.Enabled = true;
            btn_EditGrades.Enabled = true;
            btn_Delete.Enabled = true;
            dgv_studentList.Enabled = true;

            pnl_verification.Visible=false;
            txt_passCode.Clear();
        }

        private void dgv_studentList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void Dgv_ReloadData()
        {
            
            dgv_studentList.DataSource = data.SP_stud_ViewStudents(gradelevel);
            lbl_StudID.Text= "__";
         
        }

        private void pnl_verification_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_passCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            Dgv_ReloadData();
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            btn_Show.Visible = false;
            btn_hide.Visible = true;

            txt_passCode.UseSystemPasswordChar = false;
        }

        private void btn_hide_Click(object sender, EventArgs e)
        {
            btn_Show.Visible = true;
            btn_hide.Visible = false;

            txt_passCode.UseSystemPasswordChar = true;
        }

        void DeleteStudent()
        {
            //Notifying the user for final decision
            var ResultDialog = MessageBox.Show($"Do you want to delete the selected ID \"{SelectedID}\" ?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (ResultDialog == DialogResult.Yes)
            {

                //Stored Procedure Function
                data.SP_tch_DeleteStudent(SelectedID);
                Dgv_ReloadData();
                FormControlsEnabled();

            }
            else
            {
                FormControlsEnabled();
            }
            txt_passCode.Clear();
            pnl_verification.Visible = false;
        }
        private void btn_pnldelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_passCode.Text))
            {
                alert.InputPasscode();
            }
            else
            {
                switch (gradelevel)
                {
                    case 1:
                        if (txt_passCode.Text != Passcode)
                        {
                            alert.Incorrect_Passcode();
                        }

                        else
                        {
                            if (SelectedID == null || SelectedID == 0 || gradelevel == null || section == null)
                            {
                                alert.Select_ID();
                            }

                            else
                            {
                                DeleteStudent();

                            }
                        }
                        break;

                    case 2:
                        if (txt_passCode.Text != Passcode)
                        {
                            alert.Incorrect_Passcode();
                        }

                        else
                        {
                            if (SelectedID == null || SelectedID == 0 || gradelevel == null || section == null)
                            {
                                alert.Select_ID();
                            }

                            else
                            {
                                DeleteStudent();
                            }
                        }
                        break;

                    case 3:
                        if (txt_passCode.Text != Passcode)
                        {
                            alert.Incorrect_Passcode();
                        }

                        else
                        {
                            if (SelectedID == null || SelectedID == 0 || gradelevel == null || section == null)
                            {
                                alert.Select_ID();
                            }

                            else
                            {
                                DeleteStudent();
                            }

                        }
                        break;

                    case 4:
                        if (txt_passCode.Text != Passcode)
                        {
                            alert.Incorrect_Passcode();
                        }

                        else
                        {
                            if (SelectedID == null || SelectedID == 0 || gradelevel == null || section == null)
                            {
                                alert.Select_ID();
                            }

                            else
                            {
                                DeleteStudent();
                            }
                        }
                        break;

                    case 5:
                        if (txt_passCode.Text != Passcode)
                        {
                            alert.Incorrect_Passcode();
                        }

                        else
                        {
                            if (SelectedID == null || SelectedID == 0 || gradelevel == null || section == null)
                            {
                                alert.Select_ID();
                            }

                            else
                            {
                                DeleteStudent();


                            }
                        }
                        break;

                    case 6:
                        if (txt_passCode.Text != Passcode)
                        {
                            alert.Incorrect_Passcode();
                        }

                        else
                        {
                            if (SelectedID == null || SelectedID == 0 || gradelevel == null || section == null)
                            {
                                alert.Select_ID();
                            }

                            else
                            {
                                //Notifying the user for final decision
                                var ResultDialog = MessageBox.Show($"Do you want to delete the selected ID \"{SelectedID}\" ?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                                if (ResultDialog == DialogResult.Yes)
                                {

                                    //Stored Procedure Function
                                    data.SP_tch_DeleteStudent(SelectedID);
                                    Dgv_ReloadData();

                                }
                            }
                        }
                        break;
                    default:
                        //throw code here if needed
                        break;
                }
            }
          

        }
    }
   
}