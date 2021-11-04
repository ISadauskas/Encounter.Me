using BusinessLogic;
using EncounterMeWF.UserControls;
using System;
using System.IO;
using System.Windows.Forms;

namespace EncounterMeWF
{
    public partial class mainForm : Form
    {
        private Lazy<SignInJson> _loginJson = new Lazy<SignInJson>
            (() => new SignInJson(), true);
        public SignInJson LoginJson
        {
            get { return _loginJson.Value; }
        }


        public delegate void HideDelegate();
        private HideDelegate HideDelegateFunction;

        //public event EventHandler OnButtonClick;
        public mainForm()
        {
            InitializeComponent();
            IndexUC uc = new IndexUC();
            addUserControl(uc);
            HideDelegateFunction = HideButtons;
            HideDelegateFunction();
        }

        public void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
            HideDelegateFunction = HideButtons;
            HideDelegateFunction();
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
            LoginJson.JsonDelete();
            if (File.Exists("SignIn.json"))
                PersonalRunButton.Visible = true;
            else
                PersonalRunButton.Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CalorieCalculatorUC uc = new CalorieCalculatorUC();
            addUserControl(uc);
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
            if (File.Exists("SignIn.json"))
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
