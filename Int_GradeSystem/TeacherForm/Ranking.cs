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

                if (cmb_gradelevel.Text == "Select ---" || cmb_Terms.Text == "Select ---")
                {
                    MessageBox.Show("Please select grade level and terms");
                }
                else
                {
             
                    switch (gradelevel)
                    {
                        case 1:
                        Display_Ranking();
                            break;
                        case 2:
                        Display_Ranking();
                            break;
                        case 3:
                        Display_Ranking();
                            break;
                        case 4:
                        Display_Ranking();
                            break;
                        case 5:
                        Display_Ranking();
                            break;
                        case 6:
                        Display_Ranking();
                            break;
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
            switch (cmb_Terms.SelectedIndex)
            {
                //assigning of Terms
                case  0:  { term = "First"; lbl_term.Text = term; } break;
                case  1:  { term = "Second";lbl_term.Text = term; } break;
                case  2:  { term = "Third"; lbl_term.Text = term;  } break;
                case  3:  { term = "Fourth"; lbl_term.Text = term; } break;
            }
        }
        void Display_Ranking()
        {
            dgv_ranking.Rows.Clear();


            switch (term)
            {
                case "First":
                    {
                        dgv_ranking.DataSource = data.SP_stud_Ranking_FirstGrading(gradelevel);
                    }
                    break;
                case "Second":
                    {
                        dgv_ranking.DataSource = data.SP_stud_Ranking_SecondGrading(gradelevel);
                    }
                    break;
                case "Third":
                    {
                        dgv_ranking.DataSource = data.SP_stud_Ranking_ThirdGrading(gradelevel);
                    }
                    break;
                case "Fourth":
                    {
                        dgv_ranking.DataSource = data.SP_stud_Ranking_FourthGrading(gradelevel);
                    }
                    break;

                default:
                    {
                        dgv_ranking.Rows.Clear();
                    }
                    break;
            }

         
        }
     
    }
}

