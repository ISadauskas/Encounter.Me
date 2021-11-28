using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic;
using EncounterMeWF;
using Newtonsoft.Json;
using Xunit;

//TODO: figure out how to make DateTime work with these unit tests

namespace BusinessLogic.Tests
{
    public class TrailTests
    {
        [Fact]
        public void CreateTrail_ShouldReturnTrail()
        {
            //arrange
            Trail expected = new Trail();
            expected.Name = "a";
            expected.Length = 2;
            expected.Timestamp = DateTime.Now;
            expected.Location = "b";
            expected.Organizer = "c";

            var exp = JsonConvert.SerializeObject(expected);

            //act
            Trail actual = new Trail();
            actual = actual.CreateTrail("2", DateTime.Now.Date, DateTime.Now, "b", "a");

            var act = JsonConvert.SerializeObject(actual);

            //assert
            Assert.Equal(expected, actual);

            
        }
    }
}
