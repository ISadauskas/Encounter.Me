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
            expected.Timestamp = DateTime.MaxValue;
            expected.Location = "b";
            expected.Organizer = "Gedas";

            var exp = JsonConvert.SerializeObject(expected);

            //act
            Trail actual = new Trail();
            actual = actual.CreateTrail("2", DateTime.MaxValue, DateTime.MaxValue, "b", "a");

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
            expected.Timestamp = DateTime.MaxValue;
            expected.Location = "b";
            expected.Organizer = "Gedas";

            Trail test = new Trail();
            test.Organizer = "Gedas";

            var exp = JsonConvert.SerializeObject(expected);

            //act
            Trail actual = new Trail();
            actual = actual.ModifyTrail("2", DateTime.MaxValue, DateTime.MaxValue, "b", test, "a");
            var act = JsonConvert.SerializeObject(actual);

            //assert
            Assert.Equal(exp, act);
        }

        [Fact]
        public void UpdateTrailList_ShouldReturnUpdatedTrailList()
        {
            Trail test = new Trail();   
            
            //arrange
            BindingList<Trail> expected = new BindingList<Trail>();
            expected.Add(new Trail
            {
                Name = "a",
                Length = 25.5,
                Timestamp = DateTime.MaxValue,
                Location = "Vilnius",
                Organizer = "Petras"
            });

            expected.Add(new Trail
            {
                Name = "b",
                Length = 35.5,
                Timestamp = DateTime.MaxValue,
                Location = "Kaunas",
                Organizer = "Vilius"
            });

            //act
            BindingList<Trail> actual = new BindingList<Trail>();
            actual = test.UpdateTrailList(expected);

            //assert
            Assert.Equal(expected, actual);
        }
    }
}
