
namespace BusinessLogic
{
    public class Runs
    {
        public string RunOrWalk { get; set; }
        public double Distance { get; set; }
        public int CalloriesLost { get; set; }

        public Runs CreateRun(string RunOrWalk, string Weight, int CaloriesBurned)
        {
            Runs tempRun = new Runs
            {
                RunOrWalk = RunOrWalk,
                Distance = double.Parse(Weight),
                CalloriesLost = CaloriesBurned
            };
            return tempRun;
        }
    }
}
