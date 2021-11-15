using System.Text.RegularExpressions;

namespace BusinessLogic
{
    public class CalorieCalculatorUCRegex
    {
        public int Check(string RunWalkText, string WeightText, string DistanceText)
        {
            Regex WeightRegex = new Regex("^[0-9]+.?[0-9]*$");
            bool WeightRegexCheck = WeightRegex.IsMatch(WeightText);
            Regex DistanceRegex = new Regex("^[0-9]+.?[0-9]*$");
            bool DistanceRegexCheck = DistanceRegex.IsMatch(DistanceText);
            if (RunWalkText == "")
                return 1;
            if (WeightText == "")
                return 2;
            if (!WeightRegexCheck)
                return 3;
            if (DistanceText == "")
                return 4;
            if (!DistanceRegexCheck)
                return 5;
            else
                return 0;
        }
    }
}
