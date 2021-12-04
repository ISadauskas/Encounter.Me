using BusinessLogic;
using System;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Windows.Forms;
using Database.Commands;

namespace EncounterMeWF.UserControls
{
    public partial class PersonalRecordsUC : UserControl
    {
        private SignInJson _signInJson = new SignInJson();
        //private RunsSQL _runsSQL = new RunsSQL();
        private RunsCmd _runCmd = new RunsCmd();

        public string CurrentUser;
        public int Index;


        public PersonalRecordsUC()
        {
            InitializeComponent();
            //_runsSQL.UpdateTable(CurrentUser);

            if (File.Exists("SignIn.json"))
            {
                CurrentUser = _signInJson.JsonRead();
                DataGridViewUpdate();
            }
        }
        private void DataGridViewUpdate()
        {
            RunGridView.DataSource = _runCmd.GetRuns(CurrentUser);
            MostBurnedCaloriesAnswer.Text = _runCmd.FindMostBurnedCalories(CurrentUser).ToString() + " cal";
            AllBurnedCaloriesAnswer.Text = _runCmd.FindAllBurnedCalories(CurrentUser).ToString() + " cal";
            LongestRunDistanceAnswer.Text = _runCmd.FindLongestPace(CurrentUser, "Run").ToString() + " km";
            LongestWalkDistanceAnswer.Text = _runCmd.FindLongestPace(CurrentUser, "Walk").ToString() + " km";
            /*MostBurnedCaloriesAnswer.Text = _runsSQL.FindMostBurnedCalories(CurrentUser).ToString() + " cal";
            AllBurnedCaloriesAnswer.Text = _runsSQL.FindAllBurnedCalories(CurrentUser).ToString() + " cal";
            LongestRunDistanceAnswer.Text = _runsSQL.FindLongestPace(CurrentUser, "Run").ToString() + " km";
            LongestWalkDistanceAnswer.Text = _runsSQL.FindLongestPace(CurrentUser, "Walk").ToString() + " km";*/
        }
        private void DeleteEntryButton_Click(object sender, EventArgs e)
        {
            int index = RunGridView.SelectedRows[0].Index;
            //_runsSQL.DeleteRun(int.Parse(RunGridView.SelectedRows[0].Cells[0].Value.ToString()), CurrentUser);
            _runCmd.DeleteRun(int.Parse(RunGridView.SelectedRows[0].Cells[0].Value.ToString()));
            DataGridViewUpdate();
            if (index != 0)
            {
                RunGridView.Rows[0].Selected = false;
                RunGridView.Rows[index - 1].Selected = true;
            }
        }

        private void RunGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn newColumn = RunGridView.Columns[e.ColumnIndex];
            DataGridViewColumn oldColumn = RunGridView.SortedColumn;
            ListSortDirection direction;

            // If oldColumn is null, then the DataGridView is not sorted.
            if (oldColumn != null)
            {
                // Sort the same column again, reversing the SortOrder.
                if (oldColumn == newColumn &&
                    RunGridView.SortOrder == System.Windows.Forms.SortOrder.Ascending)
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
            RunGridView.Sort(newColumn, direction);
            newColumn.HeaderCell.SortGlyphDirection =
                direction == ListSortDirection.Ascending ?
                System.Windows.Forms.SortOrder.Ascending : System.Windows.Forms.SortOrder.Descending;
        }

        private void RunGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in RunGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Programmatic;
            }
        }
    }
}
