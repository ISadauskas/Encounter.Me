using BusinessLogic;
using System;
using System.ComponentModel;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace EncounterMeWF.UserControls
{
    public partial class CalorieCalculatorUC : UserControl
    {
        private SignInJson _signInJson = new SignInJson();
        private Calculations _calculations = new Calculations();
        private Runs _runs = new Runs();


        public BindingList<User> UserList = new BindingList<User>();
        public User CurrentUser = new User();
        public int CaloriesBurned;
        public int Index;
        public CalorieCalculatorUC()
        {
            InitializeComponent();
            if (File.Exists("SignIn.json"))
            {
                CurrentUser = _signInJson.JsonRead();
                WeightTextBox.Text = CurrentUser.Weight.ToString();
            }
        }
        private void CalculationButton_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                double Weight = double.Parse(WeightTextBox.Text);
                double Distance = double.Parse(DistanceTextBox.Text);

                if (File.Exists("SignIn.json"))
                    AddToRecordButton.Visible = _calculations.EditUser(WeightTextBox.Text);

                if (RunWalkCombobox.Text == "Run")
                    CaloriesBurned = (int)Math.Round(Weight * Distance * 1.9);
                else
                    CaloriesBurned = (int)Math.Round(Weight * Distance * 1.137);

                CalorieBurn.Text = (CaloriesBurned).ToString() + " cal";
            }
        }

        private bool Check()
        {
            Regex WeightRegex = new Regex("^[0-9]+.?[0-9]*$");
            bool WeightRegexCheck = WeightRegex.IsMatch(WeightTextBox.Text);
            Regex DistanceRegex = new Regex("^[0-9]+.?[0-9]*$");
            bool DistanceRegexCheck = DistanceRegex.IsMatch(DistanceTextBox.Text);
            if (RunWalkCombobox.Text == "")
            {
                MessageBox.Show("Please choose if you were running or walking", "Entry Error", MessageBoxButtons.OK);
                return false;
            }
            if (WeightTextBox.Text == "")
            { 
                MessageBox.Show("Please enter your current weight", "Entry Error", MessageBoxButtons.OK);
                return false;
            }
            if (!WeightRegexCheck)
            {
                MessageBox.Show("Weight can only consist of numbers from 0 to 9 and a .", "Entry Error", MessageBoxButtons.OK);
                return false;
            }
            if (DistanceTextBox.Text == "")
            {
                MessageBox.Show("Please enter the distance you have walked/ran", "Entry Error", MessageBoxButtons.OK);
                return false;
            }
            if (!DistanceRegexCheck)
            {
                MessageBox.Show("Distance can only consist of numbers from 0 to 9 and a .", "Entry Error", MessageBoxButtons.OK);
                return false;
            }
            else
                return true;
        }
        private void AddToRecordButton_Click(object sender, EventArgs e)
        {
            Runs tempRun = _runs.CreateRun(RunWalkCombobox.Text, DistanceTextBox.Text, CaloriesBurned);
            _calculations.AddRunToCurrentUser(tempRun, WeightTextBox.Text);
        }
    }
}
