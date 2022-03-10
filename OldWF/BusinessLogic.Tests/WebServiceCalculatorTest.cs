using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic;
using Xunit;

namespace BusinessLogic.Tests
{
    public class WebServiceCalculatorTest
    {
        WebServiceCalculator test = new WebServiceCalculator();

        [Fact]
        public void GetCalculation_ShouldReturndata()
        {
            //arrange
            string expected = "System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1+AsyncStateMachineBox`1[System.String,BusinessLogic.WebServiceCalculator+<GetCalculation>d__1]";

            //act
            string actual = test.GetCalculation(50, 50, 50, "Walk").ToString();

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetNeededCalculation_ShouldReturndata()
        {
            //arrange
            string expected = "System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1+AsyncStateMachineBox`1[System.String,BusinessLogic.WebServiceCalculator+<GetNeededCalculation>d__2]";

            //act
            string actual = test.GetNeededCalculation(50, 50, "Male", 50).ToString();

            //assert
            Assert.Equal(expected, actual);
        }
    }
}
