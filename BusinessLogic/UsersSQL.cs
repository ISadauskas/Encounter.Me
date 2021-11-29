using Microsoft.Data.SqlClient;

namespace BusinessLogic
{
    public class UsersSQL
    {
        private SignInJson _signInJson = new SignInJson();

        public string ConnectionString = "Data Source=encountermedbserver.database.windows.net;Initial Catalog=EncounterMeDb;User ID=Adminas1;Password=Password1";
        public int index = 0;

        public void GetIndex()
        {
            using (SqlConnection Con = new SqlConnection(ConnectionString))
            {
                Con.Open();
                string SqlQuery = "SELECT COUNT(*) FROM \"Users\"";
                SqlCommand sc = new SqlCommand(SqlQuery, Con);
                index = (int)sc.ExecuteScalar();
                Con.Close();
            }
        }
        public void InsertUser(User TempUser)
        {
            using (SqlConnection Con = new SqlConnection(ConnectionString))
            {
                GetIndex();
                string SqlQuery = "INSERT INTO \"Users\" (Id, Username, Email, Password, Weight, IsAdmin)" +
                "VALUES(" + index + ", '" + TempUser.Username + "', '" + TempUser.Email + "', '" + TempUser.Password + "', " + TempUser.Weight + ", " + TempUser.IsAdmin + ")";
                Con.Open();
                SqlCommand sc = new SqlCommand(SqlQuery, Con);
                sc.ExecuteNonQuery();
                Con.Close();
            }
        }
        public bool CheckIfUsernameUsed(string Username)
        {
            using (SqlConnection Con = new SqlConnection(ConnectionString))
            {
                int UsernameUsed;
                Con.Open();
                string SqlQuery = "SELECT COUNT(*) FROM \"Users\" WHERE Username='" + Username + "'";
                SqlCommand sc = new SqlCommand(SqlQuery, Con);
                UsernameUsed = (int)sc.ExecuteScalar();
                Con.Close();
                if (UsernameUsed == 0)
                    return false;
                else
                    return true;
            }
        }
        public bool CheckIfEmailUsed(string Email)
        {
            using (SqlConnection Con = new SqlConnection(ConnectionString))
            {
                int EmailUsed;
                Con.Open();
                string SqlQuery = "SELECT COUNT(*) FROM \"Users\" WHERE Email='" + Email + "'";
                SqlCommand sc = new SqlCommand(SqlQuery, Con);
                EmailUsed = (int)sc.ExecuteScalar();
                Con.Close();
                if (EmailUsed == 0)
                    return false;
                else
                    return true;
            }
        }
        public bool CheckAccount(string SignInInfo, string Password)
        {
            using (SqlConnection Con = new SqlConnection(ConnectionString))
            {
                Con.Open();
                string SqlQuery = "SELECT COUNT(*) FROM \"Users\" WHERE Username='" + SignInInfo + "' AND Password='" + Password + "'";
                SqlCommand sc = new SqlCommand(SqlQuery, Con);
                index = (int)sc.ExecuteScalar();
                if (index == 1)
                {
                    _signInJson.JsonWrite(SignInInfo);
                    Con.Close();
                    return true;
                }
                SqlQuery = "SELECT COUNT(*) FROM \"Users\" WHERE Email='" + SignInInfo + "' AND Password='" + Password + "'";
                sc = new SqlCommand(SqlQuery, Con);
                index = (int)sc.ExecuteScalar();
                if (index == 1)
                {
                    SqlQuery = "SELECT Username FROM \"Users\" WHERE Email='" + SignInInfo + "' AND Password='" + Password + "'";
                    sc = new SqlCommand(SqlQuery, Con);
                    SignInInfo = sc.ExecuteReader().ToString();
                    _signInJson.JsonWrite(SignInInfo);
                    Con.Close();
                    return true;
                }
                else
                {
                    Con.Close();
                    return false;
                }
            }
        }
        public bool CheckIfAdmin(string Username)
        {
            using (SqlConnection Con = new SqlConnection(ConnectionString))
            {
                Con.Open();
                string SqlQuery = "SELECT IsAdmin FROM \"Users\" WHERE Username='" + Username + "'";
                SqlCommand sc = new SqlCommand(SqlQuery, Con);
                int isAdmin = (int)sc.ExecuteScalar();
                Con.Close();
                if (isAdmin == 1)
                    return true;
                else
                    return false;
            }
        }
        public double GetWeight(string Username)
        {
            using (SqlConnection Con = new SqlConnection(ConnectionString))
            {
                Con.Open();
                string SqlQuery = "SELECT Weight FROM \"Users\" WHERE Username='" + Username + "'";
                SqlCommand sc = new SqlCommand(SqlQuery, Con);
                double Weight = double.Parse(sc.ExecuteScalar().ToString());
                Con.Close();
                return Weight;
            }
        }
        public void SetWeight(string Username, double Weight)
        {
            using (SqlConnection Con = new SqlConnection(ConnectionString))
            {
                Con.Open();
                string SqlQuery = "UPDATE Users SET Weight=" + Weight + " WHERE Username='" + Username + "'";
                SqlCommand sc = new SqlCommand(SqlQuery, Con);
                sc.ExecuteNonQuery();
                Con.Close();
            }
        }
    }
}
