using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncounterMeAPI.Models
{
    [Serializable]
    public class Trail
    {
        public string Name { get; set; }
        public double Length { get; set; }
        public DateTime Timestamp { get; set; }
        public string Location { get; set; }
        public string Organizer { get; set; }

        public Trail CreateTrail(string Length, DateTime StartDate, DateTime StartTime, string StartLocation, string Name = "Default Trail Name")
        {
            Trail TempTrail = new Trail
            {
                Name = Name,
                Length = double.Parse(Length),
                Timestamp = new DateTime(StartDate.Year, StartDate.Month, StartDate.Day, StartTime.Hour, StartTime.Minute, 00),
                Location = StartLocation,
                Organizer = Organizer
            };
            return TempTrail;
        }

        public Trail ModifyTrail(string Name, string Length, DateTime StartDate, DateTime StartTime, string StartLocation, string Organizer)
        {
            Trail TempTrail = new Trail
            {
                Name = Name,
                Length = double.Parse(Length),
                Timestamp = new DateTime(StartDate.Year, StartDate.Month, StartDate.Day, StartTime.Hour, StartTime.Minute, 00),
                Location = StartLocation,
                Organizer = Organizer
            };
            return TempTrail;
        }
    }
}
