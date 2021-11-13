using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class TrailsUCRegex
    {
        public int CheckTrail(string TrailLengthText, string TrailStartLocationText)
        {
            Regex LengthRegex = new Regex("^[0-9]+.?[0-9]*$");
            bool LengthRegexCheck = LengthRegex.IsMatch(TrailLengthText);
            if (TrailLengthText == "")
                return 1;
            if (!LengthRegexCheck)
                return 2;
            if (TrailStartLocationText == "")
                return 3;
            else
                return 0;
        }

        public int CheckSearch(string FromText, string ToText)
        {
            Regex SearchRegex = new Regex("^[0-9]+$");
            bool fromCheck = SearchRegex.IsMatch(FromText);
            bool toCheck = SearchRegex.IsMatch(ToText);

            if (FromText == "" || ToText == "")
                return 1;
            if (!fromCheck || !toCheck)
                return 2;
            if (int.Parse(FromText) > int.Parse(ToText))
                return 3;
            else
                return 0;
        }
    }
}
