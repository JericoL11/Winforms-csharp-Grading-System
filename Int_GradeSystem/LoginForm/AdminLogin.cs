using Int_GradeSystem.AdminForm;
using Int_GradeSystem.TeacherForm;
using System;
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

        //database injection
        DataClasses1DataContext data = new DataClasses1DataContext();

        //AlertClass
        MessageAlert alert = new MessageAlert();

        private void llnk_TeacherForm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Opacity = 10;
            Timer timer = new Timer();
            timer.Interval = 15;
            timer.Tick += (senders, es) =>
            {
                this.Opacity -= 0.1;
                if (this.Opacity <= 0)
                {
                    Form1 nextForm = new Form1();
                    nextForm.Show();
                    timer.Stop();
                   
                   
                    this.Hide();
                }
            };
            timer.Start();
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

                //assigning the opacity
                this.Opacity = 10;

                //declaring timer object
                Timer timer = new Timer();

                //assigning interval
                timer.Interval = 15;

                //concatenation
                timer.Tick += (senders, es) =>
                {
                    this.Opacity -= 0.1;

                    //true
                    if (this.Opacity <= 0)
                    {
                        AdminFormPage ad = new AdminFormPage();
                        ad.Show();
                        timer.Stop();
                        this.Hide();
                    }
                };
                timer.Start();
              
              
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
          txt_AdminPassword.UseSystemPasswordChar = true;
        }


        #region ==  textbox placeholder ==
        private void txt_AdminUsername_Leave_1(object sender, EventArgs e)
        {
            //textbox Funtion
          /*  if (txt_AdminUsername.Text == "")
            {
               
                txt_AdminUsername.Text = "Username";
            }*/
       

        }

        private void txt_AdminUsername_Enter(object sender, EventArgs e)
        {
          
          /*  //textbox Funtion
            if (txt_AdminUsername.Text == "Username")
            {
               
                txt_AdminUsername.Text = "";
            }*/
      
        }

        private void txt_AdminPassword_Leave(object sender, EventArgs e)
        {
        /*    //textbox Funtion
            if (txt_AdminPassword.Text == "")
            {
    
                txt_AdminPassword.Text = "Password";
            }*/
          
        }

        private void txt_AdminPassword_Enter(object sender, EventArgs e)
        {
            //textbox Funtion
         
         /*   if (txt_AdminPassword.Text == "Password")
            {

            
                txt_AdminPassword.Text = "";
            }*/
      

        }

        private void txt_AdminUsername_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_AdminPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            btn_hide.Visible = true;
            btn_Show.Visible = false;

            txt_AdminPassword.UseSystemPasswordChar=false;
        }

        private void btn_hide_Click(object sender, EventArgs e)
        {
            btn_hide.Visible=false;
            btn_Show.Visible=true;

            txt_AdminPassword.UseSystemPasswordChar = true;

        }
    }
}