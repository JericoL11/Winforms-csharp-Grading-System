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
        }

        //datase instantiation
        DataClasses1DataContext data = new DataClasses1DataContext();

        //alert messsage instantiation
        MessageAlert alert = new MessageAlert();

 

        private void btn_login_Click(object sender, EventArgs e)
        {
            ////matching the data in database
            var Teacher_Login = data.tbl_TeacherAccs
                                .FirstOrDefault(t => t.teacherId.ToString() == txt_username.Text
                                && t.teacher_password == txt_password.Text);
                            
            
            if(Teacher_Login != null)
            {

                alert.login_Success();

                TeacherFormPage tf = new TeacherFormPage();
                //assigning of property
                tf.ID = txt_username.Text;

                tf.Show();
                this.Hide();
              
               
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void llnk_AdminForm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminLogin al = new AdminLogin();
            al.Show();
            this.Hide();
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
    }
}
