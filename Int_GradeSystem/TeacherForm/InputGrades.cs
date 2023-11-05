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


        //average and status property
        public float average { get; set; }

        public string status { get; set; }


        string Gradingstatus = "Done";
        public InputGrades()
        {
            InitializeComponent();
        }

        private void InputGrades_Load(object sender, EventArgs e)
        {
            //Hidden of panels
            pnl_Prelim.Visible = false;
            pnl_Midterm.Visible = false;
            pnl_Final.Visible = false;
            pnl_overall.Visible = false;



            //assiging of form textbox if tbl student status is DONE
            var database = data.tbl_Students
                            .FirstOrDefault(st => st.studentId == SelectedID);

            var Prelim_data = data.tbl_Student_PrelimSubjects
                            .FirstOrDefault(p => p.FK_studentID == SelectedID);

            var Midterm_data = data.tbl_Student_MidtermSubjects
                             .FirstOrDefault(p => p.FK_studentID == SelectedID);

            var Final_data = data.tbl_Student_FinalSubjects
                         .FirstOrDefault(p => p.FK_studentID == SelectedID);

            if (database.Prelim_Status == "Done")
            {
                txt_PreMapeh.Text = Prelim_data.Mapeh_Prelim.ToString();
                txt_PreEnglish.Text = Prelim_data.English_Prelim.ToString();
                txt_PreMath.Text = Prelim_data.Math_Prelim.ToString();
                txt_PreFilipino.Text = Prelim_data.Filipino_Prelim.ToString();
                txt_PreScience.Text = Prelim_data.Science_Prelim.ToString();
                lbl_avgPrelim.Text = Prelim_data.Period_Avg_Prelim.ToString();
                lbl_StatusPrelim.Text = Prelim_data.Period_Status_Prelim;
            }
            else
            {
                goto inputdata;
            }

            if (database.Midterm_Status == "Done")
            {
                // if true , display the stored data
                txt_MidMapeh.Text = Midterm_data.Mapeh_Midterm.ToString();
                txt_MidEnglish.Text = Midterm_data.English_Midterm.ToString();
                txt_MidMath.Text = Midterm_data.Math_Midterm.ToString();
                txt_MidFilipino.Text = Midterm_data.Filipino_Midterm.ToString();
                txt_MidScience.Text = Midterm_data.Science_Midterm.ToString();
                lbl_avgMidterm.Text = Midterm_data.Period_Avg_Midterm.ToString();
                lbl_StatusMidterm.Text = Midterm_data.Period_Status_MIdterm;
            }
            else
            {
                goto inputdata;
            }

            if (database.Final_Status == "Done")
            {
                // if true , display the stored data
                txt_FinMapeh.Text = Final_data.Mapeh_Final.ToString();
                txt_FinEnglish.Text = Final_data.English_Final.ToString();
                txt_FinMath.Text = Final_data.Math_Final.ToString();
                txt_FinFilipino.Text = Final_data.Filipino_Final.ToString();
                txt_FinScience.Text = Final_data.Science_Final.ToString();
                lbl_avgFinal.Text = Final_data.Period_Avg_Final.ToString();
                lbl_StatusFinal.Text = Final_data.Period_Status_Final;

                OverALL_Calculation();
           
            }
            else
            {
                goto inputdata;
            }



        inputdata:
            //based reference
            switch (gradelevel)
            {

               

                //To display student iNFO
                case 1: { Students_Added(); } break;
                case 2: { Students_Added(); } break;
                case 3: { Students_Added(); } break;
                case 4: { Students_Added(); } break;
                case 5: { Students_Added(); } break;
                case 6: { Students_Added(); } break;

            }

        }

        private void btn_inputGradeBack_Click(object sender, EventArgs e)
        {
            EditGrades eg = new EditGrades();
            eg.ID = ID;
            eg.Show();
            this.Close();
        }

        private void btn_UpdatePrelim_Click(object sender, EventArgs e)
        {
            CheckTextBox_Prelim();
        }

        private void btn_UpdateMidterm_Click(object sender, EventArgs e)
        {
            CheckTextBox_Midterm();
        }

        private void btn_UpdateFinal_Click(object sender, EventArgs e)
        {
            CheckTextBox_Final();
        }
        private void cmb_term_SelectedIndexChanged(object sender, EventArgs e)
        {
            //mataching of Selected st udent ID on its Period
            var Prelim_data = data.tbl_Student_PrelimSubjects
                               .FirstOrDefault(p => p.FK_studentID == SelectedID);

            var Midterm_data = data.tbl_Student_MidtermSubjects
                             .FirstOrDefault(p => p.FK_studentID == SelectedID);

            var Final_data = data.tbl_Student_FinalSubjects
                         .FirstOrDefault(p => p.FK_studentID == SelectedID);


            switch (cmb_term.SelectedIndex)
            {
                case 0:
                    {
                        //hiding of panels by default 
                        pnl_Midterm.Visible = false;
                        pnl_Final.Visible = false;
                        pnl_overall.Visible = false;

                        pnl_Prelim.Visible = false;
                    }
                    break;

                case 1:
                    {
                        pnl_Midterm.Visible = false;
                        pnl_Final.Visible = false;
                        pnl_overall.Visible = false;

                        //checking the prelim avg if not null
                        if(Prelim_data != null)
                        {
                            // if true , display the stored data
                            txt_PreMapeh.Text = Prelim_data.Mapeh_Prelim.ToString();
                            txt_PreEnglish.Text = Prelim_data.English_Prelim.ToString();
                            txt_PreMath.Text = Prelim_data.Math_Prelim.ToString();
                            txt_PreFilipino.Text = Prelim_data.Filipino_Prelim.ToString();
                            txt_PreScience.Text = Prelim_data.Science_Prelim.ToString();
                            lbl_avgPrelim.Text = Prelim_data.Period_Avg_Prelim.ToString();
                            lbl_StatusPrelim.Text = Prelim_data.Period_Status_Prelim;
                            
                            
                        }
                        else
                        {
                            pnl_Prelim.Visible = true;
                            MessageBox.Show("No data inputted yet");
                        }
                        pnl_Prelim.Visible = true;


                    }
                    break;

                case 2:
                    {
                        if (lbl_avgPrelim.Text == "000")
                        {
                            alert.Prelim_avg();
                            cmb_term.SelectedIndex = 0;
                        }
                        else
                        {
                            pnl_overall.Visible = false;
                            pnl_Final.Visible = false;
                            pnl_Midterm.Visible = true;
                         

                            if (Midterm_data!= null)
                            {
                                // if true , display the stored data
                                txt_MidMapeh.Text = Midterm_data.Mapeh_Midterm.ToString();
                                txt_MidEnglish.Text = Midterm_data.English_Midterm.ToString();
                                txt_MidMath.Text = Midterm_data.Math_Midterm.ToString();
                                txt_MidFilipino.Text = Midterm_data.Filipino_Midterm.ToString();
                                txt_MidScience.Text = Midterm_data.Science_Midterm.ToString();
                                lbl_avgMidterm.Text = Midterm_data.Period_Avg_Midterm.ToString();
                                lbl_StatusMidterm.Text = Midterm_data.Period_Status_MIdterm;
                              
                            }
                            pnl_Prelim.Visible = true;

                        }

                    }
                    break;

                case 3:
                    {
                        if (lbl_avgMidterm.Text == "000")
                        {
                            alert.Midterm_avg();
                            cmb_term.SelectedIndex = 0;

                        }
                        else
                        {
                           
                            pnl_overall.Visible = false;

                            if (Final_data != null)
                            {
                              
                                // if true , display the stored data
                                txt_FinMapeh.Text = Final_data.Mapeh_Final.ToString();
                                txt_FinEnglish.Text = Final_data.English_Final.ToString();
                                txt_FinMath.Text = Final_data.Math_Final.ToString();
                                txt_FinFilipino.Text = Final_data.Filipino_Final.ToString();
                                txt_FinScience.Text = Final_data.Science_Final.ToString();
                                lbl_avgFinal.Text = Final_data.Period_Avg_Final.ToString();
                                lbl_StatusFinal.Text = Final_data.Period_Status_Final;
                              
                                OverALL_Calculation();
                                pnl_overall.Visible = true;

                            }
                            pnl_Midterm.Visible = true;
                            pnl_Prelim.Visible = true;
                            pnl_Final.Visible = true;
                        }

                    }
                    break;


            }

        }

        #region == Student Info functions ==
        void Students_Added()
        {
            //matching of student ID on database
            var database = data.tbl_Students
                            .FirstOrDefault(g => g.studentId == SelectedID);

            //assigning of textboxes
            txt_fullName.Text = $"{database.firstName} {database.lastName}".ToUpper();
            lbl_gender.Text = database.gender.ToUpper();
            lbl_studID.Text = SelectedID.ToString();
            txt_grade.Text = gradelevel.ToString();
            txt_section.Text = section.ToUpper();
        }

        #endregion

        #region == checking of textboxes
        void CheckTextBox_Prelim()
        {
            //checking the textbox if it is null
            if (string.IsNullOrWhiteSpace(txt_PreMapeh.Text) || string.IsNullOrWhiteSpace(txt_PreEnglish.Text) ||
                string.IsNullOrWhiteSpace(txt_PreMath.Text) || string.IsNullOrWhiteSpace(txt_PreFilipino.Text) ||
                string.IsNullOrWhiteSpace(txt_PreScience.Text))
            {
                alert.Fill_outGrades();
            }
            else
            {
                //procceed if not null
                Prelim_GradesCalculator();
            }
        }
      

        void CheckTextBox_Final()
        {
            if (string.IsNullOrWhiteSpace(txt_FinMapeh.Text) || string.IsNullOrWhiteSpace(txt_FinEnglish.Text) ||
                string.IsNullOrWhiteSpace(txt_FinMath.Text) || string.IsNullOrWhiteSpace(txt_FinFilipino.Text) ||
                string.IsNullOrWhiteSpace(txt_FinScience.Text))
            {
                alert.Fill_outGrades();
            }
            else
            {
                        Final_GradesCalculator();
                        
            }
        }
        void CheckTextBox_Midterm()
        {
            if (string.IsNullOrWhiteSpace(txt_MidMapeh.Text) || string.IsNullOrWhiteSpace(txt_MidEnglish.Text) ||
                string.IsNullOrWhiteSpace(txt_MidMath.Text) || string.IsNullOrWhiteSpace(txt_MidFilipino.Text) ||
                string.IsNullOrWhiteSpace(txt_MidScience.Text))
            {
                alert.Fill_outGrades();
            }
            else
            {
                       Midterm_GradesCalculator();  
            }
        }
        #endregion

        #region == Subject Calculations == 
        void Prelim_GradesCalculator()
        {


            //variables for calculations
            float[] Subjects = { Convert.ToSingle(txt_PreMapeh.Text), Convert.ToSingle(txt_PreEnglish.Text), Convert.ToSingle(txt_PreMath.Text), Convert.ToSingle(txt_PreFilipino.Text), Convert.ToSingle(txt_PreScience.Text) };



            //result (implicit casting). lambda method using its aggregation
            average = Subjects.Average();


            //assigning of status
            switch (average)
            {
                case float n when n > 101:
                    {
                        //7 spaces
                        status = "       Invalid";
                        lbl_StatusPrelim.Text = status;

                    }
                    break;
                case float n when n >= 96:
                    {
                        //for global property intended for database
                        status = "Highest Honors";

                        //assiging of the results to label status
                        lbl_StatusPrelim.Text = status;

                    }
                    break;
                case float n when n >= 93:
                    {
                        status = "High Honors";
                        lbl_StatusPrelim.Text = status;

                    }
                    break;
                case float n when n >= 89:
                    {
                        status = "With Honors";
                        lbl_StatusPrelim.Text = status;

                    }
                    break;
                case float n when n >= 75:
                    {
                        status = "      Passed";
                        lbl_StatusPrelim.Text = status;

                    }
                    break;
                case float n when n <= 75:
                    {
                        status = "       Failed";
                        lbl_StatusPrelim.Text = status;

                    }
                    break;

                default:
                    status = "invalid";
                    lbl_StatusPrelim.Text = status;
                    break;

            }



            //database injections

            if (status == "       Invalid")
            {
                alert.Invalid_Grade();
            }
            else
            {

                //assiging of the results to label average
                lbl_avgPrelim.Text = average.ToString();

                var Student_database = data.tbl_Students
                    .FirstOrDefault(st => st.studentId == SelectedID);


                var Teacher_database = data.tbl_TeacherAccs
                    .FirstOrDefault(t => t.teacherId == int.Parse(ID));

                var Teacher_name = $"{Teacher_database.firstname} {Teacher_database.lastname}";


                //passing to database

                data.SP_stud_Prelim_InputGrades(Convert.ToSingle(txt_PreMapeh.Text), Convert.ToSingle(txt_PreEnglish.Text), Convert.ToSingle(txt_PreMath.Text), Convert.ToSingle(txt_PreFilipino.Text), Convert.ToSingle(txt_PreScience.Text), average, status, SelectedID, Teacher_name);

                alert.Updated();
            }


        }
        void Midterm_GradesCalculator()
        {
            //variables for calculations
            float[] Subjects = { Convert.ToSingle(txt_MidMapeh.Text), Convert.ToSingle(txt_MidEnglish.Text), Convert.ToSingle(txt_MidMath.Text), Convert.ToSingle(txt_MidFilipino.Text), Convert.ToSingle(txt_MidScience.Text) };



            //result (implicit casting). lambda method using its aggregation
            average = Subjects.Average();

          

            //assigning of status
            switch (average)
            {
                case float n when n > 101:
                    {
                        //7 spaces
                        status = "       Invalid";
                        lbl_StatusMidterm.Text = status;

                    }
                    break;
                case float n when n >= 96:
                    {
                        //for global property intended for database
                        status = "Highest Honors";

                        //assiging of the results to label status
                        lbl_StatusMidterm.Text = status;

                    }
                    break;
                case float n when n >= 93:
                    {
                        status = "High Honors";
                        lbl_StatusMidterm.Text = status;

                    }
                    break;
                case float n when n >= 89:
                    {
                        status = "With Honors";
                        lbl_StatusMidterm.Text = status;

                    }
                    break;
                case float n when n >= 75:
                    {
                        status = "      Passed";
                        lbl_StatusMidterm.Text = status;

                    }
                    break;
                case float n when n <= 75:
                    {
                        status = "       Failed";
                        lbl_StatusMidterm.Text = status;

                    }
                    break;

                default:
                    status = "invalid";
                    lbl_StatusMidterm.Text = status;
                    break;

            }



            //database injections

            if (status == "       Invalid")
            {
                alert.Invalid_Grade();
            }
            else
            {
                //assiging of the results to label average
                lbl_avgMidterm.Text = average.ToString();

                var Student_database = data.tbl_Students
                    .FirstOrDefault(st => st.studentId == SelectedID);


                var Teacher_database = data.tbl_TeacherAccs
                    .FirstOrDefault(t => t.teacherId == int.Parse(ID));

                var Teacher_name = $"{Teacher_database.firstname} {Teacher_database.lastname}";


                //passing to database
                data.SP_stud_Midterm_InputGrades(Convert.ToSingle(txt_MidMapeh.Text), Convert.ToSingle(txt_MidEnglish.Text), Convert.ToSingle(txt_MidMath.Text), Convert.ToSingle(txt_MidFilipino.Text), Convert.ToSingle(txt_MidScience.Text), average, status, SelectedID, Teacher_name);

                alert.Updated();
            }
        }
        void Final_GradesCalculator()
        {
            //variables for calculations
            float[] Subjects = { Convert.ToSingle(txt_FinMapeh.Text), Convert.ToSingle(txt_FinEnglish.Text), Convert.ToSingle(txt_FinMath.Text), Convert.ToSingle(txt_FinFilipino.Text), Convert.ToSingle(txt_FinScience.Text) };



            //result (implicit casting). lambda method using its aggregation
            average = Subjects.Average();

         

            //assigning of status
            switch (average)
            {
                case float n when n > 101:
                    {
                        //7 spaces
                        status = "       Invalid";
                        lbl_StatusFinal.Text = status;

                    }
                    break;
                case float n when n >= 96:
                    {
                        //for global property intended for database
                        status = "Highest Honors";

                        //assiging of the results to label status
                        lbl_StatusFinal.Text = status;

                    }
                    break;
                case float n when n >= 93:
                    {
                        status = "High Honors";
                        lbl_StatusFinal.Text = status;
                      
                    }
                    break;
                case float n when n >= 89:
                    {
                        status = "With Honors";
                        lbl_StatusFinal.Text = status;

                    }
                    break;
                case float n when n >= 75:
                    {
                        status = "      Passed";
                        lbl_StatusFinal.Text = status;

                    }
                    break;
                case float n when n <= 75:
                    {
                        status = "       Failed";
                        lbl_StatusFinal.Text = status;

                    }
                    break;

                default:
                    status = "invalid";
                    lbl_StatusFinal.Text = status;
                    break;

            }

           

            //database injections

            if (status == "       Invalid")
            {
                alert.Invalid_Grade();
            }
            else
            {

                //assiging of the results to label average
                lbl_avgFinal.Text = average.ToString();

                var Student_database = data.tbl_Students
                    .FirstOrDefault(st => st.studentId == SelectedID);


                var Teacher_database = data.tbl_TeacherAccs
                    .FirstOrDefault(t => t.teacherId == int.Parse(ID));

                var Teacher_name = $"{Teacher_database.firstname} {Teacher_database.lastname}";


                //passing to database
                data.SP_stud_Final_InputGrades(Convert.ToSingle(txt_FinMapeh.Text), Convert.ToSingle(txt_FinEnglish.Text), Convert.ToSingle(txt_FinMath.Text), Convert.ToSingle(txt_FinFilipino.Text), Convert.ToSingle(txt_FinScience.Text), average, status, SelectedID, Teacher_name);

                alert.Updated();
                pnl_overall.Visible = true; 
                OverALL_Calculation();



            }
        }

        //--------------------------- OverALL calculation =======================//
        void OverALL_Calculation()

        {
            
            var Prelim_data = data.tbl_Student_PrelimSubjects
                               .FirstOrDefault(p => p.FK_studentID == SelectedID);

            var Midterm_data = data.tbl_Student_MidtermSubjects
                             .FirstOrDefault(p => p.FK_studentID == SelectedID);

            var Final_data = data.tbl_Student_FinalSubjects
                         .FirstOrDefault(p => p.FK_studentID == SelectedID);


            // get the data from database explicit datatyp casting
            float[] Mapeh = { (float)Prelim_data.Mapeh_Prelim, (float)Midterm_data.Mapeh_Midterm, (float)Final_data.Mapeh_Final };
            float[] English = { (float)Prelim_data.English_Prelim, (float)Midterm_data.Mapeh_Midterm, (float)Final_data.English_Final };
            float[] Math = { (float)Prelim_data.Math_Prelim, (float)Midterm_data.Mapeh_Midterm, (float)Final_data.Math_Final };
            float[] Filipino = { (float)Prelim_data.Filipino_Prelim, (float)Midterm_data.Mapeh_Midterm, (float)Final_data.Filipino_Final };
            float[] Science = { (float)Prelim_data.Science_Prelim, (float)Midterm_data.Mapeh_Midterm, (float)Final_data.Science_Final };

            //Calculation of its average
            float Mapeh_Sem_Avg = Mapeh.Average();
            var English_Sem_Avg = English.Average();
            var Math_Sem_Avg = Math.Average();
            var Filipino_Sem_Avg = Filipino.Average();
            var Science_Sem_Avg = Science.Average();

            //passing to label
            lbl_ovrAll_Mapeh.Text = Mapeh_Sem_Avg.ToString("F1");
            lbl_ovrAll_English.Text = English_Sem_Avg.ToString("F1");
            lbl_ovrAll_Math.Text = Math_Sem_Avg.ToString("F1");
            lbl_ovrAll_Filipino.Text = Filipino_Sem_Avg.ToString("F1");
            lbl_ovrAll_Science.Text = Science_Sem_Avg.ToString("F1");

            //array of final avg per subject
            float[] arrayOfFinalAvg = { Mapeh_Sem_Avg, English_Sem_Avg, Math_Sem_Avg, Filipino_Sem_Avg, Science_Sem_Avg };

            //CALCULATION OF OVERALL AVG
            var OverAllAvg = arrayOfFinalAvg.Average();



            lbl_ovrAll_Average.Text = OverAllAvg.ToString("F1");




            switch (OverAllAvg)
            {
                case float n when n > 101:
                    {
                        //7 spaces
                        status = "       Invalid";
                        lbl_StatusOverall.Text = status;

                    }
                    break;
                case float n when n >= 96:
                    {
                        //for global property intended for database
                        status = "Highest Honors";

                        //assiging of the results to label status
                        lbl_StatusOverall.Text = status;

                    }
                    break;
                case float n when n >= 93:
                    {
                        status = "High Honors";
                        lbl_StatusOverall.Text = status;
                      
                    }
                    break;
                case float n when n >= 89:
                    {
                        status = "With Honors";
                        lbl_StatusOverall.Text = status;

                    }
                    break;
                case float n when n >= 75:
                    {
                        status = "      Passed";
                        lbl_StatusOverall.Text = status;

                    }
                    break;
                case float n when n <= 75:
                    {
                        status = "       Failed";
                        lbl_StatusOverall.Text = status;

                    }
                    break;

                default:
                    status = "invalid";
                    lbl_StatusOverall.Text = status;
                    break;
            }
            //storedProcedure

            // float array per term

            float[] Overall_avg_Array = {Convert.ToSingle(Prelim_data.Period_Avg_Prelim), Convert.ToSingle(Midterm_data.Period_Avg_Midterm), Convert.ToSingle(Final_data.Period_Avg_Final)};


            //getting the average

            var Overall_avg_Period = Overall_avg_Array.Average();
            data.SP_stud_Grading_Avg(SelectedID, Prelim_data.Period_Avg_Prelim, Midterm_data.Period_Avg_Midterm, Final_data.Period_Avg_Final,  gradelevel, Overall_avg_Period);
         


        }
        #endregion

        //Compute methods 
        private void btn_Compute_Click(object sender, EventArgs e)
        {
            if (lbl_avgPrelim.Text == "000" || lbl_avgMidterm.Text == "000" || lbl_avgFinal.Text == "000")
            {
                alert.Fill_outGrades();
            }
            else
            {
                alert.ReadytoView();
                OverALL_Calculation();
                pnl_overall.Visible = true;
            }

        }
      
        private void lbl_StatusFinal_Click(object sender, EventArgs e)
        {

        }

        private void txt_MidMath_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnl_Final_Paint(object sender, PaintEventArgs e)
        {

        }

      
    }
}
   
