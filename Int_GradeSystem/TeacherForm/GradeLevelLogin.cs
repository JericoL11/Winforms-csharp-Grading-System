﻿    using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Int_GradeSystem.TeacherForm
{
    public partial class GradeLevelLogin : Form
    {
        public GradeLevelLogin()
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

        // reciever of teacher from teacher Form page
        public string ID { get; set; }

        //for message errors
        MessageAlert alert = new MessageAlert();

        // static DATA for Grade level and password in array
        string[] Grade = { "1 - Diamond", "2 - Rosal", "3 - Earth", "4 - Hope", "5 - Fourier", "6 - Hawking" };
        string[] password = { "one", "two", "three", "four", "five", "six" };
      
        private void GradeLevelLogin_Load(object sender, EventArgs e)

        {
            //id handler
            lbl_teacherID.Text = ID;

            //hidi password by default
            txt_password.UseSystemPasswordChar = true;
          /*  pnl_Id.Visible = false;*/
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            //Obj instantiation 
           AddStudent adStud = new AddStudent();

            if (string.IsNullOrWhiteSpace(txt_password.Text))
            {
                alert.InputPasscode();
            }
            else
            {
                switch (cmb_GradeLevels.Text)
                {
                    case "1 - Diamond":
                        if (txt_password.Text == password[0])
                        {

                            //sets the addstudent properties

                            //for label
                            adStud.Grade = Grade[0];

                            //teacherID reciever for viceversa/passing back of data
                            adStud.ID = ID;

                            //for grade level property
                            adStud.gradeLevel = 1;
                            adStud.section = "Diamond";
                            txt_password.Clear();
                            adStud.ShowDialog();

                        }
                        else
                        {
                            alert.IncorrectPasscode();
                        }
                        break;

                    case "2 - Rosal":
                        if (txt_password.Text == password[1])
                        {

                            adStud.Grade = Grade[1];
                            adStud.ID = ID;
                            adStud.gradeLevel = 2;
                            adStud.section = "Rosal";
                            txt_password.Clear();
                            adStud.ShowDialog();

                        }
                        else
                        {
                            alert.IncorrectPasscode();
                        }
                        break;

                    case "3 - Earth":
                        if (txt_password.Text == password[2])
                        {

                            adStud.Grade = Grade[2];
                            adStud.ID = ID;
                            adStud.gradeLevel = 3;
                            adStud.section = "Earth";
                            txt_password.Clear();
                            adStud.ShowDialog();


                        }
                        else
                        {
                            alert.IncorrectPasscode();
                        }
                        break;

                    case "4 - Hope":
                        if (txt_password.Text == password[3])
                        {


                            adStud.Grade = Grade[3];
                            adStud.ID = ID;
                            adStud.gradeLevel = 4;
                            adStud.section = "Hope";
                            txt_password.Clear();
                            adStud.ShowDialog();


                        }
                        else
                        {
                            alert.IncorrectPasscode();
                        }
                        break;

                    case "5 - Fourier":
                        if (txt_password.Text == password[4])
                        {


                            adStud.Grade = Grade[4];
                            adStud.ID = ID;
                            adStud.gradeLevel = 5;
                            adStud.section = "Fourier";
                            txt_password.Clear();
                            adStud.ShowDialog();


                        }
                        else
                        {
                            alert.IncorrectPasscode();
                        }
                        break;


                    case "6 - Hawking":
                        if (txt_password.Text == password[5])
                        {


                            adStud.Grade = Grade[5];
                            adStud.gradeLevel = 6;
                            adStud.section = "Fourier";
                            adStud.ID = ID;
                            txt_password.Clear();
                            adStud.ShowDialog();

                        }
                        else
                        {
                            alert.IncorrectPasscode();
                        }
                        break;

                    default:
                        MessageBox.Show("default");

                        break;
                }
            
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
        
            this.Close();
        }

        private void pnl_Id_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_teacherID_Click(object sender, EventArgs e)
        {

        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            btn_Show.Visible = false;
            btn_hide.Visible = true;

            txt_password.UseSystemPasswordChar = false;
        }

        private void btn_hide_Click(object sender, EventArgs e)
        {
            btn_Show.Visible = true;
            btn_hide.Visible = false;

            txt_password.UseSystemPasswordChar = true;
        }
    }
}
