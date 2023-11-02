using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Int_GradeSystem.AdminForm
{
    public partial class RegisterTeacherAcc : Form
    {
        public RegisterTeacherAcc()
        {
            InitializeComponent();
        }
        //DataClasses declaration
        DataClasses1DataContext data = new DataClasses1DataContext();
        
        //Message notificaltion class
        MessageAlert alert = new MessageAlert();

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void RegisterTeacherAcc_Load(object sender, EventArgs e)
        {

        }

        private void btn_regTeacherBack_Click(object sender, EventArgs e)
        {
            AdminFormPage ad = new AdminFormPage();
            this.Close();
            ad.Show();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txt_firstname.Text) || string.IsNullOrWhiteSpace(txt_lastname.Text) ||
                string.IsNullOrWhiteSpace(txt_email.Text) || string.IsNullOrWhiteSpace(txt_regPassword.Text) ||
                string.IsNullOrWhiteSpace(txt_regConfirmPass.Text))
            {
                alert.Fillout_Form();
            }
            else if (txt_regPassword.Text != txt_regConfirmPass.Text)
            {
                alert.Password_Notmatch();
            }
            else
            {
                alert.Registered();

                //stored procedure for creating a teacher account
                data.SP_adm_Create_TeacherAcc(txt_firstname.Text, txt_lastname.Text, txt_email.Text, txt_regPassword.Text);

                ClearAll();
            }

        }

        #region == Funtions == 
        void ClearAll()
        {
            txt_firstname.Clear();
            txt_lastname.Clear();
            txt_email.Clear();
            txt_regPassword.Clear();
            txt_regConfirmPass.Clear();

        }
        #endregion



    }
}
