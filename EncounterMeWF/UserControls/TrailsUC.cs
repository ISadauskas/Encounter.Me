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
            if (Check())
            {
                Trail TempTrail = new Trail();
                if (TrailNameTextbox.Text == "")
                    TempTrail = _trail.CreateTrail(Id: TrailIdTextbox.Text, Length: TrailLengthTextbox.Text);
                else
                    TempTrail = _trail.CreateTrail(Id: TrailIdTextbox.Text, Name: TrailNameTextbox.Text, Length: TrailLengthTextbox.Text);
                TrailList.Add(TempTrail);

                _trailJson.JsonWrite(TrailList);
                TrailGridView.DataSource = TrailList;
            }
        }

        private void DeleteEntryButton_Click(object sender, EventArgs e)
        {
            TrailGridView.Rows.RemoveAt(TrailGridView.SelectedRows[0].Index);
            _trailJson.JsonWrite(TrailList);
        }

        private void ModifyEntryButton_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                Trail TempTrail = new Trail
                {
                    ID = int.Parse(TrailIdTextbox.Text),
                    Name = TrailNameTextbox.Text,
                    Length = double.Parse(TrailLengthTextbox.Text),
                    Coordinates = new List<string> { }
                };
                int n = TrailGridView.SelectedRows[0].Index;
                TrailGridView.Rows.RemoveAt(n);
                TrailList.Insert(n, TempTrail);
                _trailJson.JsonWrite(TrailList);
            }
        }

        private bool Check()
        {
            Regex IdRegex = new Regex("^[0-9]$");
            bool IdRegexCheck = IdRegex.IsMatch(TrailIdTextbox.Text);
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
            else
                return true;
        }
        private bool SearchCheck()
        {
                if (LenghtFromTextBox.Text == "" || LenghtToTextBox.Text == "")
                {
                    MessageBox.Show("Please enter trail search data", "Entry Error", MessageBoxButtons.OK);
                    return false;
                }
                else 
                    return true;
        }

        private void TrailGridView_MouseClick(object sender, MouseEventArgs e)
        {
            int n = TrailGridView.SelectedRows[0].Index;
            TrailIdTextbox.Text = TrailList[n].ID.ToString();
            TrailNameTextbox.Text = TrailList[n].Name;
            TrailLengthTextbox.Text = TrailList[n].Length.ToString();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (SearchCheck())
            {
                Search TempLenght = new Search();
                TempLenght = _search.SearchLenght(LenghtFromTextBox.Text, LenghtToTextBox.Text);
                foreach (var TempTrail in TrailList)
                {
                   
                    if ((int)TempTrail.Length >= TempLenght.LenghtFrom)
                        if ((int)TempTrail.Length <= TempLenght.LenghtTo)
                            SearchList.Add(TempTrail);
                }
                TrailGridView.DataSource = SearchList;
            }
        }
    }
}
