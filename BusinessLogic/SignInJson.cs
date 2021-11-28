using Newtonsoft.Json;
using System.IO;

namespace BusinessLogic
{
    public class SignInJson
    {
        public void JsonWrite(string SignInUsername)
        {
            string SignInAccountJson = JsonConvert.SerializeObject(SignInUsername);
            File.WriteAllText(@"SignIn.json", SignInAccountJson);
        }
        public string JsonRead()
        {
            string SignInJson = File.ReadAllText(@"SignIn.json");
            string SignIn = JsonConvert.DeserializeObject<string>(SignInJson);
            return SignIn;
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