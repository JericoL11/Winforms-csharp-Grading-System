using Int_GradeSystem.AdminForm;
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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
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
        //database instantiation
        DataClasses1DataContext data = new DataClasses1DataContext();

        // reciever of userID from EDIT PROFILE home page
        public string ID { get; set; }

        MessageAlert alert = new MessageAlert();

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            lbl_ID.Text = ID;
        }

        private void bnt_Cancel_Click(object sender, EventArgs e)
        {
       
            this.Close();
            
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            //matching the ID in database tbl_teacherAcc
            var database = data.tbl_TeacherAccs
                           .FirstOrDefault( t=> t.teacherId == int.Parse(lbl_ID.Text));


            switch (txt_oldPass.Text)
            {
                case "":
                    alert.Fill_OldPassword();
                    break;

                default:
                    //If no input
                    if(string.IsNullOrEmpty(txt_newPass.Text) || string.IsNullOrEmpty(txt_confirmPass.Text))
                    {
                        alert.Fillout_Form_Password();
                    }
                    //if the inputed old password not match to database
                    else if (int.Parse(txt_oldPass.Text) != int.Parse(database.teacher_password))
                    {
                        alert.Old_Password_Incorrect();
                    }
                    else
                    {
                        //if new and confirm password not match
                        if (txt_newPass.Text != txt_confirmPass.Text)
                        {
                            alert.Password_Notmatch();

                        } 
                        else
                        {
                            //If true, sp will processed
                            alert.Successfully_passwordUpdated();
                            data.SP_tch_TeacherUpdatePass(int.Parse(ID), txt_newPass.Text);
                            this.Close();
                        }
                    }
                    break;
            }
        }

        private void lbl_ID_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
