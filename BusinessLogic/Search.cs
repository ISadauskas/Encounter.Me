using System;
using System.Collections.Generic;
namespace EncounterMeWF.UserControls
{
    public class Search
    {
       
        public int LenghtFrom { get; set; }
        public int LenghtTo { get; set; }

        public Search SearchLenght(string LengthFrom, string LengthTo)
        {
            Search TempLenght = new Search
            {
                LenghtFrom = int.Parse(LengthFrom),
                LenghtTo = int.Parse(LengthTo)
              
            };
            return TempLenght;
        }
    }
}