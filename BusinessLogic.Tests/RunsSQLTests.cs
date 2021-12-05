using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using BusinessLogic;
using System.Data;
using Database.Commands;

namespace BusinessLogic.Tests
{
    public class RunsSQLTests
    {
        //RunsSQL test = new RunsSQL();
        RunsCmd test = new RunsCmd();
        //public string ConnectionString = "Data Source=encountermedbserver.database.windows.net;Initial Catalog=EncounterMeDb;User ID=Adminas1;Password=Password1";
        //public int index = 0;

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
        public void FindMostBurnedCalories_ShouldReturnEightThreeTwo()
        {
            //arrange
            int expected = 832;

            //act
            int actual = test.FindMostBurnedCalories("Gedas");

            //assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void FindAllBurnedCalories_ShouldReturnOneThreeEightSeven()
        {
            //arrange
            int expected = 1387;

            //act
            int actual = test.FindAllBurnedCalories("Gedas");

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FindLongestPace_ShouldReturnTen()
        {
            //arrange
            Decimal expected = Decimal.Parse("10,00");

            //act
            Decimal actual = test.FindLongestPace("Gedas", "Run");

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FindLongestPace_ShouldReturn()
        {
            //arrange
            Decimal expected = Decimal.Parse("8,00");

            //act
            Decimal actual = test.FindLongestPace("Gedas", "Walk");

            //assert
            Assert.Equal(expected, actual);
        }
    }
}
