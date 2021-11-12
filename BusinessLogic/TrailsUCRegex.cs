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
        public int CheckTrail(string TrailIdText, string TrailLengthText, string TrailStartLocationText)
        {
            Regex IdRegex = new Regex("^[0-9]+$");
            bool IdRegexCheck = IdRegex.IsMatch(TrailIdText);
            Regex LengthRegex = new Regex("^[0-9]+.?[0-9]*$");
            bool LengthRegexCheck = LengthRegex.IsMatch(TrailLengthText);
            if (TrailIdText == "")
                return 1;
            if (!IdRegexCheck)
                return 2;
            if (TrailLengthText == "")
                return 3;
            if (!LengthRegexCheck)
                return 4;
            if (TrailStartLocationText == "")
                return 5;
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
