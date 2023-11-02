using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Int_GradeSystem
{
    internal class MessageAlert
    {

        #region === login ==
        public void login_Success()
        {
            string title = "Notification";
            string message = "Successfully login";
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void login_Fail()
        {
            string title = "Notification";
            string message = "Incorrect username or password";
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void login_Input()
        {
            string title = "Notification";
            string message = "Input username or password";
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void login_Fillout()
        {
            string title = "Notification";
            string message = "Fill-out the username and password";
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        #endregion

        #region == Register &&  Update==
        public void Registered()
        {
            string title = "Notification";
            string message = "Successfully Registered";
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Password_Notmatch()
        {
            string title = "Notification";
            string message = "Password are not match";
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void Upate_Save()
        {
            string title = "Notification";
            string message = "Update Saved";
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Fillout_Form()
        {
            string title = "Notification";
            string message = "Fill-out the registration form completely";
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public void id_Notfound()
        {
            string title = "Notification";
            string message = "ID not found";
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void Select_ID()
        {
            string title = "Notification";
            string message = "Pkease select an available ID number";
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        public void Invalid_Selection()
        {
            string title = "Notification";
            string message = "There is no data/ID on the Column Title";
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        #endregion

        #region == Teacher == 
        public void Old_Password_Incorrect()
        {
            string title = "Notification";
            string message = "Old Password is incorrect";
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        public void Fillout_Form_Password()
        {
            string title = "Notification";
            string message = "Please enter the new password";
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        public void Fill_OldPassword()
        {
            string title = "Notification";
            string message = "Please enter the old Password";
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        public void Successfully_passwordUpdated()
        {
            string title = "Notification";
            string message = "Password has been changed";
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Update_Info()
        {
            string title = "Notification";
            string message = "Please update your personal information";
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        public void Successfully_Registered()
        {
            string title = "Notification";
            string message = "Registration Complete";
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //parametarized Funtion
        public void Invalid_Age(int grade, int age)
        {
            string title = "Notification";
            string message = $"Grade \"{grade}\" level will not accept below or equal to \"{age}\" years of age.";
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Incorrect_Passcode()
        {
            string title = "Notification";
            string message = $"Incorrect Passcode";
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion

    }
}