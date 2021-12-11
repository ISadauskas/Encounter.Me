using BusinessLogic;
using Database.Commands;
using System;
using System.IO;
using System.Windows.Forms;

namespace EncounterMeWF.UserControls
{
    public partial class SIgnUpSignInUC : UserControl
    {
        private SignUpSignInUCRegex _signUpSignInUCRegex = new SignUpSignInUCRegex();
        private SignInJson _signInJson = new SignInJson();
        private UserCmd _userCmd = new UserCmd();


        public SIgnUpSignInUC()
        {
            InitializeComponent();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            File.AppendAllText(@"..\..\..\..\Logging\Log.txt", "Sign up check started at: " + DateTime.Now + "\n");
            if (Check())
            {
                int Admin = 0;
                if (AdminCheckBox.Checked)
                    Admin = 1;
                _userCmd.AddUser(SignUpUsernameTextbox.Text, SignUpEmailTextbox.Text, SignUpPasswordTextbox.Text, Admin);
            }
            File.AppendAllText(@"..\..\..\..\Logging\Log.txt", "Sign up finished at: " + DateTime.Now + "\n");
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
            if (_userCmd.CheckAccount(SignInInfoTextbox.Text, SignInPasswordTextbox.Text))
            {
                _signInJson.JsonWrite(_userCmd.GetUsername(SignInInfoTextbox.Text, SignInPasswordTextbox.Text));
            }
            else
                MessageBox.Show("The account email or password that you have entered is incorrect.", "Entry Error", MessageBoxButtons.OK);
        }
    }
}
