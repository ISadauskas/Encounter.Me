using System;
using Xunit;
using BusinessLogic;

namespace BusinessLogic.Tests
{
    public class MetsTests
    {
        Mets _mets = new Mets();

        [Theory]
        [InlineData(3, 2)]
        [InlineData(3.5, 3.7)]
        [InlineData(4.5, 6)]
        [InlineData(3, 0)]
        public void MetWalkedValue_ShouldCalculate(double exp, double act)
        {
            //arrange
            double expected = exp;

            //act
            double actual = _mets.MetWalkedValue(act);

            //assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(7, 6)]
        [InlineData(8.5, 7.5)]
        [InlineData(14.5, 13.5)]
        [InlineData(7, 0)]
        public void MetRanValue_ShouldCalculate(double exp, double act)
        {
            //arrange
            double expected = exp;

            //act
            double actual = _mets.MetRanValue(act);

            //assert
            Assert.Equal(expected, actual);
        }
    }
}
