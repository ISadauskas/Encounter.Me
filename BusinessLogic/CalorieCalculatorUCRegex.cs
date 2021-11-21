using System.Text.RegularExpressions;

namespace BusinessLogic
{
    public class CalorieCalculatorUCRegex
    {
        public int Check(string RunWalkText, string WeightText,  string DurationText, string DistanceText)
        {
            Regex WeightRegex = new Regex("^[1-9][0-9]+.?[0-9]*$");
            bool WeightRegexCheck = WeightRegex.IsMatch(WeightText);
            Regex DistanceRegex = new Regex("^[0-9]+.?[0-9]*$");
            bool DistanceRegexCheck = DistanceRegex.IsMatch(DistanceText);
            Regex DurationRegex = new Regex("^[1-9][0-9]*$");
            bool DurationRegexCheck = DurationRegex.IsMatch(DurationText);
            if (RunWalkText == "")
                return 1;
            if (WeightText == "")
                return 2;
            if (!WeightRegexCheck)
                return 3;
            if (DurationText == "")
                return 4;
            if (!DurationRegexCheck)
                return 5;
            if (DistanceText == "")
                return 6;
            if (!DistanceRegexCheck)
                return 7;
            else
                return 0;
        }
    }
}
