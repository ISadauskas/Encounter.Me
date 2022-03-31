using System;

namespace EncounterMeAPI.Entities
{
    public class WalkStatistics
    {
        public int Time { get; set; }
        public double Length { get; set; }
        public double Speed { get; set; }
        public double Calories { get; set; }
        public WalkStatistics(int time, double length, double speed, double calories)
        {
            Time = time;
            Length = length;
            Speed = speed;
            Calories = calories;
        }

        public override bool Equals(object obj)
        {
            var walkStats = (WalkStatistics)obj;
            var maxDifference = 1e-9;

            if (walkStats == null)
            {
                return false;
            }

            if (walkStats.Time != Time)
            {
                return false;
            }
            if (walkStats.Length != Length)
            {
                return false;
            }
            if (Math.Abs(walkStats.Calories - Calories) >= maxDifference)
            {
                return false;
            }

            return true;
        }

        public override int GetHashCode() => HashCode.Combine(Time, Length, Speed, Calories);
    }
}
