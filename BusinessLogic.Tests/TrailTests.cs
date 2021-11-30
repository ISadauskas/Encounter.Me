using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic;
using EncounterMeWF;
using Newtonsoft.Json;
using Xunit;

namespace BusinessLogic.Tests
{
    public class TrailTests
    {

        [Fact]
        public void CreateTrail_ShouldReturnTrail()
        {
            //arrange
            SignInJson _signInJson = new SignInJson();
            Trail expected = new Trail();
            expected.Name = "a";
            expected.Length = 2;
            expected.Timestamp = new DateTime(2000, 1, 1, 00, 00, 00);
            expected.Location = "b";
            expected.Organizer = "Gedas";

            var exp = JsonConvert.SerializeObject(expected);

            //act
            Trail actual = new Trail();
            actual = actual.CreateTrail("2", new DateTime(2000, 1, 1, 00, 00, 00), new DateTime(2000, 1, 1, 00, 00, 00), "b", "a");

            var act = JsonConvert.SerializeObject(actual);

            //assert
            Assert.Equal(exp, act);
        }


        //TODO
        [Fact]
        public void ModifyTrail_ShouldReturnModifiedTrail()
        {
            //arrange
            SignInJson _signInJson = new SignInJson();

            Trail expected = new Trail();
            expected.Name = "a";
            expected.Length = 2;
            expected.Timestamp = new DateTime(2000, 1, 1, 00, 00, 00);
            expected.Location = "b";
            expected.Organizer = "Gedas";

            Trail test = new Trail();
            test.Organizer = "Gedas";

            var exp = JsonConvert.SerializeObject(expected);

            //act
            Trail actual = new Trail();
            actual = actual.ModifyTrail("a", "2,0", new DateTime(2000, 1, 1, 00, 00, 00), new DateTime(2000, 1, 1, 00, 00, 00), "b", "Gedas");
            var act = JsonConvert.SerializeObject(actual);

            //assert
            Assert.Equal(exp, act);
        }
    }
}
