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
    public class LoginJson
    {
        public void JsonWrite(User LoginAccount)
        {
            string LoginAccountJson = JsonConvert.SerializeObject(LoginAccount);
            File.WriteAllText(@"Login.json", LoginAccountJson);
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
            File.Delete("Login.json");
        }
    }
}
