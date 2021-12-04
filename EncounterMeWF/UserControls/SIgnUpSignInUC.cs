﻿using BusinessLogic;
using System;
using System.Windows.Forms;
using Database.Commands;

namespace EncounterMeWF.UserControls
{
    public partial class SIgnUpSignInUC : UserControl
    {
        private User _user = new User();
        private SignUpSignInUCRegex _signUpSignInUCRegex = new SignUpSignInUCRegex();
        private SignInJson _signInJson = new SignInJson();
        //private UsersSQL _userSQL = new UsersSQL();
        private UserCmd _userCmd = new UserCmd();


        public SIgnUpSignInUC()
        {
            InitializeComponent();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                int Admin = 0;
                //User TempUser = _user.CreateUser(Username: SignUpUsernameTextbox.Text, Email: SignUpEmailTextbox.Text, Password: SignUpPasswordTextbox.Text, IsAdmin: AdminCheckBox.Checked);
                if (AdminCheckBox.Checked)
                    Admin = 1;
                _userCmd.AddUser(SignUpUsernameTextbox.Text, SignUpEmailTextbox.Text, SignUpPasswordTextbox.Text, Admin);
                //_userSQL.InsertUser(TempUser);
            }
        }

        public bool Check()
        {
            switch (_signUpSignInUCRegex.Check(SignUpUsernameTextbox.Text, SignUpEmailTextbox.Text, SignUpPasswordTextbox.Text, SignUpConfirmPasswordTextbox.Text))
            {
                case 1:
                    MessageBox.Show("Please enter Username", "Entry Error", MessageBoxButtons.OK);
                    return false;
                case 2:
                    MessageBox.Show("This username has been already used", "Entry Error", MessageBoxButtons.OK);
                    return false;
                case 3:
                    MessageBox.Show("Please enter Email", "Entry Error", MessageBoxButtons.OK);
                    return false;
                case 4:
                    MessageBox.Show("Email should consist of letters and numbers, a @ and a .com|.net|.org", "Entry Error", MessageBoxButtons.OK);
                    return false;
                case 5:
                    MessageBox.Show("This email has been already used", "Entry Error", MessageBoxButtons.OK);
                    return false;
                case 6:
                    MessageBox.Show("Please enter a Password", "Entry Error", MessageBoxButtons.OK);
                    return false;
                case 7:
                    MessageBox.Show("Password should consist of at least one upper and lower case letter, " +
                    "one digit, one special character and at least 8 characters in lengths", "Entry Error", MessageBoxButtons.OK);
                    return false;
                case 8:
                    MessageBox.Show("Please enter the same Password", "Entry Error", MessageBoxButtons.OK);
                    return false;
                case 0:
                    return true;
            }
            return true;
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            //if (_userSQL.CheckAccount(SignInInfoTextbox.Text, SignInPasswordTextbox.Text) == false)
            if (_userCmd.CheckAccount(SignInInfoTextbox.Text, SignInPasswordTextbox.Text))
            {
                _signInJson.JsonWrite(_userCmd.GetUsername(SignInInfoTextbox.Text, SignInPasswordTextbox.Text));
            }
            else
                MessageBox.Show("The account email or password that you have entered is incorrect.", "Entry Error", MessageBoxButtons.OK);
        }
    }
}
