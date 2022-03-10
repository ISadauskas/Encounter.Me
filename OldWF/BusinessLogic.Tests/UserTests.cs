using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using BusinessLogic;
using Newtonsoft.Json;

namespace BusinessLogic.Tests
{
    public class UserTests
    {
        [Fact]
        public void CreateUser_ShouldReturnUser()
        {
            //arrange
            User test = new User();

            User expected = new User
            {
                Username = "Admin123",
                Email = "aba@get.net",
                Password = "Admin987$",
                Weight = 0.0,
                IsAdmin = 1
            };
            var exp = JsonConvert.SerializeObject(expected);

            //act
            User actual = test.CreateUser("Admin123", "aba@get.net", "Admin987$", true);
            var act = JsonConvert.SerializeObject(actual);

            //assert
            Assert.Equal(exp, act);
        }
    }
}
