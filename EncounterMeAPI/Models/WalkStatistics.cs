using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncounterMeAPI.Models
{
    public class WalkStatistics
    {
        public int Time { get; set; }
        public double Speed { get; set; }
        public double Length { get; set; }
        public double Calories { get; set; }
        public WalkStatistics(int time, double speed, double length, double calories)
        {
            Time = time;
            Speed = speed;
            Length = length;
            Calories = calories;
        }
    }
}
