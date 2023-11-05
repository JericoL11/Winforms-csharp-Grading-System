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
    public partial class Ranking : Form
    {
        //datase instantiation
        DataClasses1DataContext data = new DataClasses1DataContext();

        // reciever of teacher ID from login page
        public string ID { get; set; }


        //grade and term container
        public int gradelevel { get; set; }

        public string term { get; set; }
        public Ranking()
        {
            InitializeComponent();
        }

        private void Ranking_Load(object sender, EventArgs e)
        {

        }

        private void btn_rakingBack_Click(object sender, EventArgs e)
        {
            TeacherFormPage tf = new TeacherFormPage();
            tf.ID = ID;
            tf.Show();
            this.Close();
        }
        private void btn_View_Click(object sender, EventArgs e)
        {

            var database = data.tbl_Grading_Periods
                            .Select(g => g.FK_studentID);

                if (cmb_gradelevel.Text == "Select ---" || cmb_Terms.Text == "Select ---")
                {
                    MessageBox.Show("Please select grade level and terms");
                }
                else
                {

                    if (database == null)
                    {
                        MessageBox.Show("There is no Data for rankings yet");
                    }
                    else
                    {
                        dgv_ranking.DataSource = data.SP_stud_PrelimRankings(gradelevel,term);
                    }
            }  
        }

        private void cmb_gradelevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmb_gradelevel.SelectedIndex)
            {
                //assigning of gradelevel
                case 0: { gradelevel = 1; } break;
                case 1: { gradelevel = 2; } break;
                case 2: { gradelevel = 3; } break;
                case 3: { gradelevel = 4; } break;
                case 4: { gradelevel = 5; } break;
                case 5: { gradelevel = 6; } break;
                default:  { cmb_gradelevel.Text = "Select ---"; } break;
            }
        }

        private void cmb_Terms_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmb_gradelevel.SelectedIndex)
            {
                //assigning of Terms
                case  0:  { term = "Prelim";  } break;
                case  1:  { term = "Midterm"; } break;
                case  2:  { term = "Final";   } break;
            }
        }
     
    }
}

