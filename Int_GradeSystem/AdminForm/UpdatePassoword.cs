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
    public partial class UpdatePassoword : Form
    {
        public UpdatePassoword()
        {
            InitializeComponent();
        }

        DataClasses1DataContext data = new DataClasses1DataContext();
        MessageAlert alert = new MessageAlert();

        public string ID { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string email { get; set; }

        private void UpdatePassoword_Load(object sender, EventArgs e)
        {
            lbl_ID.Text = ID;
            lbl_fname.Text =firstname;
            lbl_lname.Text = lastname;
            lbl_email.Text =email;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
          
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if(txt_regPassword.Text != txt_regConfirmPass.Text)
            {
                alert.Password_Notmatch();
            }
            else
            {
                data.SP_adm_TeacherUpdatePass(int.Parse(lbl_ID.Text), txt_regPassword.Text);
                this.Close();
                alert.Upate_Save();

            }
        }
    }
}
