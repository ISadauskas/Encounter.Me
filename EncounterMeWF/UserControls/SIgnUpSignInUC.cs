using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;


namespace EncounterMeWF.UserControls
{
    public partial class SIgnUpSignInUC : UserControl
    {
        private User _user = new User();
        private UserJson _userJson = new UserJson();
        BindingList<User> UserList = new BindingList<User>();

        public SIgnUpSignInUC()
        {
            InitializeComponent();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {

            if (SignUpPasswordTextbox.Text != SignUpConfirmPasswordTextbox.Text)
            {
                //TODO create an error messae for mismatching passwords
            }
            else
            {
                User TempUser = new User
                {
                    UserName = SignUpUsernameTextbox.Text,
                    Email = SignUpEmailTextbox.Text,
                    Password = SignUpPasswordTextbox.Text
                };

                UserList.Add(TempUser);

                _userJson.JsonWrite(UserList);
            }
        }
    }
}
