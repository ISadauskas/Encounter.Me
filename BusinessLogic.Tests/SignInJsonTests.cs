using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using BusinessLogic;

namespace BusinessLogic.Tests
{
    public class SignInJsonTests
    {
        SignInJson test = new SignInJson();

        [Fact]
        public void JsonRead_ShouldReturnGedas()
        {
            //arrange
            string expected = "Gedas";

            //act
            string actual = test.JsonRead();

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CheckIfSignedIn_ShouldReturnTrue()
        {
            //arrange
            //act
            bool actual = test.CheckIfSignedIn();

            //assert
            Assert.True(actual);
        }
    }
}
