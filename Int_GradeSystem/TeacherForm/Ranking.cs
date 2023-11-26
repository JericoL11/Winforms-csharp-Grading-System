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
            //fix screen flickering
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
        private void Ranking_Load(object sender, EventArgs e)
        {

        }

        private void btn_rakingBack_Click(object sender, EventArgs e)
        {
  
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
                case  0:  { term = "First"; } break;
                case  1:  { term = "Second"; } break;
                case  2:  { term = "Third";  } break;
                case  3:  { term = "Fourth";  } break;
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

