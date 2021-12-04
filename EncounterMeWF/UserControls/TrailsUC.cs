using BusinessLogic;
using Database.Commands;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace EncounterMeWF.UserControls
{
    public partial class TrailsUC : UserControl
    {
        private SignInJson _signInJson = new SignInJson();
        private TrailsUCRegex _trailsUCRegex = new TrailsUCRegex();
        private TrailCmd _trailCmd = new TrailCmd();
        private UserCmd _userCmd = new UserCmd();


        BindingList<Trail> TrailList = new BindingList<Trail>();
        public int TrailIndex = 0;

        public TrailsUC()
        {
            InitializeComponent();
            DataGridViewUpdate();
        }

        private void DataGridViewUpdate()
        {
            var list = _trailCmd.GetTrails();
            TrailGridView.DataSource = list;
        }

        private void CreateEntryButton_Click(object sender, EventArgs e)
        {
            if (_signInJson.CheckIfSignedIn())
            {
                if (Check())
                {
                    if (!TrailGridView.RowCount.Equals(0))
                        TrailIndex = TrailGridView.SelectedRows[0].Index;
                    string Organizer = _signInJson.JsonRead();
                    _trailCmd.AddTrail(TrailNameTextbox.Text, TrailLengthTextbox.Text, TrailStartDatePicker.Value, TrailStartTimePicker.Value, TrailStartLocationTextbox.Text, Organizer);
                    DataGridViewUpdate();
                    TrailGridView.Rows[0].Selected = false;
                    if (!TrailGridView.RowCount.Equals(0))
                        TrailGridView.Rows[TrailIndex].Selected = true;
                }
            }
            else
                MessageBox.Show("Please Sign in to access this function.", "Entry Error", MessageBoxButtons.OK);
        }

        private void DeleteEntryButton_Click(object sender, EventArgs e)
        {
            if (_signInJson.CheckIfSignedIn())
            {
                string CurrentUser = _signInJson.JsonRead();
                if (_userCmd.CheckIfAdmin(CurrentUser) || CurrentUser == TrailGridView.SelectedRows[0].Cells[5].Value.ToString())
                {
                    TrailIndex = TrailGridView.SelectedRows[0].Index;
                    _trailCmd.DeleteTrail(int.Parse(TrailGridView.SelectedRows[0].Cells[0].Value.ToString()));
                    DataGridViewUpdate();
                    if (TrailIndex != 0)
                    {
                        TrailGridView.Rows[0].Selected = false;
                        TrailGridView.Rows[TrailIndex - 1].Selected = true;
                    }
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
                string CurrentUser = _signInJson.JsonRead();
                if (_userCmd.CheckIfAdmin(CurrentUser) || CurrentUser == TrailGridView.SelectedRows[0].Cells[5].Value.ToString())
                {
                    if (Check())
                    {
                        _trailCmd.UpdateTrail(int.Parse(TrailGridView.SelectedRows[0].Cells[0].Value.ToString()), TrailNameTextbox.Text,
                            TrailLengthTextbox.Text, TrailStartDatePicker.Value, TrailStartTimePicker.Value, TrailStartLocationTextbox.Text);
                        DataGridViewUpdate();
                        if (TrailIndex != 0)
                        {
                            TrailGridView.Rows[0].Selected = false;
                            TrailGridView.Rows[TrailIndex].Selected = true;
                        }
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
            switch (_trailsUCRegex.CheckTrail(TrailLengthTextbox.Text, TrailStartLocationTextbox.Text, TrailStartDatePicker.Value))
            {
                case 1:
                    MessageBox.Show("Please enter trail length number", "Entry Error", MessageBoxButtons.OK);
                    return false;
                case 2:
                    MessageBox.Show("Trail length can only consist of numbers from 0 to 9 and a .", "Entry Error", MessageBoxButtons.OK);
                    return false;
                case 3:
                    MessageBox.Show("The date cannot be earlier than today", "Entry Error", MessageBoxButtons.OK);
                    return false;
                case 4:
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
                TrailGridView.DataSource = _trailCmd.SearchTrails(LengthFromTextBox.Text, LengthToTextBox.Text);
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
            FillInTextboxes();
        }

        private void FillInTextboxes()
        {
            TrailNameTextbox.Text = TrailGridView.SelectedRows[0].Cells[1].Value.ToString();
            TrailLengthTextbox.Text = TrailGridView.SelectedRows[0].Cells[2].Value.ToString();
            TrailStartDatePicker.Value = DateTime.Parse(TrailGridView.SelectedRows[0].Cells[3].Value.ToString());
            TrailStartTimePicker.Value = DateTime.Parse(TrailGridView.SelectedRows[0].Cells[3].Value.ToString());
            TrailStartLocationTextbox.Text = TrailGridView.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void TrailGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn newColumn = TrailGridView.Columns[e.ColumnIndex];
            DataGridViewColumn oldColumn = TrailGridView.SortedColumn;
            ListSortDirection direction;

            // If oldColumn is null, then the DataGridView is not sorted.
            if (oldColumn != null)
            {
                // Sort the same column again, reversing the SortOrder.
                if (oldColumn == newColumn &&
                    TrailGridView.SortOrder == System.Windows.Forms.SortOrder.Ascending)
                {
                    direction = ListSortDirection.Descending;
                }
                else
                {
                    // Sort a new column and remove the old SortGlyph.
                    direction = ListSortDirection.Ascending;
                    oldColumn.HeaderCell.SortGlyphDirection = System.Windows.Forms.SortOrder.None;
                }
            }
            else
            {
                direction = ListSortDirection.Ascending;
            }

            // Sort the selected column.
            TrailGridView.Sort(newColumn, direction);
            newColumn.HeaderCell.SortGlyphDirection =
                direction == ListSortDirection.Ascending ?
                System.Windows.Forms.SortOrder.Ascending : System.Windows.Forms.SortOrder.Descending;
        }
        private void TrailGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // Put each of the columns into programmatic sort mode.
            foreach (DataGridViewColumn column in TrailGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Programmatic;
            }
        }
    }
}