namespace EncounterMeAPI.Entities
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
