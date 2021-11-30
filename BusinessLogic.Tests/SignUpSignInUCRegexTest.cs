using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using BusinessLogic;

namespace BusinessLogic.Tests
{
    public class SignUpSignInUCRegexTest
    {
        SignUpSignInUCRegex test = new SignUpSignInUCRegex();

        [Fact]
        public void Check_ShouldReturnZero()
        {
            //arrange
            int expected = 0;

            //act
            int actual = test.Check("Nirino", "Jonas@gmail.com", "Admin123?", "Admin123?");

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Check_ShouldReturnOne()
        {
            //arrange
            int expected = 1;

            //act
            int actual = test.Check("", "Jonas@gmail.com", "Admin123?", "Admin123?");

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Check_ShouldReturnTwo()
        {
            //arrange
            int expected = 2;

            //act
            int actual = test.Check("Gedas", "Jonas@gmail.com", "Admin123?", "Admin123?");

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Check_ShouldReturnThree()
        {
            //arrange
            int expected = 3;

            //act
            int actual = test.Check("Nirino", "", "Admin123?", "Admin123?");

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Check_ShouldReturnFour()
        {
            //arrange
            int expected = 4;

            //act
            int actual = test.Check("Nirino", "Jonas@gmai", "Admin123?", "Admin123?");

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Check_ShouldReturnFive()
        {
            //arrange
            int expected = 5;

            //act
            int actual = test.Check("Nirino", "Gedas@gmail.com", "Admin123?", "Admin123?");

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Check_ShouldReturnSix()
        {
            //arrange
            int expected = 6;

            //act
            int actual = test.Check("Nirino", "Jonas@gmail.com", "", "Admin123?");

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Check_ShouldReturnSeven()
        {
            //arrange
            int expected = 7;

            //act
            int actual = test.Check("Nirino", "Jonas@gmail.com", "sdsadsa", "Admin123?");

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Check_ShouldReturnEight()
        {
            //arrange
            int expected = 8;

            //act
            int actual = test.Check("Nirino", "Jonas@gmail.com", "Admin123?", "Admin");

            //assert
            Assert.Equal(expected, actual);
        }
    }


}
