﻿using System;
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
        }

   

        private void Student_List_Load(object sender, EventArgs e)
        {

        }

      

        private void btn_back_Click(object sender, EventArgs e)
        {
            TeacherFormPage tf = new TeacherFormPage();
            tf.ID = ID;
            tf.Show();
            this.Close();
        }

        private void cmb_GradeLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmb_GradeLevels.Text)
            {
                case "1 - Diamond":
                    {
                        dgv_studentList.DataSource = data.SP_tch_View_G1_Stud();
                    }
                    break;
                case "2 - Rosal":
                    {
                        dgv_studentList.DataSource = data.SP_tch_View_G2_Stud();
                    }
                    break;
                case "3 - Earth":
                    {
                        dgv_studentList.DataSource = data.SP_tch_View_G3_Stud();
                    }
                    break;
                case "4 - Hope":
                    {
                        dgv_studentList.DataSource = data.SP_tch_View_G4_Stud();
                    }
                    break;
                case "5 - Fourier":
                    {
                        dgv_studentList.DataSource = data.SP_tch_View_G5_Stud();
                    }
                    break;
                case "6 - Hawking":
                    {
                        dgv_studentList.DataSource = data.SP_tch_View_G6_Stud();
                    }
                    break;
                default:
                    break;
            }
        }
    }
}