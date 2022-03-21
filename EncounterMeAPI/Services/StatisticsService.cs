using EncounterMeAPI.Models;
using System;

namespace EncounterMeAPI.Services
{
    public class StatisticsService
    {
        public WalkStatistics CalculateStatistics(Trail trail, int time, double weight)
        {
            var speed = CalculateSpeed(trail, time);
            var calories = CalculateCalories(speed, time, weight);
            var result = new WalkStatistics(time, speed, trail.Length, calories);
            return result;
        }

        private double CalculateCalories(double speed, int time, double weight)
        {
            var speedInKPH = 3.6 * speed;

            // https://fitness.stackexchange.com/questions/25176/calculate-burned-calories-running-without-heart-rate
            // CB = [0.0215 x KPH3 - 0.1765 x KPH2 + 0.8710 x KPH + 1.4577] x WKG x T

            var speedCoef = 0.0215 * Math.Pow(speedInKPH, 3) - 0.1765 * Math.Pow(speedInKPH, 2) + 0.8710 * speedInKPH + 1.4577;
            var calories = speedCoef * weight * ((double)time / 3600);

            return calories;
        }

        private double CalculateSpeed(Trail trail, int time)
        {
            return trail.Length / time;
        }
    }
}
