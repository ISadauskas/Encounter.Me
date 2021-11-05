using Newtonsoft.Json;
using System.ComponentModel;
using System.IO;

namespace BusinessLogic
{
    public class UserJson
    {
        string UserListJson;
        BindingList<User> UserList = new BindingList<User>();

        public void JsonWrite<T>(T UserList)
        {
            UserListJson = JsonConvert.SerializeObject(UserList);
            UserList = JsonConvert.DeserializeObject<T>(UserListJson);
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
