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
    public class CalorieCalculatorUCRegexTests
    {
        CalorieCalculatorUCRegex _test = new CalorieCalculatorUCRegex();

        [Fact]
        public void RunCheck_ShouldReturnOne()
        {
            //arrange
            int expected = 1;

            //act
            int actual = _test.RunCheck("", "50", "15", "20");
            
            //assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void RunCheck_ShouldReturnTwo()
        {
            //arrange
            int expected = 2;

            //act
            int actual = _test.RunCheck("5", "", "15", "20");

            //assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void RunCheck_ShouldReturnThree()
        {
            //arrange
            int expected = 3;

            //act
            int actual = _test.RunCheck("5", "dfsdsd", "15", "20");

            //assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void RunCheck_ShouldReturnFour()
        {
            //arrange
            int expected = 4;

            //act
            int actual = _test.RunCheck("5", "50", "", "20");

            //assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void RunCheck_ShouldReturnFive()
        {
            //arrange
            int expected = 5;

            //act
            int actual = _test.RunCheck("5", "50", "dsadsa", "20");

            //assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void RunCheck_ShouldReturnSix()
        {
            //arrange
            int expected = 6;

            //act
            int actual = _test.RunCheck("5", "50", "15", "");

            //assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void RunCheck_ShouldReturnSeven()
        {
            //arrange
            int expected = 7;

            //act
            int actual = _test.RunCheck("5", "50", "15", "dsadsa");

            //assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void HealthCheck_ShouldReturnOne()
        {
            //arrange
            int expected = 1;

            //act
            int actual = _test.HealthCheck("", "50", "15", "Male");

            //assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void HealthCheck_ShouldReturnTwo()
        {
            //arrange
            int expected = 2;

            //act
            int actual = _test.HealthCheck("asd", "50", "15","Male");

            //assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void HealthCheck_ShouldReturnThree()
        {
            //arrange
            int expected = 3;

            //act
            int actual = _test.HealthCheck("5", "50", "15", "");

            //assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void HealthCheck_ShouldReturnFour()
        {
            //arrange
            int expected = 4;

            //act
            int actual = _test.HealthCheck("5", "", "15", "Male");

            //assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void HealthCheck_ShouldReturnFive()
        {
            //arrange
            int expected = 5;

            //act
            int actual = _test.HealthCheck("5", "asd", "15", "Male");

            //assert
            Assert.Equal(expected, actual);

        }
        public void HealthCheck_ShouldReturnSix()
        {
            //arrange
            int expected = 6;

            //act
            int actual = _test.HealthCheck("5", "50", "", "Male");

            //assert
            Assert.Equal(expected, actual);

        }
        public void HealthCheck_ShouldReturnSeven()
        {
            //arrange
            int expected = 7;

            //act
            int actual = _test.HealthCheck("5", "50", "asd", "Male");

            //assert
            Assert.Equal(expected, actual);

        }
    }
}
