using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using BusinessLogic;

namespace EncounterMeWF.UserControls
{
    public partial class TrailsUC : UserControl
    {
        private Json _json = new Json();
        
        string TrailJson;
        BindingList<Trail> TrailList = new BindingList<Trail>();

        public TrailsUC()
        {
            InitializeComponent();
            //Load json file in table view on startup
            TrailList = _json.JsonRead();
            TrailGridView.DataSource = TrailList;
        }

        private void CreateEntryButton_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                Trail TempTrail = new Trail
                {
                    ID = int.Parse(TrailIdTextbox.Text),
                    Name = TrailNameTextbox.Text,
                    Length = double.Parse(TrailLengthTextbox.Text),
                    Coordinates = new List<string>{}
                };
                TrailList.Add(TempTrail);

                _json.JsonWrite(TrailList);
                TrailGridView.DataSource = TrailList;
            }
        }

        private void DeleteEntryButton_Click(object sender, EventArgs e)
        {
            TrailGridView.Rows.RemoveAt(TrailGridView.SelectedRows[0].Index);
            _json.JsonWrite(TrailList);
        }

        private void ModifyEntryButton_Click(object sender, EventArgs e)
        {
            Trail TempTrail = new Trail
            {
                ID = int.Parse(TrailIdTextbox.Text),
                Name = TrailNameTextbox.Text,
                Length = double.Parse(TrailLengthTextbox.Text),
                Coordinates = new List<string>{}
            };
            int n = TrailGridView.SelectedRows[0].Index;
            TrailGridView.Rows.RemoveAt(n);
            TrailList.Insert(n, TempTrail);
            _json.JsonWrite(TrailList);

        }
        private bool Check()
        {
            if (TrailIdTextbox.Text == "")
            {
                MessageBox.Show("Please enter trail Id number", "Entry Error", MessageBoxButtons.OK);
                return false;
            }
            if (TrailNameTextbox.Text == "")
            {
                MessageBox.Show("Please enter trail name", "Entry Error", MessageBoxButtons.OK);
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
    }
}
