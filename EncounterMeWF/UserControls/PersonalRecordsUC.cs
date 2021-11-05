using BusinessLogic;
using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace EncounterMeWF.UserControls
{
    public partial class PersonalRecordsUC : UserControl
    {
        private UserJson _userJson = new UserJson();
        private SignInJson _signInJson = new SignInJson();

        public BindingList<User> UserList = new BindingList<User>();
        public User CurrentUser = new User();
        public int Index;

        public delegate TResult Calculate<T, TResult>(T UserRuns);
        private Calculate<BindingList<Runs>, int> CalculateInt;
        private Calculate<BindingList<Runs>, Double> CalculateDouble;


        public PersonalRecordsUC()
        {
            InitializeComponent();
            if (File.Exists("SignIn.json"))
                CurrentUser = _signInJson.JsonRead();
            TrailGridView.DataSource = CurrentUser.RunRecord;
            if (File.Exists("Users.json"))
                UserList = _userJson.JsonRead();
            
            CalculateInt = FindMostBurnedCalories;
            MostBurnedCaloriesAnswer.Text = CalculateInt(CurrentUser.RunRecord).ToString() + " cal";
            CalculateInt = FindAllBurnedCalories;
            AllBurnedCaloriesAnswer.Text = CalculateInt(CurrentUser.RunRecord).ToString() + " cal";
            CalculateDouble = FindLongestDistanceRun;
            LongestRunDistanceAnswer.Text = CalculateDouble(CurrentUser.RunRecord).ToString() + " km";
            CalculateDouble = FindLongestDistanceWalk;
            LongestWalkDistanceAnswer.Text = CalculateDouble(CurrentUser.RunRecord).ToString() + " km";
        }
        public int FindMostBurnedCalories(BindingList<Runs> UserRuns)
        {
            int Max = 0;
            foreach (var item in UserRuns)
            {
                if (item.CalloriesLost > Max)
                    Max = item.CalloriesLost;
            }
            return Max;
        }

        public int FindAllBurnedCalories(BindingList<Runs> UserRuns)
        {
            int Sum = 0;
            foreach (var item in UserRuns)
            {
                Sum += item.CalloriesLost;
            }
            return Sum;
        }
        public double FindLongestDistanceRun(BindingList<Runs> UserRuns)
        {
            double Max = 0;
            foreach (var item in UserRuns)
            {
                if (item.Distance > Max && item.RunOrWalk == "Run")
                    Max = item.Distance;
            }
            return Max;
        }
        public double FindLongestDistanceWalk(BindingList<Runs> UserRuns)
        {
            double Max = 0;
            foreach (var item in UserRuns)
            {
                if (item.Distance > Max && item.RunOrWalk == "Walk")
                    Max = item.Distance;
            }
            return Max;
        }

        private void DeleteEntryButton_Click(object sender, EventArgs e)
        {
            int n = TrailGridView.SelectedRows[0].Index;
            Index = _signInJson.GetUserListIndex(UserList, CurrentUser);
            TrailGridView.Rows.RemoveAt(n);
            User TempUser = new User
            {
                Username = CurrentUser.Username,
                Email = CurrentUser.Email.ToLower(),
                Password = CurrentUser.Password,
                Weight = CurrentUser.Weight,
                RunRecord = CurrentUser.RunRecord
            };
            UserList.RemoveAt(Index);
            UserList.Insert(Index, TempUser);
            _userJson.JsonWrite(UserList);
            _signInJson.JsonWrite(TempUser);
            CalculateInt = FindMostBurnedCalories;
            MostBurnedCaloriesAnswer.Text = CalculateInt(CurrentUser.RunRecord).ToString() + " cal";
            CalculateInt = FindAllBurnedCalories;
            AllBurnedCaloriesAnswer.Text = CalculateInt(CurrentUser.RunRecord).ToString() + " cal";
            CalculateDouble = FindLongestDistanceRun;
            LongestRunDistanceAnswer.Text = CalculateDouble(CurrentUser.RunRecord).ToString() + " km";
            CalculateDouble = FindLongestDistanceWalk;
            LongestWalkDistanceAnswer.Text = CalculateDouble(CurrentUser.RunRecord).ToString() + " km";
        }
    }
}
