using BusinessLogic;
using EncounterMeWF.UserControls;
using System;
using System.Windows.Forms;

namespace EncounterMeWF
{
    public partial class mainForm : Form
    {
        private SignInJson _loginJson = new SignInJson();
        public mainForm()
        {
            InitializeComponent();
            IndexUC uc = new IndexUC();
            addUserControl(uc);
        }

        public void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void indexButton_Click(object sender, EventArgs e)
        {
            IndexUC uc = new IndexUC();
            addUserControl(uc);
        }

        private void trailsButton_Click(object sender, EventArgs e)
        {
            TrailsUC uc = new TrailsUC();
            addUserControl(uc);
        }

        private void SignupSigninButton_Click(object sender, EventArgs e)
        {
            SIgnUpSignInUC uc = new SIgnUpSignInUC();
            addUserControl(uc);
        }
        public void ChangeToIndex()
        {
            IndexUC uc = new IndexUC();
            SignupSigninButton.Hide();
            addUserControl(uc);
        }
        private void SignOutButton_Click_1(object sender, EventArgs e)
        {
            _loginJson.JsonDelete();
        }

        private void CalorieCalculatorButton_Click(object sender, EventArgs e)
        {
            CalorieCalculatorUC uc = new CalorieCalculatorUC();
            addUserControl(uc);
        }
    }
}
