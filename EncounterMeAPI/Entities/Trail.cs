using System;

namespace EncounterMeAPI.Entities
{
    public class Trail
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Length { get; set; }
        public string StartLocation { get; set; }
        public string EndLocation { get; set; }
        public DateTime UploadDate { get; }
        public int Rating { get; set;  }

        public Trail(string name, double length, string startLocation, string endLocation)
        {
            Name = name;
            Length = length;
            StartLocation = startLocation;
            EndLocation = endLocation;
            UploadDate = DateTime.Now;
        }
    }
}
