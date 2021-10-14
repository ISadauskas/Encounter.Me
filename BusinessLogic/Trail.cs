using System;
using System.Collections.Generic;

namespace EncounterMeWF
{
    [Serializable]
    public class Trail
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Length { get; set; }
        public List<string> Coordinates { get; set; }



        public Trail CreateTrail(string Id, string Length, string Name = "Defaul Trail Name")
        {
            Trail TempTrail = new Trail
            {
                ID = int.Parse(Id),
                Name = Name,
                Length = double.Parse(Length),
                Coordinates = new List<string> { }
            };
            return TempTrail;
        }
    }
}
