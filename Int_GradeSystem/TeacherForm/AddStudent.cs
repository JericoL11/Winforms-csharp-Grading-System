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

            //fix screen flickering
            this.DoubleBuffered = true;

        }

        // set the WS_EX_COMPOSITED flag, which provides similar double-buffering behavior:
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // WS_EX_COMPOSITED
                return cp;
            }
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

        public string section { get; set; }

        //Data and time now Object
        DateTime now = DateTime.Now;

        //nullable age. for after the calculation  of the year container
        int? age;

        public int selectedYear { get; set; }


        private void AddStudent_Load(object sender, EventArgs e)
        {
        

           //Id handler
          
            lbl_teacherID.Text = ID;
            lbl_GradeAndSec.Text = Grade;
        }

      
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
           
            this.Close();
       
        }

        private void btn_StudRegister_Click(object sender, EventArgs e)
        {
           

            switch (gradeLevel)
            {
                case 1:
                    {

                        Students_Added();
                    }
                    break;
                case 2:
                    {
                        Students_Added();
                    }
                    break;
               
                case 3:
                    {
                        Students_Added();
                    }
                    break;

                case 4:
                    {
                        Students_Added();
                    }
                    break;

                case 5:
                    {
                        Students_Added();
                        
                    }
                    break;

                case 6:
                    {
                        Students_Added();
                    }
                    break;

                default:
                    {
                        //throw some code here
                    }
                    break;
            }

         
        }

        //condition for adding a student
        void Students_Added()
        {
            // teacher database. 
            var database = data.tbl_TeacherAccs
                            .FirstOrDefault(t => t.teacherId == int.Parse(ID));

            if (string.IsNullOrWhiteSpace(txt_StudfirstName.Text) || string.IsNullOrWhiteSpace(txt_StudlastName.Text) || age == null || gender == null || lbl_age.Text == "")
            {
                //if no input or if there is no input
                alert.Fillout_Form();
            }
            else
            {

                //age checker
                if (age < 4)
                {
                    alert.Invalid_Age(gradeLevel, (int)age);
                }
                else
                {
                    alert.Successfully_Registered();

                    //to get the  teacher's name
                    var teacherName = $"{database.firstname} {database.lastname}";


                    //Stored Procedure na
                    data.SP_stud_Add_Students(txt_StudfirstName.Text, txt_StudlastName.Text, txt_StudmiddleName.Text, gender, dtp_bdate.Value, age, gradeLevel, section, teacherName);

                    Clear_All();


                }

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

            selectedYear = dtp_bdate.Value.Year;

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
            rbtn_Studfemale = default;
            rbtn_Studfemale= default;
            lbl_age.Text = null;
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_teacherID_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void dtp_bdate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void lbl_GradeAndSec_Click(object sender, EventArgs e)
        {

        }

        private void lbl_age_Click(object sender, EventArgs e)
        {

        }
    }
    #endregion
}
