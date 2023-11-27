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



        /*
         * KEY CONCEPTS
         Assigning of elements from database to textboxes and labels
         Checking of null 
         Computation of Per grading quarter funtions
         
         */


        public InputGrades()
        {
            InitializeComponent();

            //fix screen flickering
            this.DoubleBuffered = true;
       

        }
        // set the WS_EX_COMPOSITED flag, which provides similar double-buffering behavior:

        private void InputGrades_Load(object sender, EventArgs e)

        {
       
            //Hidden of panels
       /*     pnl_First.Visible = false;
            pnl_Second.Visible = false;
            pnl_Third.Visible = false;
            pnl_Fourth.Visible = false;
            pnl_overall.Visible = false;*/

            //hiding of panels by default   
                        firstGradingControls_Visibility_FALSE();
                        secondGradingControls_Visibility_FALSE();
                        thirdGradingControls_Visibility_FALSE();
                        fourthGradingControls_Visibility_FALSE();
                        overAllControls_Visibility_FALSE();



            //assiging of form textbox if tbl student status is DONE

            var database = data.tbl_Students
                            .FirstOrDefault(st => st.studentId == SelectedID);
            var FirstG_data = data.tbl_Student_FirstG_Subjects
                                .FirstOrDefault(p => p.FK_studentID == SelectedID);

            var SecondG_data = data.tbl_Student_SecondG_Subjects
                             .FirstOrDefault(p => p.FK_studentID == SelectedID);

            var ThirdG_data = data.tbl_Student_ThirdG_Subjects
                         .FirstOrDefault(p => p.FK_studentID == SelectedID);


            var FourthG_data = data.tbl_Student_FourthG_Subjects
                         .FirstOrDefault(p => p.FK_studentID == SelectedID);

            if (database.First_Grading == "Done")
            {
                txt_FirstMapeh.Text = FirstG_data.Mapeh_firstG.ToString();
                txt_FirstEnglish.Text = FirstG_data.English_firstG.ToString();
                txt_FirstMath.Text = FirstG_data.Math_firstG.ToString();
                txt_FirstFilipino.Text = FirstG_data.Filipino_firstG.ToString();
                txt_FirstScience.Text = FirstG_data.Science_firstG.ToString();
                lbl_avgFirst.Text = FirstG_data.Period_Avg_firstG.ToString();
                lbl_StatusFirst.Text = FirstG_data.Period_Status_firstG;
            }
            else
            {
                goto inputdata;
            }

            if (database.Second_Grading == "Done")
            {
                // if true , display the stored data
                txt_SecondMapeh.Text = SecondG_data.Mapeh_SecondG.ToString();
                txt_SecondEnglish.Text = SecondG_data.English_SecondG.ToString();
                txt_SecondMath.Text = SecondG_data.Math_SecondG.ToString();
                txt_SecondFilipino.Text = SecondG_data.Filipino_SecondG.ToString();
                txt_SecondScience.Text = SecondG_data.Science_SecondG.ToString();
                lbl_avgSecond.Text = SecondG_data.Period_Avg_SecondG.ToString();
                lbl_StatusSecond.Text = SecondG_data.Period_Status_SecondG;
            }
            else
            {
                goto inputdata;
            }

            if (database.Third_Grading == "Done")
            {
                // if true , display the stored data
                txt_ThirdMapeh.Text = ThirdG_data.Mapeh_ThirdG.ToString();
                txt_ThirdEnglish.Text = ThirdG_data.English_ThirdG.ToString();
                txt_ThirdMath.Text = ThirdG_data.Math_ThirdG.ToString();
                txt_ThirdFilipino.Text = ThirdG_data.Filipino_ThirdG.ToString();
                txt_ThirdScience.Text = ThirdG_data.Science_ThirdG.ToString();
                lbl_avgThird.Text = ThirdG_data.Period_Avg_ThirdG.ToString();
                lbl_StatusThird.Text = ThirdG_data.Period_Status_ThirdG;



            }

            else
            {
                goto inputdata;
            }

            if (database.Fourth_Grading == "Done")
            {
                // if true , display the stored data
                txt_FourthMapeh.Text = FourthG_data.Mapeh_FourthG.ToString();
                txt_FourthEnglish.Text = FourthG_data.English_FourthG.ToString();
                txt_FourthMath.Text = FourthG_data.Math_FourthG.ToString();
                txt_FourthFilipino.Text = FourthG_data.Filipino_FourthG.ToString();
                txt_FourthScience.Text = FourthG_data.Science_FourthG.ToString();
                lbl_avgFourth.Text = FourthG_data.Period_Avg_FourthG.ToString();
                lbl_StatusFourth.Text = FourthG_data.Period_Status_FourthG;

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

            this.Close();
        }

        //Buttons per grading Events
        private void btn_UpdateFirst_Click(object sender, EventArgs e)
        {
            CheckTextBox_First();
        }
        private void btn_UpdateSecond_Click(object sender, EventArgs e)
        {
            CheckTextBox_Second();
        }

        private void btn_UpdateThird_Click(object sender, EventArgs e)
        {
            CheckTextBox_Third();
        }
        private void btn_UpdateFourth_Click_1(object sender, EventArgs e)
        {
            CheckTextBox_Fourth();
        }

        #region == panel sets ==

        //FALSE
            void firstGradingControls_Visibility_FALSE()
        {
            txt_FirstMapeh.Visible= false;
            txt_FirstEnglish.Visible = false;
            txt_FirstMath.Visible = false;
            txt_FirstFilipino.Visible = false;
            txt_FirstScience.Visible = false;
            lbl_avgFirst.Visible = false;
            lbl_StatusFirst.Visible = false;
            btn_UpdateFirst.Visible=false;
        }
        void secondGradingControls_Visibility_FALSE()
        {
            txt_SecondMapeh.Visible = false;
            txt_SecondEnglish.Visible = false;
            txt_SecondMath.Visible = false;
            txt_SecondFilipino.Visible = false;
            txt_SecondScience.Visible = false;
            lbl_avgSecond.Visible = false;
            lbl_StatusSecond.Visible = false;
            btn_UpdateSecond.Visible = false;
        }
        void thirdGradingControls_Visibility_FALSE()
        {
            txt_ThirdMapeh.Visible = false;
            txt_ThirdEnglish.Visible = false;
            txt_ThirdMath.Visible = false;
            txt_ThirdFilipino.Visible = false;
            txt_ThirdScience.Visible = false;
            lbl_avgThird.Visible = false;
            lbl_StatusThird.Visible = false;
            btn_UpdateThird.Visible = false;
        }
        void fourthGradingControls_Visibility_FALSE()
        {
            txt_FourthMapeh.Visible = false;
            txt_FourthEnglish.Visible = false;
            txt_FourthMath.Visible = false;
            txt_FourthFilipino.Visible = false;
            txt_FourthScience.Visible = false;
            lbl_avgFourth.Visible = false;
            lbl_StatusFourth.Visible = false;
            btn_UpdateFourth.Visible = false;
        }

        void overAllControls_Visibility_FALSE()
        {
            lbl_ovrAll_Mapeh.Visible = false;
            lbl_ovrAll_English.Visible = false;
            lbl_ovrAll_Math.Visible = false;
            lbl_ovrAll_Filipino.Visible = false;
            lbl_ovrAll_Science.Visible = false;
            lbl_ovrAll_Average.Visible = false;
            lbl_StatusOverall.Visible = false;
            btn_Compute.Visible = false;
        }
        //TRUE
        void firstGradingControls_Visibility_TRUE()
        {
            txt_FirstMapeh.Visible = true;
            txt_FirstEnglish.Visible = true;
            txt_FirstMath.Visible = true;
            txt_FirstFilipino.Visible = true;
            txt_FirstScience.Visible = true;
            lbl_avgFirst.Visible = true;
            lbl_StatusFirst.Visible = true;
            btn_UpdateFirst.Visible = true;
        }
        void secondGradingControls_Visibility_TRUE()
        {
            txt_SecondMapeh.Visible = true;
            txt_SecondEnglish.Visible = true;
            txt_SecondMath.Visible = true;
            txt_SecondFilipino.Visible = true;
            txt_SecondScience.Visible = true;
            lbl_avgSecond.Visible = true;
            lbl_StatusSecond.Visible = true;
            btn_UpdateSecond.Visible = true;
        }
        void thirdGradingControls_Visibility_TRUE()
        {
            txt_ThirdMapeh.Visible = true;
            txt_ThirdEnglish.Visible = true;
            txt_ThirdMath.Visible = true;
            txt_ThirdFilipino.Visible = true;
            txt_ThirdScience.Visible = true;
            lbl_avgThird.Visible = true;
            lbl_StatusThird.Visible = true;
            btn_UpdateThird.Visible = true;
        }
        void fourthGradingControls_Visibility_TRUE()
        {
            txt_FourthMapeh.Visible = true;
            txt_FourthEnglish.Visible = true;
            txt_FourthMath.Visible = true;
            txt_FourthFilipino.Visible = true;
            txt_FourthScience.Visible = true;
            lbl_avgFourth.Visible = true;
            lbl_StatusFourth.Visible = true;
            btn_UpdateFourth.Visible = true;
        }
        void overAllControls_Visibility_TRUE()
        {
            lbl_ovrAll_Mapeh.Visible = true;
            lbl_ovrAll_English.Visible = true;
            lbl_ovrAll_Math.Visible = true;
            lbl_ovrAll_Filipino.Visible = true;
            lbl_ovrAll_Science.Visible = true;
            lbl_ovrAll_Average.Visible = true;
            lbl_StatusOverall.Visible = true;
            btn_Compute.Visible = true;
        }
        #endregion

        private void cmb_term_SelectedIndexChanged(object sender, EventArgs e)
        {
            //mataching of Selected st udent ID on its Period
            var FirstG_data = data.tbl_Student_FirstG_Subjects
                               .FirstOrDefault(p => p.FK_studentID == SelectedID);

            var SecondG_data = data.tbl_Student_SecondG_Subjects
                             .FirstOrDefault(p => p.FK_studentID == SelectedID);

            var ThirdG_data = data.tbl_Student_ThirdG_Subjects
                         .FirstOrDefault(p => p.FK_studentID == SelectedID);


            var FourthG_data = data.tbl_Student_FourthG_Subjects
                         .FirstOrDefault(p => p.FK_studentID == SelectedID);

            switch (cmb_term.SelectedIndex)
            {
                case 0:
                    {
                        //hiding of panels by default 
                      
                        firstGradingControls_Visibility_FALSE();
                        secondGradingControls_Visibility_FALSE();
                        thirdGradingControls_Visibility_FALSE();
                        fourthGradingControls_Visibility_FALSE();
                        overAllControls_Visibility_FALSE();
                    


                    }
                    break;

                case 1:
                    {
                        /* pnl_Second.Visible = false;
                         pnl_Third.Visible = false;
                         pnl_Fourth.Visible = false;
                         pnl_overall.Visible = false;*/

                        secondGradingControls_Visibility_FALSE();
                        thirdGradingControls_Visibility_FALSE();
                        fourthGradingControls_Visibility_FALSE();
                        overAllControls_Visibility_FALSE();

                        //checking the prelim avg if not null
                        if (FirstG_data != null)
                        {
                            // if true , display the stored data
                            txt_FirstMapeh.Text = FirstG_data.Mapeh_firstG.ToString();
                            txt_FirstEnglish.Text = FirstG_data.English_firstG.ToString();
                            txt_FirstMath.Text = FirstG_data.Math_firstG.ToString();
                            txt_FirstFilipino.Text = FirstG_data.Filipino_firstG.ToString();
                            txt_FirstScience.Text = FirstG_data.Science_firstG.ToString();
                            lbl_avgFirst.Text = FirstG_data.Period_Avg_firstG.ToString();
                            lbl_StatusFirst.Text = FirstG_data.Period_Status_firstG;


                        }
                        else
                        {
                            firstGradingControls_Visibility_TRUE();
                            MessageBox.Show("No data inputted yet");
                        }
                        firstGradingControls_Visibility_TRUE();


                    }
                    break;

                case 2:
                    {
                        if (lbl_avgFirst.Text == "000")
                        {
                            alert.FirstGrading_avg();
                            cmb_term.SelectedIndex = 0;
                        }
                        else
                        {
                            secondGradingControls_Visibility_TRUE();

                            thirdGradingControls_Visibility_FALSE();
                            fourthGradingControls_Visibility_FALSE();
                            overAllControls_Visibility_FALSE();

                          /*  pnl_Second.Visible = true;
                            pnl_Third.Visible = false;
                            pnl_Fourth.Visible = false;
                            pnl_overall.Visible = false;*/




                            if (SecondG_data != null)
                            {
                                // if true , display the stored data
                                txt_SecondMapeh.Text = SecondG_data.Mapeh_SecondG.ToString();
                                txt_SecondEnglish.Text = SecondG_data.English_SecondG.ToString();
                                txt_SecondMath.Text = SecondG_data.Math_SecondG.ToString();
                                txt_SecondFilipino.Text = SecondG_data.Filipino_SecondG.ToString();
                                txt_SecondScience.Text = SecondG_data.Science_SecondG.ToString();
                                lbl_avgSecond.Text = SecondG_data.Period_Avg_SecondG.ToString();
                                lbl_StatusSecond.Text = SecondG_data.Period_Status_SecondG;

                            }
                            secondGradingControls_Visibility_TRUE();

                        }

                    }
                    break;


                case 3:
                    {
                        if (lbl_avgSecond.Text == "000")
                        {
                            alert.SecondGrading_avg();
                            cmb_term.SelectedIndex = 0;

                        }
                        else
                        {
                          
                            fourthGradingControls_Visibility_FALSE();
                            overAllControls_Visibility_FALSE();

                           /* pnl_overall.Visible = false;
                            pnl_Fourth.Visible = false;*/

                            if (ThirdG_data != null)
                            {

                                // if true , display the stored data
                                txt_ThirdMapeh.Text = ThirdG_data.Mapeh_ThirdG.ToString();
                                txt_ThirdEnglish.Text = ThirdG_data.English_ThirdG.ToString();
                                txt_ThirdMath.Text = ThirdG_data.Math_ThirdG.ToString();
                                txt_ThirdFilipino.Text = ThirdG_data.Filipino_ThirdG.ToString();
                                txt_ThirdScience.Text = ThirdG_data.Science_ThirdG.ToString();
                                lbl_avgThird.Text = ThirdG_data.Period_Avg_ThirdG.ToString();
                                lbl_StatusThird.Text = ThirdG_data.Period_Status_ThirdG;



                            }
                            firstGradingControls_Visibility_TRUE();
                            secondGradingControls_Visibility_TRUE();                       
                            thirdGradingControls_Visibility_TRUE();
                          /*  pnl_Second.Visible = true;
                            pnl_First.Visible = true;
                            pnl_Third.Visible = true;*/

                        }

                    }
                    break;

                case 4:
                    {
                        if (lbl_avgThird.Text == "000")
                        {
                            alert.ThirdGrading_avg();
                            cmb_term.SelectedIndex = 0;

                        }
                        else
                        {

                            overAllControls_Visibility_FALSE();
                            /*   pnl_overall.Visible = false;*/

                            if (FourthG_data != null)
                            {

                                // if true , display the stored data
                                txt_ThirdMapeh.Text = FourthG_data.Mapeh_FourthG.ToString();
                                txt_ThirdEnglish.Text = FourthG_data.English_FourthG.ToString();
                                txt_ThirdMath.Text = FourthG_data.Math_FourthG.ToString();
                                txt_ThirdFilipino.Text = FourthG_data.Filipino_FourthG.ToString();
                                txt_ThirdScience.Text = FourthG_data.Science_FourthG.ToString();
                                lbl_avgThird.Text = FourthG_data.Period_Avg_FourthG.ToString();
                                lbl_StatusThird.Text = FourthG_data.Period_Status_FourthG;

                                OverALL_Calculation();
                                overAllControls_Visibility_TRUE();
                             /*   pnl_overall.Visible = true;*/

                            }

                            firstGradingControls_Visibility_TRUE();
                            secondGradingControls_Visibility_TRUE();
                            thirdGradingControls_Visibility_TRUE();
                            fourthGradingControls_Visibility_TRUE();
                         /*   pnl_First.Visible = true;
                            pnl_Second.Visible = true;
                            pnl_Third.Visible = true;
                            pnl_Fourth.Visible = true*/;
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
        void CheckTextBox_First()
        {
            //checking the textbox if it is null
            if (string.IsNullOrWhiteSpace(txt_FirstMapeh.Text) || string.IsNullOrWhiteSpace(txt_FirstEnglish.Text) ||
                string.IsNullOrWhiteSpace(txt_FirstMath.Text) || string.IsNullOrWhiteSpace(txt_FirstFilipino.Text) ||
                string.IsNullOrWhiteSpace(txt_FirstScience.Text))
            {
                alert.Fill_outGrades();
            }
            else
            {
                //procceed if not null
                FirstGrading_Calculation();
            }
        }

        void CheckTextBox_Second()
        {
            if (string.IsNullOrWhiteSpace(txt_SecondMapeh.Text) || string.IsNullOrWhiteSpace(txt_SecondEnglish.Text) ||
                string.IsNullOrWhiteSpace(txt_SecondMath.Text) || string.IsNullOrWhiteSpace(txt_SecondFilipino.Text) ||
                string.IsNullOrWhiteSpace(txt_SecondScience.Text))
            {
                alert.Fill_outGrades();
            }
            else
            {
                SecondGrading_Calculation();
            }


        }
        void CheckTextBox_Third()
        {
            if (string.IsNullOrWhiteSpace(txt_ThirdMapeh.Text) || string.IsNullOrWhiteSpace(txt_ThirdEnglish.Text) ||
                string.IsNullOrWhiteSpace(txt_ThirdMath.Text) || string.IsNullOrWhiteSpace(txt_ThirdFilipino.Text) ||
                string.IsNullOrWhiteSpace(txt_ThirdScience.Text))
            {
                alert.Fill_outGrades();
            }
            else
            {
                ThirdGrading_Calculation();

            }
        }

        void CheckTextBox_Fourth()
        {
            if (string.IsNullOrWhiteSpace(txt_FourthMapeh.Text) || string.IsNullOrWhiteSpace(txt_FourthEnglish.Text) ||
                string.IsNullOrWhiteSpace(txt_FourthMath.Text) || string.IsNullOrWhiteSpace(txt_FourthFilipino.Text) ||
                string.IsNullOrWhiteSpace(txt_FourthScience.Text))
            {
                alert.Fill_outGrades();
            }
            else
            {
                FourthGrading_Calculation();

            }
        }

        #endregion

        #region == Subject Calculations == 
        void FirstGrading_Calculation()
        {
            //uses try catch for handling ERRORS if users will input special character
            try
            {
                //variables for calculations
                float[] Subjects = { Convert.ToSingle(txt_FirstMapeh.Text), Convert.ToSingle(txt_FirstEnglish.Text), Convert.ToSingle(txt_FirstMath.Text), Convert.ToSingle(txt_FirstFilipino.Text), Convert.ToSingle(txt_FirstScience.Text) };



                //result (implicit casting). lambda method using its aggregation
                average = Subjects.Average();

                //assigning of status
                switch (average)
                {
                    case float n when n > 101:
                        {
                            //7 spaces
                            status = "       Invalid";
                            lbl_StatusFirst.Text = status;

                        }
                        break;
                    case float n when n >= 96:
                        {
                            //for global property intended for database
                            status = "Highest Honors";

                            //assiging of the results to label status
                            lbl_StatusFirst.Text = status;

                        }
                        break;
                    case float n when n >= 93:
                        {
                            status = "High Honors";
                            lbl_StatusFirst.Text = status;

                        }
                        break;
                    case float n when n >= 89:
                        {
                            status = "With Honors";
                            lbl_StatusFirst.Text = status;

                        }
                        break;
                    case float n when n >= 75:
                        {
                            status = "      Passed";
                            lbl_StatusFirst.Text = status;

                        }
                        break;
                    case float n when n <= 75:
                        {
                            status = "       Failed";
                            lbl_StatusFirst.Text = status;

                        }
                        break;

                    default:
                        status = "invalid";
                        lbl_StatusFirst.Text = status;
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
                    lbl_avgFirst.Text = average.ToString();

                    var Student_database = data.tbl_Students
                        .FirstOrDefault(st => st.studentId == SelectedID);


                    var Teacher_database = data.tbl_TeacherAccs
                        .FirstOrDefault(t => t.teacherId == int.Parse(ID));

                    var Teacher_name = $"{Teacher_database.firstname} {Teacher_database.lastname}";


                    //passing to database

                    data.SP_stud_InputGrades_FirstGrading(Convert.ToSingle(txt_FirstMapeh.Text), Convert.ToSingle(txt_FirstEnglish.Text), Convert.ToSingle(txt_FirstMath.Text), Convert.ToSingle(txt_FirstFilipino.Text), Convert.ToSingle(txt_FirstScience.Text), average, status, SelectedID, Teacher_name);

                    alert.Updated();
                }


            }
            catch (Exception ex)
            {
                alert.SpecialCharacter_Error();

            }

        }
        void SecondGrading_Calculation()
        {
            try
            {
                //variables for calculations
                float[] Subjects = { Convert.ToSingle(txt_SecondMapeh.Text), Convert.ToSingle(txt_SecondEnglish.Text), Convert.ToSingle(txt_SecondMath.Text), Convert.ToSingle(txt_SecondFilipino.Text), Convert.ToSingle(txt_SecondScience.Text) };



                //result (implicit casting). lambda method using its aggregation
                average = Subjects.Average();



                //assigning of status
                switch (average)
                {
                    case float n when n > 101:
                        {
                            //7 spaces
                            status = "       Invalid";
                            lbl_StatusSecond.Text = status;

                        }
                        break;
                    case float n when n >= 96:
                        {
                            //for global property intended for database
                            status = "Highest Honors";

                            //assiging of the results to label status
                            lbl_StatusSecond.Text = status;

                        }
                        break;
                    case float n when n >= 93:
                        {
                            status = "High Honors";
                            lbl_StatusSecond.Text = status;

                        }
                        break;
                    case float n when n >= 89:
                        {
                            status = "With Honors";
                            lbl_StatusSecond.Text = status;

                        }
                        break;
                    case float n when n >= 75:
                        {
                            status = "      Passed";
                            lbl_StatusSecond.Text = status;

                        }
                        break;
                    case float n when n <= 75:
                        {
                            status = "       Failed";
                            lbl_StatusSecond.Text = status;

                        }
                        break;

                    default:
                        status = "invalid";
                        lbl_StatusSecond.Text = status;
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
                    lbl_avgSecond.Text = average.ToString();

                    var Student_database = data.tbl_Students
                        .FirstOrDefault(st => st.studentId == SelectedID);


                    var Teacher_database = data.tbl_TeacherAccs
                        .FirstOrDefault(t => t.teacherId == int.Parse(ID));

                    var Teacher_name = $"{Teacher_database.firstname} {Teacher_database.lastname}";


                    //passing to database
                    data.SP_stud_InputGrades_SecondGrading(Convert.ToSingle(txt_SecondMapeh.Text), Convert.ToSingle(txt_SecondEnglish.Text), Convert.ToSingle(txt_SecondMath.Text), Convert.ToSingle(txt_SecondFilipino.Text), Convert.ToSingle(txt_SecondScience.Text), average, status, SelectedID, Teacher_name);

                    alert.Updated();
                }
            }
            catch
            {
                alert.SpecialCharacter_Error();
            }
          
        }
        void ThirdGrading_Calculation()
        {
            try
            {
                //variables for calculations
                float[] Subjects = { Convert.ToSingle(txt_ThirdMapeh.Text), Convert.ToSingle(txt_ThirdEnglish.Text), Convert.ToSingle(txt_ThirdMath.Text), Convert.ToSingle(txt_ThirdFilipino.Text), Convert.ToSingle(txt_ThirdScience.Text) };



                //result (implicit casting). lambda method using its aggregation
                average = Subjects.Average();



                //assigning of status
                switch (average)
                {
                    case float n when n > 101:
                        {
                            //7 spaces
                            status = "       Invalid";
                            lbl_StatusThird.Text = status;

                        }
                        break;
                    case float n when n >= 96:
                        {
                            //for global property intended for database
                            status = "Highest Honors";

                            //assiging of the results to label status
                            lbl_StatusThird.Text = status;

                        }
                        break;
                    case float n when n >= 93:
                        {
                            status = "High Honors";
                            lbl_StatusThird.Text = status;

                        }
                        break;
                    case float n when n >= 89:
                        {
                            status = "With Honors";
                            lbl_StatusThird.Text = status;

                        }
                        break;
                    case float n when n >= 75:
                        {
                            status = "      Passed";
                            lbl_StatusThird.Text = status;

                        }
                        break;
                    case float n when n <= 75:
                        {
                            status = "       Failed";
                            lbl_StatusThird.Text = status;

                        }
                        break;

                    default:
                        status = "invalid";
                        lbl_StatusThird.Text = status;
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
                    lbl_avgThird.Text = average.ToString();

                    var Student_database = data.tbl_Students
                        .FirstOrDefault(st => st.studentId == SelectedID);


                    var Teacher_database = data.tbl_TeacherAccs
                        .FirstOrDefault(t => t.teacherId == int.Parse(ID));

                    var Teacher_name = $"{Teacher_database.firstname} {Teacher_database.lastname}";


                    //passing to database
                    data.SP_stud_InputGrades_ThirdGrading(Convert.ToSingle(txt_ThirdMapeh.Text), Convert.ToSingle(txt_ThirdEnglish.Text), Convert.ToSingle(txt_ThirdMath.Text), Convert.ToSingle(txt_ThirdFilipino.Text), Convert.ToSingle(txt_ThirdScience.Text), average, status, SelectedID, Teacher_name);

                    alert.Updated();

                }
            }

            catch
            {
                alert.SpecialCharacter_Error();
            }
        }
        void FourthGrading_Calculation()
        {
            try
            {
                //variables for calculations
                float[] Subjects = { Convert.ToSingle(txt_FourthMapeh.Text), Convert.ToSingle(txt_FourthEnglish.Text), Convert.ToSingle(txt_FourthMath.Text), Convert.ToSingle(txt_FourthFilipino.Text), Convert.ToSingle(txt_FourthScience.Text) };



                //result (implicit casting). lambda method using its aggregation
                average = Subjects.Average();



                //assigning of status
                switch (average)
                {
                    case float n when n > 101:
                        {
                            //7 spaces
                            status = "       Invalid";
                            lbl_StatusFourth.Text = status;

                        }
                        break;
                    case float n when n >= 96:
                        {
                            //for global property intended for database
                            status = "Highest Honors";

                            //assiging of the results to label status
                            lbl_StatusFourth.Text = status;

                        }
                        break;
                    case float n when n >= 93:
                        {
                            status = "High Honors";
                            lbl_StatusFourth.Text = status;

                        }
                        break;
                    case float n when n >= 89:
                        {
                            status = "With Honors";
                            lbl_StatusFourth.Text = status;

                        }
                        break;
                    case float n when n >= 75:
                        {
                            status = "      Passed";
                            lbl_StatusFourth.Text = status;

                        }
                        break;
                    case float n when n <= 75:
                        {
                            status = "       Failed";
                            lbl_StatusFourth.Text = status;

                        }
                        break;

                    default:
                        status = "invalid";
                        lbl_StatusFourth.Text = status;
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
                    lbl_avgFourth.Text = average.ToString();

                    var Student_database = data.tbl_Students
                        .FirstOrDefault(st => st.studentId == SelectedID);


                    var Teacher_database = data.tbl_TeacherAccs
                        .FirstOrDefault(t => t.teacherId == int.Parse(ID));

                    var Teacher_name = $"{Teacher_database.firstname} {Teacher_database.lastname}";


                    //passing to database
                    data.SP_stud_InputGrades_FourthGrading(Convert.ToSingle(txt_FourthMapeh.Text), Convert.ToSingle(txt_FourthEnglish.Text), Convert.ToSingle(txt_FourthMath.Text), Convert.ToSingle(txt_FourthFilipino.Text), Convert.ToSingle(txt_FourthScience.Text), average, status, SelectedID, Teacher_name);

                    alert.Updated();
                    /*  pnl_overall.Visible = true;*/
                    overAllControls_Visibility_TRUE();
                    OverALL_Calculation();



                }
            }
            catch
            {
                alert.SpecialCharacter_Error();
            }
        }

        //--------------------------- OverALL calculation =======================//
        void OverALL_Calculation()

        {
            //DATA FROM DATABASES
            var First_data = data.tbl_Student_FirstG_Subjects
                               .FirstOrDefault(p => p.FK_studentID == SelectedID);

            var Second_data = data.tbl_Student_SecondG_Subjects
                             .FirstOrDefault(p => p.FK_studentID == SelectedID);

            var Third_data = data.tbl_Student_ThirdG_Subjects
                         .FirstOrDefault(p => p.FK_studentID == SelectedID);

            var Fourth_data = data.tbl_Student_FourthG_Subjects
                       .FirstOrDefault(p => p.FK_studentID == SelectedID);


            // get the data from database explicit datatyp casting
            float[] Mapeh = { (float)First_data.Mapeh_firstG, (float)Second_data.Mapeh_SecondG, (float)Third_data.Mapeh_ThirdG, (float)Fourth_data.Mapeh_FourthG };

            float[] English = { (float)First_data.English_firstG, (float)Second_data.English_SecondG, (float)Third_data.English_ThirdG, (float)Fourth_data.English_FourthG };

            float[] Math = { (float)First_data.Math_firstG, (float)Second_data.Math_SecondG, (float)Third_data.Math_ThirdG, (float)Fourth_data.Math_FourthG };

            float[] Filipino = { (float)First_data.Filipino_firstG, (float)Second_data.Filipino_SecondG, (float)Third_data.Filipino_ThirdG, (float)Fourth_data.Filipino_FourthG };

            float[] Science = { (float)First_data.Science_firstG, (float)Second_data.Science_SecondG, (float)Third_data.Science_ThirdG, (float)Fourth_data.Science_FourthG };

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

            float[] Overall_avg_Array = { Convert.ToSingle(First_data.Period_Avg_firstG), Convert.ToSingle(Second_data.Period_Avg_SecondG), Convert.ToSingle(Third_data.Period_Avg_ThirdG), Convert.ToSingle(Fourth_data.Period_Avg_FourthG) };


            //getting the average


            var Overall_avg_Period = Overall_avg_Array.Average();
            data.SP_stud_Grading_Avg(SelectedID, First_data.Period_Avg_firstG, Second_data.Period_Avg_SecondG, Third_data.Period_Avg_ThirdG, Fourth_data.Period_Avg_FourthG, gradelevel, Overall_avg_Period);



        }
        #endregion

        //Compute methods 
        private void btn_Compute_Click(object sender, EventArgs e)
        {
            if (lbl_avgFirst.Text == "000" || lbl_avgSecond.Text == "000" || lbl_avgThird.Text == "000")
            {
                alert.Fill_outGrades();
            }
            else
            {
                alert.ReadytoView();
                OverALL_Calculation();
                /* pnl_overall.Visible = true;*/
                overAllControls_Visibility_TRUE();
            }

        }

        private void btn_inputGradeBack_Click_1(object sender, EventArgs e)
        {

            this.Close();
            
        }


        #region == empty controls ==
        private void lbl_StatusFinal_Click(object sender, EventArgs e)
        {

        }

        private void txt_MidMath_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnl_Final_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_fullName_Click(object sender, EventArgs e)
        {

        }

        private void txt_grade_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pnl_First_Paint(object sender, PaintEventArgs e)
        {
    
        }



        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnl_Second_Paint(object sender, PaintEventArgs e)
        {
            //fix screen flickering
            this.DoubleBuffered = true;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            //fix screen flickering
            this.DoubleBuffered = true;
        }

        private void lbl_studID_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txt_section_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void lbl_gender_Click(object sender, EventArgs e)
        {

        }

        private void pnl_overall_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnl_Fourth_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_avgFirst_Click(object sender, EventArgs e)
        {

        }

        private void txt_FirstMapeh_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_FirstEnglish_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_FirstMath_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_FirstFilipino_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_FirstScience_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_SecondScience_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

     
    }
    #endregion
 }



