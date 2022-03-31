using System;
using Xunit;

using EncounterMeAPI.Services;
using EncounterMeAPI.Entities;

namespace EncounterMeTests
{
    public class StatisticsServiceTest
    {
        [Fact]
        public void Task_CalculateStatistics()
        {
            var statisticsService = new StatisticsService();
            var length = 100;
            var time = 50;
            var weight = 60;
            var expectedCalories = 5.50331;
            var trail = new Trail("Kelias", length, "Start", "End");
            var expectedResult = new WalkStatistics(time, length, length / time, expectedCalories);

            var result = statisticsService.CalculateStatistics(trail, time, weight);

            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Task_CalculateStatistics_InvalidSpeed()
        {
            var statisticsService = new StatisticsService();
            var length = 100;
            var time = 1;
            var weight = 60;
            var trail = new Trail("Kelias", length, "Start", "End");
 
            Assert.Throws<ArgumentException>(() => statisticsService.CalculateStatistics(trail, time, weight));
        }
    }
}
