using System;
using System.ComponentModel;

namespace BusinessLogic
{
    public struct User
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public double Weight { get; set; }
        public BindingList<Runs> RunRecord { get; set; }
        public bool IsAdmin { get; set; }

        //public event EventHandler<bool> OnCheckIfUsed;

        public User CreateUser(string Username, string Email, string Password, bool IsAdmin)
        {
            User TempUser = new User
            {
                Username = Username,
                Email = Email.ToLower(),
                Password = Password,
                Weight = 0,
                RunRecord = new BindingList<Runs>(),
                IsAdmin = IsAdmin
            };
            return TempUser;
        }

        public bool CheckIfUsedUsername(BindingList<User> UserList, string Username)
        {
            //OnClick?.Invoke(this, EventArgs.Empty);
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