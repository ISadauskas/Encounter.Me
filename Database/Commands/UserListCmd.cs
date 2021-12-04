using Database.Data;
using Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Commands
{
    public class UserListCmd
    {
        public void AddUser(string username, string email, string password, int isAdmin)
        {
            using EncounterMeContext context = new EncounterMeContext();
            Users TempUser = new Users()
            {
                Username = username,
                Email = email,
                Password = password,
                Weight = Decimal.Parse("0"),
                IsAdmin = isAdmin
            };
            context.Add(TempUser);
            context.SaveChanges();
        }
        public decimal GetWeight(string username)
        {
            decimal weight;
            using EncounterMeContext context = new EncounterMeContext();
            var TempUser = context.Users
                .Where(u => u.Username == username)
                .FirstOrDefault();
            if (TempUser is Users)
            {
                weight = TempUser.Weight;
                return weight;
            }
            return 0;
        }
        public void UpdateWeight(string username, string weight)
        {
            using EncounterMeContext context = new EncounterMeContext();
            var TempUser = context.Users
                .Where(u => u.Username == username)
                .FirstOrDefault();
            if (TempUser is Users)
            {
                TempUser.Weight = Decimal.Parse(weight);
            }
            context.SaveChanges();
        }
        public string GetUsername(string SignInInfo, string Password)
        {
            using EncounterMeContext context = new EncounterMeContext();
            var TempUser = context.Users
                .Where(u => u.Username == SignInInfo).Where(u => u.Password == Password)
                .FirstOrDefault();
            if (TempUser is Users)
                return TempUser.Username;
            TempUser = context.Users
               .Where(u => u.Email == SignInInfo).Where(u => u.Password == Password)
               .FirstOrDefault();
            if (TempUser is Users)
                return TempUser.Username;
            else
                return null;
        }
        public bool CheckIfUsernameUsed(string username)
        {
            using EncounterMeContext context = new EncounterMeContext();
            var TempUser = context.Users
                .Where(u => u.Username == username)
                .FirstOrDefault();
            if (TempUser is Users)
                return true;
            else
                return false;
        }
        public bool CheckIfEmailUsed(string email)
        {
            using EncounterMeContext context = new EncounterMeContext();
            var TempUser = context.Users
                .Where(u => u.Email == email)
                .FirstOrDefault();
            if (TempUser is Users)
                return true;
            else
                return false;
        }
        public bool CheckIfAdmin(string username)
        {
            using EncounterMeContext context = new EncounterMeContext();
            var TempUser = context.Users
                .Where(u => u.Username == username)
                .FirstOrDefault();
            if (TempUser is Users)
            {
                if (TempUser.IsAdmin == 1)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }
        public bool CheckAccount(string SignInInfo, string Password)
        {
            using EncounterMeContext context = new EncounterMeContext();
            var TempUser = context.Users
                .Where(u => u.Username == SignInInfo).Where(u => u.Password == Password)
                .FirstOrDefault();
            if (TempUser is Users)
                return true;
            TempUser = context.Users
               .Where(u => u.Email == SignInInfo).Where(u => u.Password == Password)
               .FirstOrDefault();
            if (TempUser is Users)
                return true;
            else
                return false;
        }
    }
}
