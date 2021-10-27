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
        private UserJson _userJson = new UserJson();
        private SignInJson _signInJson = new SignInJson();


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
                if (File.Exists("SignIn.json"))
                {
                    UserList = _userJson.JsonRead();
                    CurrentUser = _signInJson.JsonRead();
                    Index = _signInJson.GetUserListIndex(UserList, CurrentUser);
                    if (Index != -1)
                    {
                        User TempUser = new User
                        {
                            Username = CurrentUser.Username,
                            Email = CurrentUser.Email.ToLower(),
                            Password = CurrentUser.Password,
                            Weight = double.Parse(WeightTextBox.Text),
                            RunRecord = CurrentUser.RunRecord
                        };
                        UserList.RemoveAt(Index);
                        UserList.Insert(Index, TempUser);
                        _userJson.JsonWrite(UserList);
                        _signInJson.JsonWrite(TempUser);
                        AddToRecordButton.Visible = true;
                    }
                }
                if (RunWalkCombobox.Text == "Run")
                {
                    double Weight = double.Parse(WeightTextBox.Text);
                    double Distance = double.Parse(DistanceTextBox.Text);
                    CaloriesBurned = (int)Math.Round(Weight * Distance * 1.9);
                    CalorieBurn.Text = (CaloriesBurned).ToString() + " cal";
                }
                else
                {
                    double Weight = double.Parse(WeightTextBox.Text);
                    double Distance = double.Parse(DistanceTextBox.Text);
                    CaloriesBurned = (int)Math.Round(Weight * Distance * 1.137);
                    CalorieBurn.Text = (CaloriesBurned).ToString() + " cal";
                }
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
            Runs tempRun = new Runs
            {
                RunOrWalk = RunWalkCombobox.Text,
                Distance = double.Parse(DistanceTextBox.Text),
                CalloriesLost = CaloriesBurned
            };
            CurrentUser.RunRecord.Add(tempRun);
            User TempUser = new User
            {
                Username = CurrentUser.Username,
                Email = CurrentUser.Email.ToLower(),
                Password = CurrentUser.Password,
                Weight = double.Parse(WeightTextBox.Text),
                RunRecord = CurrentUser.RunRecord
            };
            UserList.RemoveAt(Index);
            UserList.Insert(Index, TempUser);
            _userJson.JsonWrite(UserList);
            _signInJson.JsonWrite(TempUser);
        }
    }
}
