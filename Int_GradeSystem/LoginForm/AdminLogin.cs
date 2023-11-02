﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Admin = Int_GradeSystem.AdminForm;

namespace Int_GradeSystem
{


   
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        //database injection
        DataClasses1DataContext data = new DataClasses1DataContext();

        //AlertClass
        MessageAlert alert = new MessageAlert();

        private void llnk_TeacherForm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void btn_AdminLogin_Click(object sender, EventArgs e)
        {
            
            //matching the data in database
            var adminUser = data.tbl_Admins
                            .FirstOrDefault(user => user.admin_User == txt_AdminUsername.Text
                            && user.admin_Pass == txt_AdminPassword.Text);

            if (txt_AdminUsername.Text == "Username" || txt_AdminPassword.Text == "Password")
            {
               alert.login_Fillout();
            }
            else if (adminUser != null)
            {
                alert.login_Success();
                Admin.AdminFormPage ad = new Admin.AdminFormPage();
                ad.Show();
                this.Hide();
              
            }
            else
            {
               alert.login_Fail();
            }
          
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }


        #region ==  textbox placeholder ==
        private void txt_AdminUsername_Leave_1(object sender, EventArgs e)
        {
            //textbox Funtion
            if (txt_AdminUsername.Text == "")
            {
               
                txt_AdminUsername.Text = "Username";
            }
       

        }

        private void txt_AdminUsername_Enter(object sender, EventArgs e)
        {
          
            //textbox Funtion
            if (txt_AdminUsername.Text == "Username")
            {
               
                txt_AdminUsername.Text = "";
            }
      
        }

        private void txt_AdminPassword_Leave(object sender, EventArgs e)
        {
            //textbox Funtion
            if (txt_AdminPassword.Text == "")
            {
    
                txt_AdminPassword.Text = "Password";
            }
          
        }

        private void txt_AdminPassword_Enter(object sender, EventArgs e)
        {
            //textbox Funtion
         
            if (txt_AdminPassword.Text == "Password")
            {

            
                txt_AdminPassword.Text = "";
            }
      

        }

        private void txt_AdminUsername_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion
    }
}