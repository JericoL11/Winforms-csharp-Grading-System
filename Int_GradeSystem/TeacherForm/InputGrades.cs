using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace Int_GradeSystem.TeacherForm
{
    public partial class InputGrades : Form
    {

        //database instantiation
        DataClasses1DataContext data = new DataClasses1DataContext();

        //message alert
        MessageAlert alert = new MessageAlert();

        // reciever of userID from Teacher's EDIT page
        public string ID { get; set; }

        //student ID handler
        public int? SelectedID { get; set; }

        //Student Grade holder
        public int? gradelevel { get; set; }

        // section property
        public string section { get; set; }


        public InputGrades()
        {
            InitializeComponent();
        }

        private void InputGrades_Load(object sender, EventArgs e)
        {
 
            switch (gradelevel)
            {
                case 1: { Grade_1(); } break;
                case 2: { Grade_2(); } break;
                case 3: { Grade_3(); } break;
                case 4: { Grade_4(); } break;
                case 5: { Grade_5(); } break;
                case 6: { Grade_6(); } break;

            }

        }

        private void btn_inputGradeBack_Click(object sender, EventArgs e)
        {
            EditGrades eg = new EditGrades();
            eg.ID = ID;
            eg.Show();
            this.Close();
        }

        #region == GRADE LEVEL functions ==
        void Grade_1()
        {
            //matching of student ID on database
            var database = data.tbl_Grade_1_Studs
                            .FirstOrDefault(g => g.studentId == SelectedID);

            //assigning of textboxes
            txt_fullName.Text = $"{database.firstName} {database.lastName}".ToUpper();
            lbl_gender.Text = database.gender.ToUpper();
            lbl_studID.Text = SelectedID.ToString();
            txt_grade.Text = gradelevel.ToString();
            txt_section.Text = section.ToUpper();
        }
        void Grade_2()
        {
            //matching of student ID on database
            var database = data.tbl_Grade_2_Studs
                            .FirstOrDefault(g => g.studentId == SelectedID);

            //assigning of textboxes
            txt_fullName.Text = $"{database.firstName} {database.lastName}".ToUpper();
            lbl_gender.Text = database.gender.ToUpper();
            lbl_studID.Text = SelectedID.ToString();
            txt_grade.Text = gradelevel.ToString();
            txt_section.Text = section.ToUpper();
        }
        void Grade_3()
        {
            //matching of student ID on database
            var database = data.tbl_Grade_3_Studs
                            .FirstOrDefault(g => g.studentId == SelectedID);

            //assigning of textboxes
            txt_fullName.Text = $"{database.firstName} {database.lastName}".ToUpper();
            lbl_gender.Text = database.gender.ToUpper();
            lbl_studID.Text = SelectedID.ToString();
            txt_grade.Text = gradelevel.ToString();
            txt_section.Text = section.ToUpper();
        }
        void Grade_4()
        {
            //matching of student ID on database
            var database = data.tbl_Grade_4_Studs
                            .FirstOrDefault(g => g.studentId == SelectedID);

            //assigning of textboxes
            txt_fullName.Text = $"{database.firstName} {database.lastName}".ToUpper();
            lbl_gender.Text = database.gender.ToUpper();
            lbl_studID.Text = SelectedID.ToString();
            txt_grade.Text = gradelevel.ToString();
            txt_section.Text = section.ToUpper();
        }
        void Grade_5()
        {
            //matching of student ID on database
            var database = data.tbl_Grade_5_Studs
                            .FirstOrDefault(g => g.studentId == SelectedID);

            //assigning of textboxes
            txt_fullName.Text = $"{database.firstName} {database.lastName}".ToUpper();
            lbl_gender.Text = database.gender.ToUpper();
            lbl_studID.Text = SelectedID.ToString();
            txt_grade.Text = gradelevel.ToString();
            txt_section.Text = section.ToUpper();
        }
    
        void Grade_6()
        {
            //matching of student ID on database
            var database = data.tbl_Grade_6_Studs
                            .FirstOrDefault(g => g.studentId == SelectedID);

            //assigning of textboxes
            txt_fullName.Text = $"{database.firstName} {database.lastName}".ToUpper();
            lbl_gender.Text = database.gender.ToUpper();
            lbl_studID.Text = SelectedID.ToString();
            txt_grade.Text = gradelevel.ToString();
            txt_section.Text = section.ToUpper();
        }
        #endregion

        private void lbl_PreOverall_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }
    }

}
