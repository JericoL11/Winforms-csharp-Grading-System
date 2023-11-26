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

//FOLDER PATH SHORTCUTS
using Admin = Int_GradeSystem.AdminForm;
using Teacher = Int_GradeSystem.TeacherForm;


namespace Int_GradeSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //to fix screen flickering
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

        //alert messsage instantiation
        MessageAlert alert = new MessageAlert();

 

        private  void btn_login_Click(object sender, EventArgs e)
        {
            ////matching the data in database
            var Teacher_Login = data.tbl_TeacherAccs
                                .FirstOrDefault(t => t.teacherId.ToString() == txt_username.Text
                                && t.teacher_password == txt_password.Text);
                            
            
            if(Teacher_Login != null)
            {

                alert.login_Success();

                this.Opacity = 10;
                Timer timer = new Timer();
                timer.Interval = 15;
                timer.Tick += (senders, es) =>
                {
                    this.Opacity -= 0.1;
                    if (this.Opacity <= 0)
                    {
                        TeacherFormPage tf = new TeacherFormPage();
                        tf.ID = txt_username.Text;
                        tf.Show();
                        timer.Stop();
                  

                        this.Hide();
                    }
                };
                timer.Start();
            
               
            }
            else if(txt_username.Text == "Username" ||  txt_password.Text == "Password")
            {
                alert.login_Fillout();
            }
            else
            {
                alert.login_Fail();
            }
       
        }
        #region =========Transition Hide original code =================
        
      /*  private void ShowNextFormWithTransition()
        {
            // Implement custom animations or transitions between forms
            // For instance, you can use timers to gradually change opacity or position
            // Here's a simplified example using opacity change:

            this.Opacity = 5;
            Timer timer = new Timer();
            timer.Interval = 20;
            timer.Tick += (sender, e) =>
            {
                this.Opacity -= 0.05;
                if (this.Opacity <= 0)
                {
                    timer.Stop();
                    TeacherFormPage nextForm = new TeacherFormPage();
                    nextForm.Show();
                    this.Hide();
                }
            };
            timer.Start();
        }*/
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void llnk_AdminForm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Implement custom animations or transitions between forms
            // For instance, you can use timers to gradually change opacity or position
            // Here's a simplified example using opacity change:


            this.Opacity = 10;
            Timer timer = new Timer();
            timer.Interval = 15;
            timer.Tick += (senders, es) =>
            {
                this.Opacity -= 0.1;
                if (this.Opacity <= 0)
                {
                    AdminLogin nextForm = new AdminLogin();
                    nextForm.Show();
                    timer.Stop();


                    this.Hide();
                }
            };
            timer.Start();

        }

        #region == Textbox ===
        private void txt_username_Enter(object sender, EventArgs e)
        {

            if (txt_username.Text == "Username")
            {
                txt_username.Text = "";
            }
            

         
        }

        private void txt_username_Leave(object sender, EventArgs e)
        {
            //textbox Funtion
            if (txt_username.Text == "")
            {

                txt_username.Text = "Username";
            }
           
        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_password_Enter(object sender, EventArgs e)
        {
            if(txt_password.Text == "Password")
            {
                txt_password.Text = "";
            }
        }

        private void txt_password_Leave(object sender, EventArgs e)
        {
            if (txt_password.Text == "")
            {
                txt_password.Text = "Password";
            }
        }
#endregion
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pnl_bg_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
           this.Close();

        }
    }
}
