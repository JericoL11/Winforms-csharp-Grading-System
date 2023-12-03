using Int_GradeSystem.AdminForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Int_GradeSystem.TeacherForm
{
    public partial class TeacherFormPage : Form
    {

        //datase instantiation
        DataClasses1DataContext data = new DataClasses1DataContext();

        // reciever of userID from login page
        public string ID  {get;set;}

      
        public TeacherFormPage()
        {
            InitializeComponent();
            //fix screen flickering
            this.DoubleBuffered = true;

        }
        // set the WS_EX_COMPOSITED flag, which provides similar double-buffering behavior:
    
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_logout_Click(object sender, EventArgs e)
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
                    Form1 f1 = new Form1();
                    f1.Show();
                    timer.Stop();
                    this.Hide();
                }
            };
            timer.Start();

          
        }

        private void TeacherFormPage_Load(object sender, EventArgs e)
        {
          

            //Matching of data in database 
         
            var database_ID = data.tbl_TeacherAccs
                           .FirstOrDefault(t => t.teacherId == int.Parse(ID));

            lbl_fullName.Text = $"{database_ID.firstname.ToUpper()} {database_ID.lastname.ToUpper()}";
        }

        private void btn_editProfile_Click(object sender, EventArgs e)
        {
            EditProfile ep = new EditProfile();

            ep.ID = this.ID;
            ep.ShowDialog();
           
        }

        private void btn_AdStudents_Click(object sender, EventArgs e)
        {
            GradeLevelLogin gl = new GradeLevelLogin();
            gl.ID = this.ID;
            gl.ShowDialog();
         
           
        }

        private void btn_ViewStudents_Click(object sender, EventArgs e)
        {
            Student_List sl = new Student_List();
            sl.ID = this.ID;
            sl.ShowDialog();
           
        }

        private void btn_editGrades_Click(object sender, EventArgs e)
        {
            EditGrades eg = new EditGrades();
            eg.ID = ID;
            eg.ShowDialog();
        
        }

        private void btn_Ranking_Click(object sender, EventArgs e)
        {
            Ranking rk = new Ranking();
            rk.ID = this.ID;
            rk.ShowDialog();
          
        }
    }
}
