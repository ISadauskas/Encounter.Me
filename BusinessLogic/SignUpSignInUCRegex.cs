using System.ComponentModel;
using System.Text.RegularExpressions;

namespace BusinessLogic
{
    public class SignUpSignInUCRegex
    {
        private User _user = new User();
        public int Check(BindingList<User> UserList, string SignUpUsernameText, string SignUpEmailText, string SignUpPasswordText, string SignUpConfirmPasswordText)
        {
            Regex EmailRegex = new Regex("^[A-Za-z0-9]{1,64}@[A-Za-z0-9]{3,20}.(com|net|org)$");
            bool EmailRegexCheck = EmailRegex.IsMatch(SignUpEmailText);
            Regex PasswordRegex = new Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$");
            bool PasswordRegexsCheck = PasswordRegex.IsMatch(SignUpPasswordText);
            if (SignUpUsernameText == "")
                return 1;
            if (_user.CheckIfUsedUsername(UserList, SignUpUsernameText))
                return 2;
            if (SignUpEmailText == "")
                return 3;
            if (!EmailRegexCheck)
                return 4;
            if (_user.CheckIfUsedEmail(UserList, SignUpEmailText))
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
