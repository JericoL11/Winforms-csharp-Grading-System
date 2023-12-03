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
    public partial class IntroForm : Form
    {
        public IntroForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //for loading
            pnl_loading.Width += 3;


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
                        Form1 f1 = new Form1();

                        f1.Show();
                        timer.Stop();


                        this.Hide();
                    }
                };
                timer.Start();
            }
        }
    }
}
