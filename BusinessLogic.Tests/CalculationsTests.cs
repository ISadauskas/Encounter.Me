using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using BusinessLogic;
using System.ComponentModel;
using Newtonsoft.Json;

namespace BusinessLogic.Tests
{
    public class CalculationsTests
    {
        private UserJson _userJson = new UserJson();
        private SignInJson _signInJson = new SignInJson();
        private Calculations mockCalc = new Calculations();

        [Fact]
        public void GetIndex_ShouldReturnOne()
        {
            //arrange
            int expected = 0;
            BindingList<User> userlist = new BindingList<User>();
            userlist.Add(new User
            {
                Username = "Gedas",
                Email = "gp@123.com",
                Password = "Admin123$",
                Weight = 0.0,
                RunRecord = new BindingList<Runs>(), 
                IsAdmin = false
            });

            User target = new User
            {
                Username = "Gedas",
                Email = "gp@123.com",
                Password = "Admin123$",
                Weight = 0.0,
                RunRecord = new BindingList<Runs>(),
                IsAdmin = false
            };

            //act
            int actual = mockCalc.GetIndex(userlist, target);

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AdjustUserWeight_ShouldReturnUser()
        {
            //arrange
            User expected = new User
            {
                Username = "Gedas",
                Email = "gp@123.com",
                Password = "Admin123$",
                Weight = 5.0,
                RunRecord = new BindingList<Runs>(),
                IsAdmin = false
            };

            var exp = JsonConvert.SerializeObject(expected);

            //act
            User actual = new User
            {
                Username = "Gedas",
                Email = "gp@123.com",
                Password = "Admin123$",
                Weight = 0.0,
                RunRecord = new BindingList<Runs>(),
                IsAdmin = false

            };
            actual = mockCalc.AdjustUserWeight(actual, "5,0");

            var act = JsonConvert.SerializeObject(actual);

            //assert
            Assert.Equal(exp, act); 
        }

        [Fact]
        public void EditUser_ShouldReturnTrue()
        {
            //arrange

            //act
            bool actual = mockCalc.EditUser("5,0");

            //assert
            Assert.True(actual);
        }


    }
}
