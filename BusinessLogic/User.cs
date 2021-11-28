
namespace BusinessLogic
{
    public struct User
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public double Weight { get; set; }
        public int IsAdmin { get; set; }


        public User CreateUser(string Username, string Email, string Password, bool IsAdmin)
        {
            int AdminBool = 0;
            if (IsAdmin)
                AdminBool = 1;
            User TempUser = new User
            {
                Username = Username,
                Email = Email.ToLower(),
                Password = Password,
                Weight = 0,
                IsAdmin = AdminBool
            };
            return TempUser;
        }
    }
}