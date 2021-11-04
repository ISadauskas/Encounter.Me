using Newtonsoft.Json;
using System.ComponentModel;
using System.IO;

namespace BusinessLogic
{
    public class SignInJson
    {
        public void JsonWrite(User LoginAccount)
        {
            string LoginAccountJson = JsonConvert.SerializeObject(LoginAccount);
            File.WriteAllText(@"SignIn.json", LoginAccountJson);
        }
        public User JsonRead()
        {
            string SignInJson = File.ReadAllText(@"SignIn.json");
            User SignIn = JsonConvert.DeserializeObject<User>(SignInJson);
            return SignIn;
        }

        public bool CheckAccount(BindingList<User> UserList, string EmailOrUsername, string Password)
        {
            foreach (var item in UserList)
            {
                if ((EmailOrUsername.ToLower() == item.Email && Password == item.Password) ||
                    (EmailOrUsername == item.Username && Password == item.Password))
                {
                    JsonWrite(item);
                    return true;
                }
            }
            return false;
        }
        public void JsonDelete()
        {
            File.Delete("SignIn.json");
        }

        public bool CheckIfSignedIn()
        {
            if (File.Exists("SignIn.json"))
                return true;
            else
                return false;
        }

        public int GetUserListIndex(BindingList<User> UserList, User User)
        {
            int i = 0;
            foreach (var item in UserList)
            {
                if (item.Email == User.Email)
                    return i;
                i++;
            }
            return -1;
        }
    }
}