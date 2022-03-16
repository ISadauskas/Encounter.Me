using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using BusinessLogic;

namespace BusinessLogic.Tests
{
    public class TrailUCRegexTests
    {
        TrailsUCRegex test = new TrailsUCRegex();

        [Fact]
        public void CheckTrail_ShouldReturnZero()
        {
            //arrange
            int expected = 0;

            //act
            int actual = test.CheckTrail("50", "Vingis", DateTime.MaxValue);

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CheckTrail_ShouldReturnOne()
        {
            //arrange
            int expected = 1;

            //act
            int actual = test.CheckTrail("", "Vingis", DateTime.MaxValue);

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CheckTrail_ShouldReturnTwo()
        {
            //arrange
            int expected = 2;

            //act
            int actual = test.CheckTrail("dsadsad", "Vingis", DateTime.MaxValue);

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CheckTrail_ShouldReturnThree()
        {
            //arrange
            int expected = 3;

            //act
            int actual = test.CheckTrail("50", "Vingis", DateTime.MinValue);

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CheckTrail_ShouldReturnFour()
        {
            //arrange
            int expected = 4;

            //act
            int actual = test.CheckTrail("50", "", DateTime.MaxValue);

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CheckSearch_ShouldReturnZero()
        {
            //arrange
            int expected = 0;

            //act
            int actual = test.CheckSearch("2", "5");

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CheckSearch_ShouldReturnOne()
        {
            //arrange
            int expected = 1;

            //act
            int actual = test.CheckSearch("", "5");

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CheckSearch_ShouldReturnTwo()
        {
            //arrange
            int expected = 2;

            //act
            int actual = test.CheckSearch("a", "5");

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CheckSearch_ShouldReturnThree()
        {
            //arrange
            int expected = 3;

            //act
            int actual = test.CheckSearch("10", "5");

            //assert
            Assert.Equal(expected, actual);
        }
    }
}
