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
    public class RunsTests
    {
        [Fact]
        public void CreateRun_ShouldReturnRun()
        {
            //arrange
            Runs exp = new Runs();
            exp.Pace = "Run";
            exp.Distance = 5;
            exp.CaloriesLost = 80;

            var expected = JsonConvert.SerializeObject(exp);

            //act
            Runs act = new Runs();
            act = act.CreateRun("Run", "5", 80);

            var actual = JsonConvert.SerializeObject(act);

            //assert
            Assert.Equal(expected, actual);
        }
    }
}
