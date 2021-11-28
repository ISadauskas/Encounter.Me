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
    public class SearchTests
    {
        [Fact]
        public void SearchLength_ShouldParse()
        {
            //arrange
            Search exp = new Search();
            exp.LenghtFrom = 5;
            exp.LenghtTo = 6;

            var expected = JsonConvert.SerializeObject(exp);

            //act
            Search act = new Search();
            act = act.SearchLength("5", "6");

            var actual = JsonConvert.SerializeObject(act);

            //assert
            Assert.Equal(expected, actual);
        }
    }
}
