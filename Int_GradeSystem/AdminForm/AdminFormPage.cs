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



        private void btn_Logout_Click(object sender, EventArgs e)
        {
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
                    AdminLogin adl = new AdminLogin();
                    adl.Show();
                    timer.Stop();
                    this.Hide();
                }
            };
            timer.Start();
    
        }

        private void btn_registerTeacher_Click(object sender, EventArgs e)
        {
 
        RegisterTeacherAcc rt = new RegisterTeacherAcc();
        rt.ShowDialog();    
 
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btn_View_Accounts_Click(object sender, EventArgs e)
        {
            AccntRecords ar = new AccntRecords();
            
            //sHOW DIALOG MEANING FOCUS ON 1 FORM ONLY
            ar.ShowDialog();
       
            
    
    
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
