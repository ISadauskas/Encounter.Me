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
        public void Check_ShouldReturnOne()
        {
            //arrange
            int expected = 1;

            //act
            int actual = _test.Check("", "50", "15", "20", "25", "30", "Male");
            
            //assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void Check_ShouldReturnTwo()
        {
            //arrange
            int expected = 2;

            //act
            int actual = _test.Check("5", "", "15", "20", "25", "30", "Male");

            //assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void Check_ShouldReturnThree()
        {
            //arrange
            int expected = 3;

            //act
            int actual = _test.Check("5", "dfsdsd", "15", "20", "25", "30", "Male");

            //assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void Check_ShouldReturnFour()
        {
            //arrange
            int expected = 4;

            //act
            int actual = _test.Check("5", "50", "", "20", "25", "30", "Male");

            //assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void Check_ShouldReturnFive()
        {
            //arrange
            int expected = 5;

            //act
            int actual = _test.Check("5", "50", "dsadsa", "20", "25", "30", "Male");

            //assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void Check_ShouldReturnSix()
        {
            //arrange
            int expected = 6;

            //act
            int actual = _test.Check("5", "50", "15", "", "25", "30", "Male");

            //assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void Check_ShouldReturnSeven()
        {
            //arrange
            int expected = 7;

            //act
            int actual = _test.Check("5", "50", "15", "dsadsa", "25", "30", "Male");

            //assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void Check_ShouldReturnEight()
        {
            //arrange
            int expected = 8;

            //act
            int actual = _test.Check("5", "50", "15", "20", "25", "30", "");

            //assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void Check_ShouldReturnNine()
        {
            //arrange
            int expected = 9;

            //act
            int actual = _test.Check("5", "50", "15", "20", "", "30", "Male");

            //assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void Check_ShouldReturnTen()
        {
            //arrange
            int expected = 10;

            //act
            int actual = _test.Check("5", "50", "15", "20", "sadsad", "30", "Male");

            //assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void Check_ShouldReturEleven()
        {
            //arrange
            int expected = 11;

            //act
            int actual = _test.Check("5", "50", "15", "20", "25", "", "Male");

            //assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void Check_ShouldReturnTwelve()
        {
            //arrange
            int expected = 12;

            //act
            int actual = _test.Check("5", "50", "15", "20", "25", "dssadas", "Male");

            //assert
            Assert.Equal(expected, actual);

        }
    }
}
