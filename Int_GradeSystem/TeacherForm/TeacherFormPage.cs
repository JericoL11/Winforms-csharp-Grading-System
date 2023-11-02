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
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
          Form1 f1 = new Form1();
           this.Close();
            f1.Show();
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
            ep.Show();
            this.Close();
        }

        private void btn_AdStudents_Click(object sender, EventArgs e)
        {
            GradeLevelLogin gl = new GradeLevelLogin();
            gl.ID = this.ID;
            gl.Show();
            this.Close();
           
        }

        private void btn_ViewStudents_Click(object sender, EventArgs e)
        {
            Student_List sl = new Student_List();
            sl.ID = this.ID;
            sl.Show();
            this.Close();
        }

        private void btn_editGrades_Click(object sender, EventArgs e)
        {
            EditGrades eg = new EditGrades();
            eg.ID = ID;
            eg.Show();
            this.Close();
        }
    }
}
