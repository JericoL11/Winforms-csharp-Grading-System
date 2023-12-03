using Int_GradeSystem.TeacherForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Int_GradeSystem.AdminForm
{
    public partial class EditProfile : Form
    {

        /*======== OBJECTS & PROPERTIES =========*/

        //database instantiation
     DataClasses1DataContext data = new DataClasses1DataContext();

        MessageAlert alert = new MessageAlert();

        // reciever of userID from Teacher's home page
        public string ID { get; set; }

        //gender property
        public string gender { get; set; }

        //Data and time now Object
        DateTime now = DateTime.Now;

        //nullable age. for after the calculation  of the year container
        int? age;

        public EditProfile()
        {
            InitializeComponent();

            //fix screen flickering
            this.DoubleBuffered = true;

        }

    
        private void EditProfile_Load(object sender, EventArgs e)
        {
            //hidden panel that are used for messagebox
            pnl_loading.Visible = false;
            pnl_width.Visible = false;

            //Matching of teacher ID
            var database = data.tbl_TeacherAccs
                            .FirstOrDefault(d => d.teacherId == int.Parse(ID));



            //for information - assigning of information from database tbl_TeacherInfos
            var database_Info = data.tbl_TeacherInfos
                                .FirstOrDefault(i => i.FK_teacherId == int.Parse(ID));

            //For checking the ID if it is availabe in the database tbl_TeacherInfos
            var tbl_teacherInfo = data.tbl_TeacherInfos
                                .Select(t => t.FK_teacherId);


            //Assigning of default information from database tbl_TeacherAccs
            lbl_teacherID.Text = ID;
            txt_firstName.Text = database.firstname.ToUpper();
            txt_lastName.Text = database.lastname.ToUpper();
            txt_email.Text = database.email.ToUpper();


            if (tbl_teacherInfo.Contains(int.Parse(ID)))
            {
                //Assigning of default information from database 
                txt_middleName.Text = database_Info.middleName.ToUpper();
                txt_phoneNumber.Text = database_Info.phoneNumber.ToUpper();
                lbl_Age.Text = database_Info.age.ToString();

                txt_email.Text = database.email.ToUpper();
                gender = database_Info.gender;


                switch (database_Info.gender)
                {
                    case "Male":
                        rbtn_male.Checked = true; break;

                    case "Female":
                        rbtn_female.Checked = true; break;

                    default:
                        rbtn_male.Checked = false;
                        rbtn_female.Checked = false; break;
                }
            }

            else
            {
                timer_Checker.Enabled = true;
            }
    
      
        }

        private void btn_editProfileBack_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
   
   
        private void btn_save_Click(object sender, EventArgs e)
        {

             if(txt_phoneNumber.Text =="" || gender == null || txt_phoneNumber.Text == "" ||txt_email.Text =="" || age == null || string.IsNullOrEmpty(lbl_Age.Text))
            {
                alert.Fillout_Form();
            }
            else
            {
                if(age <= 17)
                {
                    alert.Teacher_Age_Invalid((int)age);
                }
                else
                {

                
                //database injection %% matching of ID
                var database = data.tbl_TeacherAccs
                              .FirstOrDefault(t => t.teacherId == int.Parse(ID));

                data.SP_tch_UpateInfo(txt_middleName.Text, gender, dtp_bdate.Value, age, txt_phoneNumber.Text,int.Parse(ID));
                alert.Upate_Save();
                }
            }
              
        }

        //Age Refresh Function
        void AgeReloader()
        {
            lbl_Age.Text = "";

        }
  

        #region == Event Handler ==
        private void rbtn_male_Click(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void rbtn_female_Click(object sender, EventArgs e)
        {
            gender = "Female";
        }

        private void dtp_bdate_Leave(object sender, EventArgs e)
        {
            // var Bdate = new DateTime(dtp_bdate.Value.Year);
            AgeReloader();
            var year = now.Year;

            var selectedYear = dtp_bdate.Value.Year;
            
            //assigning of age var
             age= year - selectedYear;
            lbl_Age.Text = age.ToString();
        }

        private void txt_phoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Block the input if it's not a number or control character
            }
        }

        private void txt_middleName_Leave(object sender, EventArgs e)
        {
           /* if (txt_middleName.Text == "")
            {
                txt_middleName.Text = "(Optional)";
            }*/
        }

        private void txt_middleName_Enter(object sender, EventArgs e)
        {
            /*if (txt_middleName.Text == "(Optional)")
            {
                txt_middleName.Text = "";
            }*/
        }



        #endregion

        private void timer_Checker_Tick(object sender, EventArgs e)
        {
  
            //for loading


            pnl_loading.Width += 5;

            if (pnl_loading.Width >= pnl_width.Width)
            {
                timer_Checker.Stop();
                alert.Update_Info();

            }
        }

        private void btn_changePass_Click(object sender, EventArgs e)
        {
            ChangePassword cp = new ChangePassword();

            cp.ID = this.ID;

            cp.ShowDialog();

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_firstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txt_lastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_middleName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_teacherID_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dtp_bdate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void gb_gender_Enter(object sender, EventArgs e)
        {

        }

        private void rbtn_female_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtn_male_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Age_Click(object sender, EventArgs e)
        {

        }

        private void txt_phoneNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnl_width_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnl_loading_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
