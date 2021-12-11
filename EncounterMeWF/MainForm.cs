using BusinessLogic;
using EncounterMeWF.UserControls;
using System;
using System.IO;
using System.Windows.Forms;

namespace EncounterMeWF
{
    public partial class mainForm : Form
    {
        private SignInJson _signInJson = new SignInJson();

        public mainForm()
        {
            File.Create(@"C:\Users\PC\Documents\GitHub\Encounter.Me\Logging\Log.txt").Close();
            InitializeComponent();
            File.AppendAllText(@"C:\Users\PC\Documents\GitHub\Encounter.Me\Logging\Log.txt", "Initialized main form at: " + DateTime.Now + "\n");
            IndexUC uc = new IndexUC();
            addUserControl(uc);
            HideButtons();
        }

        public void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
            HideButtons();
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
        private void SignOutButton_Click(object sender, EventArgs e)
        {
            _signInJson.JsonDelete();
            HideButtons();
        }
        private void CalorieCalculatorButton_Click(object sender, EventArgs e)
        {
            CalorieCalculatorUC uc = new CalorieCalculatorUC();
            addUserControl(uc);
        }

        private void PersonalRunButton_Click(object sender, EventArgs e)
        {
            PersonalRecordsUC uc = new PersonalRecordsUC();
            addUserControl(uc);
        }
        private void HideButtons()
        {
            if (_signInJson.CheckIfSignedIn())
            {
                PersonalRunButton.Visible = true;
                SignupSigninButton.Visible = false;
                SignOutButton.Visible = true;
            }
            else
            {
                PersonalRunButton.Visible = false;
                SignupSigninButton.Visible = true;
                SignOutButton.Visible = false;
            }
        }
    }
}
