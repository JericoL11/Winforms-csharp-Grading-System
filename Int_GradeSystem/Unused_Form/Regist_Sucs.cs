using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Int_GradeSystem
{
    public partial class Regist_Sucs : Form
    {
        public Regist_Sucs()
        {
            InitializeComponent();
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            LoadingForm lf=new LoadingForm();
            lf.Show();
            this.Hide();
        }
    }
}
