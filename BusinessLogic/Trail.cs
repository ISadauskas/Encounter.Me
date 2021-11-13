using BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace EncounterMeWF
{
    [Serializable]
    public class Trail
    {
        private SignInJson _signInJson = new SignInJson();


        public string Name { get; set; }
        public double Length { get; set; }
        public DateTime Timestamp { get; set; }
        public string Location { get; set; }
        public string Organizer { get; set; }

        public Trail CreateTrail(string Length, DateTime StartDate, DateTime StartTime, string StartLocation, string Name = "Default Trail Name")
        {
            User OrganizerUser = _signInJson.JsonRead();
            Trail TempTrail = new Trail
            {
                Name = Name,
                Length = double.Parse(Length),
                Timestamp = StartDate.Date + StartTime.TimeOfDay,
                Location = StartLocation,
                Organizer = OrganizerUser.Username
            };
            return TempTrail;
        }
    
        public Trail ModifyTrail(string Length, DateTime StartDate, DateTime StartTime, string StartLocation, Trail CurrentTrail, string Name = "Default Trail Name")
        {
            User OrganizerUser = _signInJson.JsonRead();
            Trail TempTrail = new Trail
            {
                Name = Name,
                Length = double.Parse(Length),
                Timestamp = StartDate.Date + StartTime.TimeOfDay,
                Location = StartLocation,
                Organizer = OrganizerUser.Username
            };
            TempTrail.Organizer = CurrentTrail.Organizer;
            return TempTrail;
        }
    }
}
