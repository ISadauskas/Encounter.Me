using BusinessLogic;
using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Data;

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

        public string ConnectionString = "Data Source=encountermedbserver.database.windows.net;Initial Catalog=EncounterMeDb;User ID=Adminas1;Password=Password1";
        public int index = 0;

        public TrailsUC()
        {
            InitializeComponent();
            //Load json file in table view on startup
            /*try
            {
                TrailList = _trailJson.JsonRead();
            }
            catch (FileNotFoundException e)
            {
                _trailJson.JsonWrite(TrailList);
            }*/
            UpdateTable();
            //TrailList = _trail.UpdateTrailList(TrailList);
            //_trailJson.JsonWrite(TrailList);
            //TrailGridView.DataSource = TrailList;
        }
        private void UpdateTable()
        {
            using (SqlConnection Con = new SqlConnection(ConnectionString))
            {
                string SqlQuery = "SELECT COUNT(*) FROM \"Trails\"";
                Con.Open();
                SqlCommand sc = new SqlCommand(SqlQuery, Con);
                index = (int)sc.ExecuteScalar();
                string SqlQuery1 = "SELECT Name, Length, Timestamp, Location, Organizer FROM \"Trails\"";
                SqlCommand sc1 = new SqlCommand(SqlQuery1, Con);
                SqlDataAdapter da = new SqlDataAdapter(sc1);
                DataTable dt = new DataTable();
                da.Fill(dt);
                //SQLList = (BindingList<Trail>)sc1.ExecuteScalar();
                //sc.Parameters.AddWithValue("@x", textBox1.Text);
                Con.Close();
                CountTextbox.Text = index.ToString();
                TrailGridView.DataSource = dt;
            }
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



                    using (SqlConnection Con = new SqlConnection(ConnectionString))
                    {
                        string Try = TempTrail.Timestamp.ToString("yyyy-MM-dd HH:mm:ss");
                        string SqlQuery = "INSERT INTO \"Trails\" (Id, Name, Length, Timestamp, Location, Organizer)" +
                        "VALUES(" + index + ", '" + TempTrail.Name + "', " + TempTrail.Length + ", convert(datetime,'" + Try + "'), '" + TempTrail.Location + "', '" + TempTrail.Organizer + "')";
                        Con.Open();
                        SqlCommand sc = new SqlCommand(SqlQuery, Con);
                        sc.ExecuteNonQuery();
                        Con.Close();
                        index++;
                    }
                    UpdateTable();
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
                    using (SqlConnection Con = new SqlConnection(ConnectionString))
                    {
                        string SqlQuery = "DELETE FROM \"Trails\" WHERE id ="+TrailGridView.SelectedRows[0].Index.ToString();
                        Con.Open();
                        SqlCommand sc = new SqlCommand(SqlQuery, Con);
                        sc.ExecuteNonQuery();
                        SqlQuery = "UPDATE Trails SET id=(id-1) WHERE id>" + TrailGridView.SelectedRows[0].Index.ToString();
                        sc = new SqlCommand(SqlQuery, Con);
                        sc.ExecuteNonQuery();
                        Con.Close();
                    }
                    //_trailJson.JsonWrite(TrailList);
                    TrailIndex = TrailGridView.SelectedRows[0].Index - 1;
                    TrailGridView.Rows[TrailIndex].Selected = true;
                    UpdateTable();

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
                        TempTrail = _trail.CreateTrail(Name: TrailNameTextbox.Text, Length: TrailLengthTextbox.Text, StartDate: TrailStartDatePicker.Value,
                            StartTime: TrailStartTimePicker.Value, StartLocation: TrailStartLocationTextbox.Text);

                        using (SqlConnection Con = new SqlConnection(ConnectionString))
                        {
                            string Try = TempTrail.Timestamp.ToString("yyyy-MM-dd HH:mm:ss");

                            string SqlQuery = "UPDATE Trails SET Name='" + TempTrail.Name + "', Length='" + TempTrail.Length + "', Timestamp= convert(datetime,'" + Try + "'), Location='" + TempTrail.Location +
                                "', Organizer='" + TempTrail.Organizer + "' WHERE id=" + TrailGridView.SelectedRows[0].Index.ToString();
                            Con.Open();
                            SqlCommand sc = new SqlCommand(SqlQuery, Con);
                            sc.ExecuteNonQuery();
                            Con.Close();
                        }
                        UpdateTable();
                        /*TrailGridView.Rows.RemoveAt(TrailIndex);
                        TrailList.Insert(TrailIndex, TempTrail);
                        _trailJson.JsonWrite(TrailList);*/
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

            TrailNameTextbox.Text = TrailGridView.SelectedRows[0].Cells[0].Value.ToString();
            TrailLengthTextbox.Text = TrailGridView.SelectedRows[0].Cells[1].Value.ToString();
            TrailStartDatePicker.Value = DateTime.Parse(TrailGridView.SelectedRows[0].Cells[2].Value.ToString());
            TrailStartTimePicker.Value = DateTime.Parse(TrailGridView.SelectedRows[0].Cells[2].Value.ToString());
            TrailStartLocationTextbox.Text = TrailGridView.SelectedRows[0].Cells[3].Value.ToString();
        }
    }
}
