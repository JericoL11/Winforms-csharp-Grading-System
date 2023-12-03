using Int_GradeSystem.AdminForm;
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

namespace Int_GradeSystem.LoginForm
{
    public partial class Admin_Loading : Form
    {
        public Admin_Loading()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void Admin_Loading_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //for loading
            pnl_loading.Width += 5;


            if (pnl_loading.Width >= panel1.Width)
            {
                timer1.Stop();

                this.Opacity = 10;
                Timer timer = new Timer();
                timer.Interval = 15;
                timer.Tick += (senders, es) =>
                {
                    this.Opacity -= 0.1;
                    if (this.Opacity <= 0)
                    {
                        AdminFormPage af = new AdminFormPage();
                        af.Show();
                        timer.Stop();
                        this.Hide();
                    }
                };
                timer.Start();
            }
        }
    }
}
