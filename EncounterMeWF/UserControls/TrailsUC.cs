using BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace EncounterMeWF.UserControls
{
    public partial class TrailsUC : UserControl
    {
        private TrailJson _trailJson = new TrailJson();
        private Trail _trail = new Trail();
        private SignInJson _signInJson = new SignInJson();
        private Search _search = new Search();

        BindingList<Trail> TrailList = new BindingList<Trail>();
        BindingList<Trail> SearchList = new BindingList<Trail>();

        public TrailsUC()
        {
            InitializeComponent();
            //Load json file in table view on startup
            if(File.Exists("Trails.json"))
                TrailList = _trailJson.JsonRead(); 
            else
                _trailJson.JsonWrite(TrailList);

            TrailGridView.DataSource = TrailList;
            }

        private void CreateEntryButton_Click(object sender, EventArgs e)
        {
            if (_signInJson.CheckIfSignedIn())
            {
                if (Check())
                {
                    Trail TempTrail = new Trail();
                    if (TrailNameTextbox.Text == "")
                        TempTrail = _trail.CreateTrail(Id: TrailIdTextbox.Text, Length: TrailLengthTextbox.Text, _Season: TrailSeasonCombobox.SelectedIndex);
                    else
                        TempTrail = _trail.CreateTrail(Id: TrailIdTextbox.Text, Name: TrailNameTextbox.Text, Length: TrailLengthTextbox.Text, _Season: TrailSeasonCombobox.SelectedIndex);
                    TrailList.Add(TempTrail);

                    _trailJson.JsonWrite(TrailList);
                    TrailGridView.DataSource = TrailList;
                }
            }
            else
                MessageBox.Show("Please Sign in to access this function.", "Entry Error", MessageBoxButtons.OK);
        }

        private void DeleteEntryButton_Click(object sender, EventArgs e)
        {
            if (_signInJson.CheckIfSignedIn())
            {
                TrailGridView.Rows.RemoveAt(TrailGridView.SelectedRows[0].Index);
                _trailJson.JsonWrite(TrailList);
            }
            else
                MessageBox.Show("Please Sign in to access this function.", "Entry Error", MessageBoxButtons.OK);
        }

        private void ModifyEntryButton_Click(object sender, EventArgs e)
        {
            if (_signInJson.CheckIfSignedIn())
            {
                if (Check())
                {
                    Trail TempTrail = new Trail
                    {
                        ID = int.Parse(TrailIdTextbox.Text),
                        Name = TrailNameTextbox.Text,
                        Length = double.Parse(TrailLengthTextbox.Text),
                        Coordinates = new List<string> { },
                        Season = TrailSeasonCombobox.Text
                    };
                    int n = TrailGridView.SelectedRows[0].Index;
                    TrailGridView.Rows.RemoveAt(n);
                    TrailList.Insert(n, TempTrail);
                    _trailJson.JsonWrite(TrailList);
                }
            }
            else
                MessageBox.Show("Please Sign in to access this function.", "Entry Error", MessageBoxButtons.OK);
        }

        private bool Check()
        {
            Regex IdRegex = new Regex("^[0-9]+$");
            bool IdRegexCheck = IdRegex.IsMatch(TrailIdTextbox.Text);
            Regex LengthRegex = new Regex("^[0-9].?[0-9]*$");
            bool LengthRegexCheck = LengthRegex.IsMatch(TrailLengthTextbox.Text);
            if (TrailIdTextbox.Text == "")
            {
                MessageBox.Show("Please enter trail Id number", "Entry Error", MessageBoxButtons.OK);
                return false;
            }
            if (!IdRegexCheck)
            {
                MessageBox.Show("Trail Id can only consist of numbers from 0 to 9", "Entry Error", MessageBoxButtons.OK);
                return false;
            }
            if (TrailLengthTextbox.Text == "")
            {
                MessageBox.Show("Please enter trail length number", "Entry Error", MessageBoxButtons.OK);
                return false;
            }
            if (!LengthRegexCheck)
            {
                MessageBox.Show("Trail length can only consist of numbers from 0 to 9 and a .", "Entry Error", MessageBoxButtons.OK);
                return false;
            }
            else
                return true;
        }
        public bool SearchCheck(string from, string to)
        {
            Regex SearchRegex = new Regex("^[0-9]+$");
            bool fromCheck = SearchRegex.IsMatch(LengthFromTextBox.Text);
            bool toCheck = SearchRegex.IsMatch(LengthToTextBox.Text);

            if (LengthFromTextBox.Text == "" && LengthToTextBox.Text == "")
            {
                MessageBox.Show("Please enter trail search data", "Entry Error", MessageBoxButtons.OK);
                return false;
            }
            if (!fromCheck || !toCheck)
            {
                MessageBox.Show("Please only enter numbers", "Entry Error", MessageBoxButtons.OK);
                return false;
            }
            if (int.Parse(LengthFromTextBox.Text) > int.Parse(LengthToTextBox.Text))
            {
                MessageBox.Show("From number cannot be bigger than To", "Entry Error", MessageBoxButtons.OK);
                return false;
            }
            else
                return true;
        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (SearchCheck(from: LengthFromTextBox.Text, to: LengthToTextBox.Text))
            {
                Search TempLength = new Search();
                TempLength = _search.SearchLength(LengthFromTextBox.Text, LengthToTextBox.Text);
                SearchList.Clear();
                foreach (var TempTrail in TrailList)
                {
                    if ((int)Math.Round(TempTrail.Length) >= TempLength.LenghtFrom &&
                        (int)Math.Round(TempTrail.Length) <= TempLength.LenghtTo)
                        SearchList.Add(TempTrail);
                }
                TrailGridView.DataSource = SearchList;
            }
        }

        private void TrailGridView_MouseClick(object sender, MouseEventArgs e)
        {
            int n = TrailGridView.SelectedRows[0].Index;
            TrailIdTextbox.Text = TrailList[n].ID.ToString();
            TrailNameTextbox.Text = TrailList[n].Name;
            TrailLengthTextbox.Text = TrailList[n].Length.ToString();
            TrailSeasonCombobox.Text = TrailList[n].Season;
        }
    }
}
