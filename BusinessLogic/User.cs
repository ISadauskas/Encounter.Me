using System.ComponentModel;

namespace BusinessLogic
{
    public struct User
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }


        public User CreateUser(string Username, string Email, string Password)
        {
            User TempUser = new User
            {
                Username = Username,
                Email = Email.ToLower(),
                Password = Password
            };
            return TempUser;
        }

        public bool CheckIfUsedUsername(BindingList<User> UserList, string Username)
        {
            foreach (var item in UserList)
            {
                if (Username == item.Username)
                    return true;
            }
            return false;
        }

        public bool CheckIfUsedEmail(BindingList<User> UserList, string Email)
        {
            foreach (var item in UserList)
            {
                if (Email.ToLower() == item.Email)
                    return true;
            }
            return false;
        }
    }
}
