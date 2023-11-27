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
            
            //hiding of password by default
            txt_oldPass.UseSystemPasswordChar = true;
            txt_newPass.UseSystemPasswordChar = true;
            txt_confirmPass.UseSystemPasswordChar = true;

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
                    else if (txt_oldPass.Text != database.teacher_password)
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

        private void btn_hide_Click(object sender, EventArgs e)
        {
            btn_hide.Visible = false;
            btn_Show.Visible = true;

            txt_oldPass.UseSystemPasswordChar = true;
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            btn_hide.Visible = true;
            btn_Show.Visible = false;

            txt_oldPass.UseSystemPasswordChar = false;
        }

        private void txt_oldPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_newPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_show_new_Click(object sender, EventArgs e)
        {
            btn_hide_new.Visible = true;
            btn_show_new.Visible = false;

            txt_newPass.UseSystemPasswordChar = false;
            txt_confirmPass.UseSystemPasswordChar = false;
        }

        private void btn_hide_new_Click(object sender, EventArgs e)
        {
            btn_hide_new.Visible = false;
            btn_show_new.Visible = true;

            txt_newPass.UseSystemPasswordChar = true;
            txt_confirmPass.UseSystemPasswordChar = true;

        }
    }
}
