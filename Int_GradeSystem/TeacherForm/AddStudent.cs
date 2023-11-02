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
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        //datase instantiation
        DataClasses1DataContext data = new DataClasses1DataContext();

        // reciever of teacherID from teacher Form page
        public string ID { get; set; }

        //for message errors
         MessageAlert alert = new MessageAlert(); 

        //reciever of data from selected grade level. this is for  year and sec label
        public string Grade { get; set; }
 
        //gender property
        public string gender { get; set; }

        //grade level property. needed for switch registration
        public int gradeLevel { get; set; }

        //Data and time now Object
        DateTime now = DateTime.Now;

        //nullable age. for after the calculation  of the year container
        int? age;


        private void AddStudent_Load(object sender, EventArgs e)
        {


           //Id handler
            pnl_id.Visible = false;
            lbl_teacherID.Text = ID;
            lbl_GradeAndSec.Text = Grade;
        }

      
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            TeacherFormPage tf = new TeacherFormPage();

            tf.ID = ID;
            this.Close();
            tf.Show();
        }

        private void btn_StudRegister_Click(object sender, EventArgs e)
        {
            // teacher database. 
            var database = data.tbl_TeacherAccs
                            .FirstOrDefault(t => t.teacherId == int.Parse(ID));

            switch (gradeLevel)
            {
                case 1:
                    {
                        
                        if (string.IsNullOrWhiteSpace(txt_StudfirstName.Text) || string.IsNullOrWhiteSpace(txt_StudlastName.Text) || age == null || gender == null)
                        { 
                            //if no input or if there is no input
                            alert.Fillout_Form();
                        }
                        else
                        {
                            //age checker
                            if(age < 4)
                            {
                                alert.Invalid_Age(gradeLevel,(int)age);
                            }
                            else
                            {
                                alert.Successfully_Registered();

                                //to get the  teacher's name
                                var teacherName = $"{database.firstname} {database.lastname}";


                                //Stored Procedure na
                                data.SP_tch_addGrade_1_stud(txt_StudfirstName.Text, txt_StudlastName.Text, txt_StudmiddleName.Text, gender, dtp_bdate.Value, age, teacherName);

                                Clear_All();


                            }
                         
                        }
                    }
                    break;
                case 2:
                    {
                        if (string.IsNullOrWhiteSpace(txt_StudfirstName.Text) || string.IsNullOrWhiteSpace(txt_StudlastName.Text) || age == null || gender == null)
                        {
                            alert.Fillout_Form();
                        }
                        else
                        {
                            if (age < 4)
                            {
                                alert.Invalid_Age(gradeLevel, (int)age);
                            }
                            else
                            {
                                alert.Successfully_Registered();
                                var teacherName = $"{database.firstname} {database.lastname}";
                                data.SP_tch_addGrade_2_stud(txt_StudfirstName.Text, txt_StudlastName.Text, txt_StudmiddleName.Text, gender, dtp_bdate.Value, age, teacherName);

                                Clear_All();
                            }
                        }
                    }
                    break;
               
                case 3:
                    {
                        if (string.IsNullOrWhiteSpace(txt_StudfirstName.Text) || string.IsNullOrWhiteSpace(txt_StudlastName.Text) || age == null || gender == null)
                        {
                            alert.Fillout_Form();
                        }
                        else
                        {
                            if (age < 4)
                            {
                                alert.Invalid_Age(gradeLevel, (int)age);
                            }
                            else
                            {

                                alert.Successfully_Registered();
                                var teacherName = $"{database.firstname} {database.lastname}";


                                data.SP_tch_addGrade_3_stud(txt_StudfirstName.Text, txt_StudlastName.Text, txt_StudmiddleName.Text, gender, dtp_bdate.Value, age, teacherName);

                                Clear_All();
                            }
                        }
                    }
                    break;

                case 4:
                    {
                        if (string.IsNullOrWhiteSpace(txt_StudfirstName.Text) || string.IsNullOrWhiteSpace(txt_StudlastName.Text) || age == null || gender == null)
                        {
                            alert.Fillout_Form();
                        }
                        else
                        {
                            if (age < 4)
                            {
                                alert.Invalid_Age(gradeLevel, (int)age);
                            }
                            else
                            {
                                alert.Successfully_Registered();
                                var teacherName = $"{database.firstname} {database.lastname}";
                                data.SP_tch_addGrade_4_stud(txt_StudfirstName.Text, txt_StudlastName.Text, txt_StudmiddleName.Text, gender, dtp_bdate.Value, age, teacherName);

                                Clear_All();
                            }
                        }
                    }
                    break;

                case 5:
                    {
                        if (string.IsNullOrWhiteSpace(txt_StudfirstName.Text) || string.IsNullOrWhiteSpace(txt_StudlastName.Text) || age == null || gender == null)
                        {
                            alert.Fillout_Form();
                        }
                        else
                        {
                            if (age < 4)
                            {
                                alert.Invalid_Age(gradeLevel, (int)age);
                            }
                            else
                            {
                                alert.Successfully_Registered();
                                var teacherName = $"{database.firstname} {database.lastname}";


                                data.SP_tch_addGrade_5_stud(txt_StudfirstName.Text, txt_StudlastName.Text, txt_StudmiddleName.Text, gender, dtp_bdate.Value, age, teacherName);

                                Clear_All();
                            }
                        }
                    }
                    break;

                case 6:
                    {
                        if (string.IsNullOrWhiteSpace(txt_StudfirstName.Text) || string.IsNullOrWhiteSpace(txt_StudlastName.Text) || age == null || gender == null)
                        {
                            alert.Fillout_Form();
                        }
                        else
                        {
                            if (age < 4)
                            {
                                alert.Invalid_Age(gradeLevel, (int)age);
                            }
                            else
                            {
                                alert.Successfully_Registered();
                                var teacherName = $"{database.firstname} {database.lastname}";


                                data.SP_tch_addGrade_6_stud(txt_StudfirstName.Text, txt_StudlastName.Text, txt_StudmiddleName.Text, gender, dtp_bdate.Value, age, teacherName);

                                Clear_All();
                            }
                        }
                    }
                    break;

                default:
                    {
                        //throw some code here
                    }
                    break;
            }

         
        }

        #region == event handlers == 
        private void rbtn_Studfemale_Click(object sender, EventArgs e)
        {
            gender = "Female";
        }

        private void rbtn_Studmale_Click(object sender, EventArgs e)
        {
            gender = "Male";

        }

        private void dtp_bdate_Leave(object sender, EventArgs e)
        {
            // var Bdate = new DateTime(dtp_bdate.Value.Year);
            AgeReloader();
            var year = now.Year;

            var selectedYear = dtp_bdate.Value.Year;

            //assigning of age var
            age = year - selectedYear;
            lbl_age.Text = age.ToString();
        }
        void AgeReloader()
        {
            lbl_age.Text = "";

        }

        private void dtp_bdate_Enter(object sender, EventArgs e)
        {
      
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        void Clear_All()
        {
            txt_StudfirstName.Clear();
            txt_StudlastName.Clear();
            txt_StudmiddleName.Clear();
            rbtn_Studfemale.Checked = false;
            rbtn_Studfemale.Checked = false;
            lbl_age.Text = null;
            dtp_bdate = default;
            
        }
    }
    #endregion
}
