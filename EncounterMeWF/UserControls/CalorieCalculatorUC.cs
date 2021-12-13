using BusinessLogic;
using Database.Commands;
using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncounterMeWF.UserControls
{
    public partial class CalorieCalculatorUC : UserControl
    {
        private SignInJson _signInJson = new SignInJson();
        private Runs _runs = new Runs();
        private CalorieCalculatorUCRegex _calorieCalculatorUCRegex = new CalorieCalculatorUCRegex();
        private Mets _mets = new Mets();
        private UserController _userCmd = new UserController();
        private RunsController _runCmd = new RunsController();

        public string CurrentUser;
        public int CaloriesBurned;
        public int CaloriesNeed;
        public int Index;
        public double Speed;
        public double MetOne = 3.5;
        private static readonly string BaseUri = "https://localhost:7274/api/";
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
        private async void CalculationButton_Click(object sender, EventArgs e)
        {
            double Weight = double.Parse(WeightTextBox1.Text);
            double Distance = double.Parse(DistanceTextBox.Text);
            int Duration = int.Parse(DurationTextBox.Text);

            File.AppendAllText(@"..\..\..\..\Logging\Log.txt", "Calorie calculation started at: " + DateTime.Now + "\n");

            Speed = Distance / (Duration / 60);

            if (CheckForBurned())
            {
                if (File.Exists("SignIn.json"))
                    AddToRecordButton.Visible = true;
                
                var response =  await GetCalculation(Weight, Distance, Duration, RunWalkCombobox.Text);
                CalorieBurn.Text = response + " cal";
                _userCmd.UpdateWeight(CurrentUser, Weight.ToString());

                File.AppendAllText(@"..\..\..\..\Logging\Log.txt", "Calorie calculation finished at: " + DateTime.Now + "\n");
            }
        }

        public static async Task<string> GetCalculation(double weight, double distance, int duration, string pace)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.GetAsync(BaseUri + "CalorieCalculator/" + weight + "/" + distance + "/" + duration + "/" + pace))
                {
                    using (HttpContent content = response.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                            return data;
                    }
                }
            }
            return string.Empty;
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

        private async void CaloriesNeedButton_Click(object sender, EventArgs e)
        {
            double Weight = double.Parse(WeightTextBox2.Text);
            double Height = double.Parse(HeightTextBox.Text);
            int Age = int.Parse(AgeTextBox.Text);
            double BMR;

            if (CheckForNeed())
            {
                if (File.Exists("SignIn.json"))
                    AddToRecordButton.Visible = true;

                var response = await GetNeededCalculation(Weight, Height, GenderComboBox.Text, Age);
                CaloriesNeedToConsume.Text = response + " cal";

                _userCmd.UpdateWeight(CurrentUser, Weight.ToString());

            }
        }
        public static async Task<string> GetNeededCalculation(double Weight, double Height, string Gender, int Age)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.GetAsync(BaseUri + "CalorieNeededCalculator/" + Weight + "/" + Height + "/" + Gender + "/" + Age))
                {
                    using (HttpContent content = response.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                            return data;
                    }
                }
            }
            return string.Empty;
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
