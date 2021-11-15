using System.ComponentModel;

namespace BusinessLogic
{
    public class Calculations
    {
        private UserJson _userJson = new UserJson();
        private SignInJson _signInJson = new SignInJson();

        public int GetIndex(BindingList<User> UserList, User CurrentUser)
        {
            int Index;
            Index = _signInJson.GetUserListIndex(UserList, CurrentUser);
            return Index;
        }
        public User AdjustUserWeight(User CurrentUser, string Weight)
        {

            User TempUser = new User
            {
                Username = CurrentUser.Username,
                Email = CurrentUser.Email.ToLower(),
                Password = CurrentUser.Password,
                Weight = double.Parse(Weight),
                RunRecord = CurrentUser.RunRecord
            };
            return TempUser;
        }
        public bool EditUser(string Weight)
        {
            BindingList<User> UserList = _userJson.JsonRead();
            User CurrentUser = _signInJson.JsonRead();

            int Index = GetIndex(UserList, CurrentUser);
            if (Index != -1)
            {
                CurrentUser = AdjustUserWeight(CurrentUser, Weight);

                UserList.RemoveAt(Index);
                UserList.Insert(Index, CurrentUser);
                _userJson.JsonWrite(UserList);
                _signInJson.JsonWrite(CurrentUser);
                return true;
            }
            return false;
        }
        public async void AddRunToCurrentUser(Runs tempRun, string Weight)
        {
            BindingList<User> UserList = _userJson.JsonRead();
            User CurrentUser = _signInJson.JsonRead();
            int Index = GetIndex(UserList, CurrentUser);

            CurrentUser.RunRecord.Add(tempRun);
            User TempUser = new User
            {
                Username = CurrentUser.Username,
                Email = CurrentUser.Email.ToLower(),
                Password = CurrentUser.Password,
                Weight = double.Parse(Weight),
                RunRecord = CurrentUser.RunRecord
            };
            UserList.RemoveAt(Index);
            UserList.Insert(Index, TempUser);
            _userJson.JsonWrite(UserList);
            _signInJson.JsonWrite(TempUser);
        }
    }
}
