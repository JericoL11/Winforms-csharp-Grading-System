using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//namespace shortcut


namespace Int_GradeSystem.AdminForm
{
    public partial class AdminFormPage : Form
    {
        public AdminFormPage()
        {
            InitializeComponent();
        }

       

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            AdminLogin adl = new AdminLogin();
            this.Close();
            adl.Show();
           
        }

        private void btn_registerTeacher_Click(object sender, EventArgs e)
        {
            RegisterTeacherAcc rt = new RegisterTeacherAcc();
            this.Close();
            rt.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btn_View_Accounts_Click(object sender, EventArgs e)
        {
            AccntRecords ar = new AccntRecords();
            this.Close();
            ar.Show();
        }
    }
}
