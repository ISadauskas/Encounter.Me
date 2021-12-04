using BusinessLogic;
using Database.Commands;
using System;
using System.IO;
using System.Windows.Forms;

namespace EncounterMeWF.UserControls
{
    public partial class CalorieCalculatorUC : UserControl
    {
        private SignInJson _signInJson = new SignInJson();
        private Runs _runs = new Runs();
        private CalorieCalculatorUCRegex _calorieCalculatorUCRegex = new CalorieCalculatorUCRegex();
        private Mets _mets = new Mets();
        private UserCmd _userCmd = new UserCmd();
        private RunsCmd _runCmd = new RunsCmd();

        public string CurrentUser;
        public int CaloriesBurned;
        public int CaloriesNeed;
        public int Index;
        public double Speed;
        public double MetOne = 3.5;
        public CalorieCalculatorUC()
        {
            InitializeComponent();
            if (File.Exists("SignIn.json"))
            {
                CurrentUser = _signInJson.JsonRead();
                WeightTextBox1.Text = _userCmd.GetWeight(CurrentUser).ToString();
                WeightTextBox2.Text = _userCmd.GetWeight(CurrentUser).ToString();
            }
        }
        private void CalculationButton_Click(object sender, EventArgs e)
        {
            double Weight = double.Parse(WeightTextBox1.Text);
            double Distance = double.Parse(DistanceTextBox.Text);
            int Duration = int.Parse(DurationTextBox.Text);

            Speed = Distance / (Duration / 60);

            if (CheckForBurned())
            {
                if (File.Exists("SignIn.json"))
                    AddToRecordButton.Visible = true;

                if (RunWalkCombobox.Text == "Walk")
                {
                    CaloriesBurned = (int)Math.Round(MetOne * Duration * Weight * _mets.MetWalkedValue(Speed) / 200);
                }
                else
                    CaloriesBurned = (int)Math.Round(MetOne * Duration * Weight * _mets.MetRanValue(Speed) / 200);

                CalorieBurn.Text = (CaloriesBurned).ToString() + " cal";
                _userCmd.UpdateWeight(CurrentUser, Weight.ToString());
            }
        }

        public bool CheckForBurned()
        {
            switch (_calorieCalculatorUCRegex.RunCheck(RunWalkCombobox.Text, WeightTextBox1.Text, DurationTextBox.Text, DistanceTextBox.Text))
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
                    MessageBox.Show("Please enter the duration of your walking/running", "Entry Error", MessageBoxButtons.OK);
                    return false;
                case 5:
                    MessageBox.Show("Duration can only be natural number", "Entry Error", MessageBoxButtons.OK);
                    return false;
                case 6:
                    MessageBox.Show("Please enter the distance you have walked/ran", "Entry Error", MessageBoxButtons.OK);
                    return false;
                case 7:
                    MessageBox.Show("Distance can only consist of numbers from 0 to 9 and a .", "Entry Error", MessageBoxButtons.OK);
                    return false;
                case 0:
                    return true;
            }
            return true;
        }
        public bool CheckForNeed()
        {
            switch (_calorieCalculatorUCRegex.HealthCheck(WeightTextBox2.Text, HeightTextBox.Text, AgeTextBox.Text, GenderComboBox.Text))
            {
                case 1:
                    MessageBox.Show("Please enter your current weight", "Entry Error", MessageBoxButtons.OK);
                    return false;
                case 2:
                    MessageBox.Show("Weight can only consist of numbers from 0 to 9 and a .", "Entry Error", MessageBoxButtons.OK);
                    return false;
                case 3:
                    MessageBox.Show("Please choose your gender", "Entry Error", MessageBoxButtons.OK);
                    return false;
                case 4:
                    MessageBox.Show("Please enter your current height", "Entry Error", MessageBoxButtons.OK);
                    return false;
                case 5:
                    MessageBox.Show("Height can only consist of numbers from 0 to 9 and a .", "Entry Error", MessageBoxButtons.OK);
                    return false;
                case 6:
                    MessageBox.Show("Please enter your current age", "Entry Error", MessageBoxButtons.OK);
                    return false;
                case 7:
                    MessageBox.Show("Age can only be natural number", "Entry Error", MessageBoxButtons.OK);
                    return false;
            }
            return true;
        }

        private void AddToRecordButton_Click(object sender, EventArgs e)
        {
            _runCmd.AddRun(RunWalkCombobox.Text, DistanceTextBox.Text, CalorieBurn.Text, CurrentUser);
        }

        private void CaloriesNeedButton_Click(object sender, EventArgs e)
        {
            double Weight = double.Parse(WeightTextBox2.Text);
            double Height = double.Parse(HeightTextBox.Text);
            int Age = int.Parse(AgeTextBox.Text);
            double BMR;

            if (CheckForNeed())
            {
                if (File.Exists("SignIn.json"))
                    AddToRecordButton.Visible = true;

                if (RunWalkCombobox.Text == "Male")
                {
                    BMR = 10 * Weight + 6.25 * Height - 5 * Age + 5;
                }
                else
                    BMR = 10 * Weight + 6.25 * Height - 5 * Age - 161;

                CaloriesNeed = (int)Math.Round(BMR * 1.2);

                CaloriesNeedToConsume.Text = (CaloriesNeed).ToString() + " cal";

                CalorieBurn.Text = (CaloriesBurned).ToString() + " cal";
                _userCmd.UpdateWeight(CurrentUser, Weight.ToString());

            }
        }
        private void WeightTextBox1_TextChanged(object sender, EventArgs e)
        {
            WeightTextBox2.Text = WeightTextBox1.Text;
        }
        private void WeightTextBox2_TextChanged(object sender, EventArgs e)
        {
            WeightTextBox1.Text = WeightTextBox2.Text;
        }
    }
}
