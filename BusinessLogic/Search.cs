using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Search
    {
        public int LenghtFrom { get; set; }
        public int LenghtTo { get; set; }

        public Search SearchLength(string LengthFrom, string LengthTo)
        {
            Search TempLength = new Search
            {
                LenghtFrom = int.Parse(LengthFrom),
                LenghtTo = int.Parse(LengthTo)
            };
            return TempLength;
        }
    }
}
