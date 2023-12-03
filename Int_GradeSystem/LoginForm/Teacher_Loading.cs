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

namespace Int_GradeSystem.LoginForm
{
  
  
    public partial class Teacher_Loading : Form
    {
        public Teacher_Loading()
        {
            InitializeComponent();
            //to fix screen flickering
            this.DoubleBuffered = true;
        }
        //datase instantiation
        DataClasses1DataContext data = new DataClasses1DataContext();

        //alert messsage instantiation
        MessageAlert alert = new MessageAlert();
        public string ID { get; set; }

        private void Teacher_Loading_Load(object sender, EventArgs e)
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
                            TeacherFormPage tf = new TeacherFormPage();
                            tf.ID = ID;
                            tf.Show();
                            timer.Stop();


                            this.Hide();
                        }
                    };
                    timer.Start();
            }
        }
    }
}
