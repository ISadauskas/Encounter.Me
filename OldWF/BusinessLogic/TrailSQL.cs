using EncounterMeWF;
using Microsoft.Data.SqlClient;
using System.Data;

namespace BusinessLogic
{
    public class TrailSQL
    {
        public string ConnectionString = "Data Source=encountermedbserver.database.windows.net;Initial Catalog=EncounterMeDb;User ID=Adminas1;Password=Password1";
        public int index = 0;
        public DataTable UpdateTable()
        {
            GetIndex();
            using (SqlConnection Con = new SqlConnection(ConnectionString))
            {
                Con.Open();
                string SqlQuery = "SELECT Id, Name, Length, Timestamp, Location, Organizer FROM \"Trails\" ORDER BY 1 ASC";
                SqlCommand sc = new SqlCommand(SqlQuery, Con);
                SqlDataAdapter da = new SqlDataAdapter(sc);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Con.Close();
                return dt;
            }
        }
        public void GetIndex()
        {
            using (SqlConnection Con = new SqlConnection(ConnectionString))
            {
                Con.Open();
                string SqlQuery = "SELECT COUNT(*) FROM \"Trails\"";
                SqlCommand sc = new SqlCommand(SqlQuery, Con);
                index = (int)sc.ExecuteScalar();
                Con.Close();
            }
        }
        public void InsertTrail(Trail TempTrail)
        {
            using (SqlConnection Con = new SqlConnection(ConnectionString))
            {
                string Timestamp = TempTrail.Timestamp.ToString("yyyy-MM-dd HH:mm:ss");
                string SqlQuery = "INSERT INTO \"Trails\" (Id, Name, Length, Timestamp, Location, Organizer)" +
                "VALUES(" + index + ", '" + TempTrail.Name + "', " + TempTrail.Length + ", convert(datetime,'" + Timestamp + "'), '" + TempTrail.Location + "', '" + TempTrail.Organizer + "')";
                Con.Open();
                SqlCommand sc = new SqlCommand(SqlQuery, Con);
                sc.ExecuteNonQuery();
                Con.Close();
            }
        }
        public void DeleteTrail(int index)
        {
            using (SqlConnection Con = new SqlConnection(ConnectionString))
            {
                string SqlQuery = "DELETE FROM \"Trails\" WHERE id =" + index;
                Con.Open();
                SqlCommand sc = new SqlCommand(SqlQuery, Con);
                sc.ExecuteNonQuery();
                SqlQuery = "UPDATE Trails SET id=(id-1) WHERE id>" + index;
                sc = new SqlCommand(SqlQuery, Con);
                sc.ExecuteNonQuery();
                Con.Close();
            }
        }
        public void ModifyTrail(int index, Trail TempTrail)
        {
            using (SqlConnection Con = new SqlConnection(ConnectionString))
            {
                string Timestamp = TempTrail.Timestamp.ToString("yyyy-MM-dd HH:mm:ss");

                string SqlQuery = "UPDATE Trails SET Name='" + TempTrail.Name + "', Length='" + TempTrail.Length + "', Timestamp= convert(datetime,'" + Timestamp + "'), Location='" + TempTrail.Location +
                    "', Organizer='" + TempTrail.Organizer + "' WHERE id=" + index;
                Con.Open();
                SqlCommand sc = new SqlCommand(SqlQuery, Con);
                sc.ExecuteNonQuery();
                Con.Close();
            }
        }
        public DataTable SearchTable(string from, string to)
        {
            using (SqlConnection Con = new SqlConnection(ConnectionString))
            {
                Con.Open();
                string SqlQuery = "SELECT Id, Name, Length, Timestamp, Location, Organizer FROM \"Trails\" WHERE Length>='"+from+"' AND Length<='"+to+"' ORDER BY 1 ASC";
                SqlCommand sc = new SqlCommand(SqlQuery, Con);
                SqlDataAdapter da = new SqlDataAdapter(sc);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Con.Close();
                return dt;
            }
        }
    }
}
