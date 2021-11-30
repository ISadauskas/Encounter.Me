using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using BusinessLogic;
using System.Data;

namespace BusinessLogic.Tests
{
    public class RunsSQLTests
    {
        RunsSQL test = new RunsSQL();
        public string ConnectionString = "Data Source=encountermedbserver.database.windows.net;Initial Catalog=EncounterMeDb;User ID=Adminas1;Password=Password1";
        public int index = 0;

        //TODO: finish figuring out testing with Datatables
        /*
        [Fact]
        public void UpdateTable_ShouldReturnDataTable()
        {
            //arrange
            DataTable expected = new DataTable();
            DataRow expectedRow;
            expectedRow = expected.NewRow();

            //act
            DataTable actual = test.UpdateTable("Gedas");

            //assert
            Assert.Equal(expected, actual);

            foreach (DataRow row in actual.Rows)
            {
                Assert.Equal(row, actual.Rows);
            }
        }
        */

        [Fact]
        public void FindMostBurnedCalories_ShouldReturnOneTwoEightOne()
        {
            //arrange
            int expected = 1281;

            //act
            int actual = test.FindMostBurnedCalories("Gedas");

            //assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void FindAllBurnedCalories_ShouldReturnOneTwoEightOne()
        {
            //arrange
            int expected = 1281;

            //act
            int actual = test.FindMostBurnedCalories("Gedas");

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FindLongestPace_ShouldReturnTen()
        {
            //arrange
            double expected = 10;

            //act
            double actual = test.FindLongestPace("Gedas", "Run");

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FindLongestPace_ShouldReturn()
        {
            //arrange
            double expected = 0;

            //act
            double actual = test.FindLongestPace("Gedas", "Walk");

            //assert
            Assert.Equal(expected, actual);
        }
    }
}
