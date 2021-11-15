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
        private CalorieCalculatorUCRegex _calorieCalculatorUCRegex = new CalorieCalculatorUCRegex();

        public BindingList<User> UserList = new BindingList<User>();
        public User CurrentUser = new User();
        public int CaloriesBurned;
        public int Index;
        public double RunningConstant = 1.9;
        public double WalkingConstant = 1.137;
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
                

                Func<double, double, double, double> calculation = (Weight, Distance, constant) => (Weight * Distance * constant);

                if (File.Exists("SignIn.json"))
                    AddToRecordButton.Visible = _calculations.EditUser(WeightTextBox.Text);

                if (RunWalkCombobox.Text == "Run")
                    CaloriesBurned = (int)Math.Round(calculation(Weight, Distance, RunningConstant));
                else
                    CaloriesBurned = (int)Math.Round(calculation(Weight, Distance, WalkingConstant));

                CalorieBurn.Text = (CaloriesBurned).ToString() + " cal";
            }
        }

        public bool Check()
        {
            switch (_calorieCalculatorUCRegex.Check(RunWalkCombobox.Text, WeightTextBox.Text, DistanceTextBox.Text))
            {
                case 1:
                    MessageBox.Show("Please choose if you were running or walking", "Entry Error", MessageBoxButtons.OK);
                    return false;
                case 2:
                    MessageBox.Show("Please enter your current weight", "Entry Error", MessageBoxButtons.OK);
                    return false;
                case 3:
                    MessageBox.Show("Weight can only consist of numbers from 0 to 9 and a .", "Entry Error", MessageBoxButtons.OK);
                    return false;
                case 4:
                    MessageBox.Show("Please enter the distance you have walked/ran", "Entry Error", MessageBoxButtons.OK);
                    return false;
                case 5:
                    MessageBox.Show("Distance can only consist of numbers from 0 to 9 and a .", "Entry Error", MessageBoxButtons.OK);
                    return false;
                case 0:
                    return true;
            }
            return true;
        }
        private void AddToRecordButton_Click(object sender, EventArgs e)
        {
            Runs tempRun = _runs.CreateRun(RunWalkCombobox.Text, DistanceTextBox.Text, CaloriesBurned);
            _calculations.AddRunToCurrentUser(tempRun, WeightTextBox.Text);
        }
    }
}
