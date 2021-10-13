using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.IO;
using EncounterMeWF;
using Newtonsoft.Json;

namespace BusinessLogic
{
    public class UserJson
    {
        string UserListJson;
        BindingList<User> UserList = new BindingList<User>();

        public void JsonWrite(BindingList<User> UserList)
        {
            UserListJson = JsonConvert.SerializeObject(UserList);
            UserList = JsonConvert.DeserializeObject<BindingList<User>>(UserListJson);
            File.WriteAllText(@"Users.json", UserListJson);
        }

        public BindingList<User> JsonRead()
        {
            UserListJson = File.ReadAllText(@"Users.json");
            UserList = JsonConvert.DeserializeObject<BindingList<User>>(UserListJson);
            return UserList;
        }
    }
}
