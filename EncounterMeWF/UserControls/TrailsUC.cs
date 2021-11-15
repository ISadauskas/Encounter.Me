using BusinessLogic;
using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace EncounterMeWF.UserControls
{
    public partial class TrailsUC : UserControl
    {
        private TrailJson _trailJson = new TrailJson();
        private Trail _trail = new Trail();
        private SignInJson _signInJson = new SignInJson();
        public Trail TempTrail = new Trail();
        private Search _search = new Search();
        private TrailsUCRegex _trailsUCRegex = new TrailsUCRegex();



        BindingList<Trail> TrailList = new BindingList<Trail>();
        BindingList<Trail> SearchList = new BindingList<Trail>();
        public int TrailIndex = 0;


        public TrailsUC()
        {
            InitializeComponent();
            //Load json file in table view on startup
            try
            {
                TrailList = _trailJson.JsonRead();
            }
            catch (FileNotFoundException e)
            {
                _trailJson.JsonWrite(TrailList);
            }

            TrailGridView.DataSource = TrailList;
        }

        private void CreateEntryButton_Click(object sender, EventArgs e)
        {
            if (_signInJson.CheckIfSignedIn())
            {
                if (Check())
                {
                    if (TrailNameTextbox.Text == "")
                        TempTrail = _trail.CreateTrail(Length: TrailLengthTextbox.Text, StartDate: TrailStartDatePicker.Value,
                            StartTime: TrailStartTimePicker.Value, StartLocation: TrailStartLocationTextbox.Text);
                    else
                        TempTrail = _trail.CreateTrail(Name: TrailNameTextbox.Text, Length: TrailLengthTextbox.Text, StartDate: TrailStartDatePicker.Value,
                            StartTime: TrailStartTimePicker.Value, StartLocation: TrailStartLocationTextbox.Text);

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
                User CurrentUser = _signInJson.JsonRead();
                if (CurrentUser.IsAdmin == true || CurrentUser.Username == TrailList[TrailIndex].Organizer)
                {
                    TrailGridView.Rows.RemoveAt(TrailGridView.SelectedRows[0].Index);
                    _trailJson.JsonWrite(TrailList);
                    TrailIndex = TrailList.Count - 1;
                    TrailGridView.Rows[TrailIndex].Selected = true;
                }
                else
                    MessageBox.Show("You do not have access to delete other people trails.", "Entry Error", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Please Sign in to access this function.", "Entry Error", MessageBoxButtons.OK);
        }

        private void ModifyEntryButton_Click(object sender, EventArgs e)
        {
            if (_signInJson.CheckIfSignedIn())
            {
                User CurrentUser = _signInJson.JsonRead();
                if (CurrentUser.IsAdmin == true || CurrentUser.Username == TrailList[TrailIndex].Organizer)
                {
                    if (Check())
                    {
                        TempTrail = _trail.ModifyTrail(Name: TrailNameTextbox.Text, Length: TrailLengthTextbox.Text, StartDate: TrailStartDatePicker.Value,
                            StartTime: TrailStartTimePicker.Value, StartLocation: TrailStartLocationTextbox.Text, CurrentTrail: TrailList[TrailIndex]);

                        TrailGridView.Rows.RemoveAt(TrailIndex);
                        TrailList.Insert(TrailIndex, TempTrail);
                        _trailJson.JsonWrite(TrailList);
                    }
                }
                else
                    MessageBox.Show("You do not have access to modify other people trails.", "Entry Error", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Please Sign in to access this function.", "Entry Error", MessageBoxButtons.OK);
        }

        public bool Check()
        {
            switch (_trailsUCRegex.CheckTrail(TrailLengthTextbox.Text, TrailStartLocationTextbox.Text))
            {
                case 1:
                    MessageBox.Show("Please enter trail length number", "Entry Error", MessageBoxButtons.OK);
                    return false;
                case 2:
                    MessageBox.Show("Trail length can only consist of numbers from 0 to 9 and a .", "Entry Error", MessageBoxButtons.OK);
                    return false;
                case 3:
                    MessageBox.Show("Please enter a start location", "Entry Error", MessageBoxButtons.OK);
                    return false;
                case 0:
                    return true;
            }
            return true;
        }

        public bool SearchCheck()
        {
            switch (_trailsUCRegex.CheckSearch(LengthFromTextBox.Text, LengthToTextBox.Text))
            {
                case 1:
                    MessageBox.Show("Please enter trail search data", "Entry Error", MessageBoxButtons.OK);
                    return false;
                case 2:
                    MessageBox.Show("Search can only consist of whole numbers", "Entry Error", MessageBoxButtons.OK);
                    return false;
                case 3:
                    MessageBox.Show("The from number cannot be bigger than to", "Entry Error", MessageBoxButtons.OK);
                    return false;
                case 0:
                    return true;
            }
            return true;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (SearchCheck())
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
            try
            {
                TrailIndex = TrailGridView.SelectedRows[0].Index;
            }
            catch (Exception)
            {
                TrailIndex = TrailList.Count - 1;
            }
            TrailNameTextbox.Text = TrailList[TrailIndex].Name;
            TrailLengthTextbox.Text = TrailList[TrailIndex].Length.ToString();
            TrailStartDatePicker.Value = TrailList[TrailIndex].Timestamp.Date;
            TrailStartTimePicker.Value = new DateTime(2020, 01, 01) + TrailList[TrailIndex].Timestamp.TimeOfDay;
            TrailStartLocationTextbox.Text = TrailList[TrailIndex].Location;
        }
    }
}
