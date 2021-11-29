
namespace BusinessLogic
{
    public class Runs
    {
        public string Pace { get; set; }
        public double Distance { get; set; }
        public int CaloriesLost { get; set; }

        public Runs CreateRun(string Pace, string Weight, int CaloriesBurned)
        {
            Runs tempRun = new Runs
            {
                Pace = Pace,
                Distance = double.Parse(Weight),
                CaloriesLost = CaloriesBurned
            };
            return tempRun;
        }
    }
}
