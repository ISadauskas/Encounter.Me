using BusinessLogic;
using System;
using System.ComponentModel;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace EncounterMeWF.UserControls
{
    public partial class SIgnUpSignInUC : UserControl
    {
        private UserJson _userJson = new UserJson();
        private User _user = new User();
        private LoginJson _loginJson = new LoginJson();
        private mainForm _mainForm = new mainForm();
        BindingList<User> UserList = new BindingList<User>();

        public SIgnUpSignInUC()
        {
            InitializeComponent();
            if (File.Exists("Trails.json"))
                UserList = _userJson.JsonRead();
            else
                _userJson.JsonWrite(UserList);
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            if (Check())
            { 
                User TempUser = _user.CreateUser(Username: SignUpUsernameTextbox.Text, Email: SignUpEmailTextbox.Text, Password: SignUpPasswordTextbox.Text);
                UserList.Add(TempUser);

                _userJson.JsonWrite(UserList);
            }
        }

        private bool Check()
        {
            Regex EmailRegex = new Regex("^[A-Za-z0-9]{1,64}@[A-Za-z0-9]{3,20}.(com|net|org)$");
            bool EmailRegexCheck = EmailRegex.IsMatch(SignUpEmailTextbox.Text);
            Regex PasswordRegex = new Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$");
            bool PasswordRegexsCheck = PasswordRegex.IsMatch(SignUpPasswordTextbox.Text);
            if (SignUpUsernameTextbox.Text == "")
            {
                MessageBox.Show("Please enter Username", "Entry Error", MessageBoxButtons.OK);
                return false;
            }
            if (_user.CheckIfUsedUsername(UserList, SignUpUsernameTextbox.Text))
            {
                MessageBox.Show("This username has been already used", "Entry Error", MessageBoxButtons.OK);
                return false;
            }
            if (SignUpEmailTextbox.Text == "")
            {
                MessageBox.Show("Please enter Email", "Entry Error", MessageBoxButtons.OK);
                return false;
            }
            if (!EmailRegexCheck)
            {
                MessageBox.Show("Email should consist of letters and numbers, a @ and a .com|.net|.org", "Entry Error", MessageBoxButtons.OK);
                return false;
            }
            if (_user.CheckIfUsedEmail(UserList, SignUpEmailTextbox.Text))
            {
                MessageBox.Show("This email has been already used", "Entry Error", MessageBoxButtons.OK);
                return false;
            }
            if (SignUpPasswordTextbox.Text == "")
            {
                MessageBox.Show("Please enter a Password", "Entry Error", MessageBoxButtons.OK);
                return false;
            }
            if (!PasswordRegexsCheck)
            {
                MessageBox.Show("Password should consist of at least one upper and lower case letter, " +
                    "one digit, one special character and at least 8 characters in lengths", "Entry Error", MessageBoxButtons.OK);
                return false;
            }
            if (SignUpPasswordTextbox.Text != SignUpConfirmPasswordTextbox.Text)
            {
                MessageBox.Show("Please enter the same Password", "Entry Error", MessageBoxButtons.OK);
                return false;
            }
            else
                return true;
        }
        private void SignInButton_Click_1(object sender, EventArgs e)
        {
            if (_loginJson.CheckAccount(UserList, SignInEmailTextbox.Text, SignInPasswordTextbox.Text))
            {
                IndexUC uc = new IndexUC();
                _mainForm.ChangeToIndex();
            }
            else
                MessageBox.Show("The account email or password that you have entered is incorrect.", "Entry Error", MessageBoxButtons.OK);
        }
    }
}
