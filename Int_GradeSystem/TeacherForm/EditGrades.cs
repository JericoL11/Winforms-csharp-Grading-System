using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public EditGrades()
        {
            InitializeComponent();
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
                        dgv_studentList.DataSource = data.SP_stud_View_Students(gradelevel);
                    }
                    break;
                case "2 - Rosal":
                    {
                        gradelevel = 2;
                        section = "Rosal";
                        Passcode = "two";
                        dgv_studentList.DataSource = data.SP_stud_View_Students(gradelevel);
                    }
                    break;
                case "3 - Earth":
                    {
                        gradelevel = 3;
                        section = "Earth";
                        Passcode = "three";
                        dgv_studentList.DataSource = data.SP_stud_View_Students(gradelevel);
                    }
                    break;
                case "4 - Hope":
                    {
                        gradelevel = 4;
                        section = "Hope";
                        Passcode = "four";
                        dgv_studentList.DataSource = data.SP_stud_View_Students(gradelevel);
                    }
                    break;
                case "5 - Fourier":
                    {
                        gradelevel = 5;
                        section = "Fourier";
                        Passcode = "five";
                        dgv_studentList.DataSource = data.SP_stud_View_Students(gradelevel);
                    }
                    break;
                case "6 - Hawking":
                    {
                        gradelevel = 6;
                        section = "Hawking";
                        Passcode = "six";
                        dgv_studentList.DataSource = data.SP_stud_View_Students(gradelevel);
                    }
                    break;
                default:
                    gradelevel = null;
                    break;
            }
        }

        private void EditGrades_Load(object sender, EventArgs e)
        {
            pnl_verification.Visible = false;
        }

        private void dgv_studentList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0 || e.ColumnIndex == 1 && e.RowIndex >= 0 ||
              e.ColumnIndex == 2 && e.RowIndex >= 0 || e.ColumnIndex == 3 && e.RowIndex >= 0 ||
              e.ColumnIndex == 4 && e.RowIndex >= 0 || e.ColumnIndex == 5 && e.RowIndex >= 0)
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
            TeacherFormPage tf = new TeacherFormPage();
            tf.ID = ID;
            tf.Show();
            this.Close();
        }

        //Edit Grade security

        private void btn_enter_Click(object sender, EventArgs e)
        {
            
          switch(gradelevel)
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
                            ig.Show();

                            this.Close();
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
                            ig.Show();

                            this.Close();
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
                            ig.Show();

                            this.Close();
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
                            ig.Show();

                            this.Close();
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
                            ig.Show();

                            this.Close();
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
                            ig.Show();

                            this.Close();
                        }
                    }
                    break;
                default:
                    //throw code here if needed
                    break;
            }
            
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            //THROW SOME CODE HERE
        }

        private void btn_EditGrades_Click(object sender, EventArgs e)
        {
            if(cmb_GradeLevels.Text == "Select -------" || string.IsNullOrEmpty(cmb_GradeLevels.Text) || SelectedID == null)
            {
                alert.Select_ID();

            }
            else
            {
                pnl_verification.Visible = true;
                this.Focus();
            }
          
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            pnl_verification.Visible=false;
            txt_passCode.Clear();
        }
    }
}