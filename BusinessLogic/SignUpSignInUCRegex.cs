using System.Text.RegularExpressions;
using Database.Commands;

namespace BusinessLogic
{
    public class SignUpSignInUCRegex
    {
        //private UsersSQL _userSQL = new UsersSQL();
        private UserCmd _userCmd = new UserCmd();

        public int Check(string SignUpUsernameText, string SignUpEmailText, string SignUpPasswordText, string SignUpConfirmPasswordText)
        {
            Regex EmailRegex = new Regex("^[A-Za-z0-9]{1,64}@[A-Za-z0-9]{3,20}.(com|net|org)$");
            bool EmailRegexCheck = EmailRegex.IsMatch(SignUpEmailText);
            Regex PasswordRegex = new Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$");
            bool PasswordRegexsCheck = PasswordRegex.IsMatch(SignUpPasswordText);
            if (SignUpUsernameText == "")
                return 1;
            //if (_userSQL.CheckIfUsernameUsed(SignUpUsernameText))
            if (_userCmd.CheckIfUsernameUsed(SignUpUsernameText))
                return 2;
            if (SignUpEmailText == "")
                return 3;
            if (!EmailRegexCheck)
                return 4;
            //if (_userSQL.CheckIfEmailUsed(SignUpEmailText))
            if (_userCmd.CheckIfEmailUsed(SignUpEmailText))
                return 5;
            if (SignUpPasswordText == "")
                return 6;
            if (!PasswordRegexsCheck)
                return 7;
            if (SignUpPasswordText != SignUpConfirmPasswordText)
                return 8;
            else
                return 0;
        }
    }
}

