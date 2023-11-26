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
    public partial class Student_List : Form
    { 
        
        //database instantiation
        DataClasses1DataContext data = new DataClasses1DataContext();

        MessageAlert alert = new MessageAlert();

        // reciever of userID from Teacher's home page
        public string ID { get; set; }


        public Student_List()
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


        private void Student_List_Load(object sender, EventArgs e)
        {

        }

      

        private void btn_back_Click(object sender, EventArgs e)
        {
          
            this.Close();
        }

        private void cmb_GradeLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmb_GradeLevels.Text)
            {
                case "1 - Diamond":
                    {
                        //assigning of grade level
                        dgv_studentList.DataSource = data.SP_stud_ViewLIst(1);
                    }
                    break;
                case "2 - Rosal":
                    {
                        dgv_studentList.DataSource = data.SP_stud_ViewLIst(2);
                    }
                    break;
                case "3 - Earth":
                    {
                        dgv_studentList.DataSource = data.SP_stud_ViewLIst(3); ;
                    }
                    break;
                case "4 - Hope":
                    {
                        dgv_studentList.DataSource = data.SP_stud_ViewLIst(4); ;
                    }
                    break;
                case "5 - Fourier":
                    {
                        dgv_studentList.DataSource = data.SP_stud_ViewLIst(5);
                    }
                    break;
                case "6 - Hawking":
                    {
                        dgv_studentList.DataSource = data.SP_stud_ViewLIst(6);
                    }
                    break;
                default:
                    break;
            }
        }

        private void dgv_studentList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
