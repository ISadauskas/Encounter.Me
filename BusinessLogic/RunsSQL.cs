using Microsoft.Data.SqlClient;
using System.Data;

namespace BusinessLogic
{
    public class RunsSQL
    {
        public string ConnectionString = "Data Source=encountermedbserver.database.windows.net;Initial Catalog=EncounterMeDb;User ID=Adminas1;Password=Password1";
        public int index = 0;
        public DataTable UpdateTable(string CurrentUser)
        {
            using (SqlConnection Con = new SqlConnection(ConnectionString))
            {
                GetListIndex(CurrentUser);
                Con.Open();
                string SqlQuery = "SELECT Id, Pace, Distance, CaloriesLost FROM \"Runs\"WHERE Name='" + CurrentUser + "'ORDER BY 1 ASC";
                SqlCommand sc = new SqlCommand(SqlQuery, Con);
                SqlDataAdapter da = new SqlDataAdapter(sc);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Con.Close();
                return dt;
            }
        }
        public void GetListIndex(string CurrentUser)
        {
            using (SqlConnection Con = new SqlConnection(ConnectionString))
            {
                Con.Open();
                string SqlQuery = "SELECT COUNT(*) FROM \"Runs\" WHERE Name='" + CurrentUser + "'";
                SqlCommand sc = new SqlCommand(SqlQuery, Con);
                index = (int)sc.ExecuteScalar();
                Con.Close();
            }
        }
        public void InsertRun(Runs TempRun, string CurrentUser)
        {

            using (SqlConnection Con = new SqlConnection(ConnectionString))
            {
                GetListIndex(CurrentUser);
                string SqlQuery = "INSERT INTO \"Runs\" (Id, Pace, Distance, CaloriesLost, Name)" +
                "VALUES(" + index + ", '" + TempRun.Pace + "', " + TempRun.Distance + ", " + TempRun.CaloriesLost + ", '" + CurrentUser + "')";
                Con.Open();
                SqlCommand sc = new SqlCommand(SqlQuery, Con);
                sc.ExecuteNonQuery();
                Con.Close();
            }
        }
        public void DeleteRun(int index, string CurrentUser)
        {
            using (SqlConnection Con = new SqlConnection(ConnectionString))
            {
                string SqlQuery = "DELETE FROM \"Runs\" WHERE id =" + index +" AND Name='" + CurrentUser + "'";
                Con.Open();
                SqlCommand sc = new SqlCommand(SqlQuery, Con);
                sc.ExecuteNonQuery();
                SqlQuery = "UPDATE Runs SET id=(id-1) WHERE id>" + index + " AND Name='" + CurrentUser + "'";
                sc = new SqlCommand(SqlQuery, Con);
                sc.ExecuteNonQuery();
                Con.Close();
            }
        }
        public int FindMostBurnedCalories(string CurrentUser)
        {
            using (SqlConnection Con = new SqlConnection(ConnectionString))
            {
                int MaxCaloriesLost;
                string SqlQuery = "SELECT COALESCE(MAX(CaloriesLost),0) FROM \"Runs\" WHERE Name='" + CurrentUser + "'";
                Con.Open();
                SqlCommand sc = new SqlCommand(SqlQuery, Con);
                MaxCaloriesLost = (int)sc.ExecuteScalar();
                Con.Close();
                return MaxCaloriesLost;
            }
        }
        public int FindAllBurnedCalories(string CurrentUser)
        {
            using (SqlConnection Con = new SqlConnection(ConnectionString))
            {
                int AllCaloriesLost;
                string SqlQuery = "SELECT COALESCE(Sum(CaloriesLost),0) FROM \"Runs\" WHERE Name='" + CurrentUser + "'";
                Con.Open();
                SqlCommand sc = new SqlCommand(SqlQuery, Con);
                AllCaloriesLost = int.Parse(sc.ExecuteScalar().ToString());
                Con.Close();
                return AllCaloriesLost;
            }
        }
        public double FindLongestPace(string CurrentUser, string Pace)
        {
            using (SqlConnection Con = new SqlConnection(ConnectionString))
            {
                double LongestPace;
                string SqlQuery = "SELECT COALESCE(MAX(Distance),0.00) FROM \"Runs\" WHERE Name='" + CurrentUser + "' AND Pace='" + Pace + "'";
                Con.Open();
                SqlCommand sc = new SqlCommand(SqlQuery, Con);
                LongestPace = double.Parse(sc.ExecuteScalar().ToString());
                Con.Close();
                return LongestPace;
            }
        }
    }
}