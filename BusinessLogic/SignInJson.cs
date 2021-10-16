using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class SignInJson
    {
        public void JsonWrite(User LoginAccount)
        {
            string LoginAccountJson = JsonConvert.SerializeObject(LoginAccount);
            File.WriteAllText(@"SignIn.json", LoginAccountJson);
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
    }
}