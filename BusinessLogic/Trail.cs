using BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace EncounterMeWF
{
    [Serializable]
    public class Trail : IEquatable<Trail>
    {
        private SignInJson _signInJson = new SignInJson();

        public int[] IndexID = new int[1];
        public int this[int index]
        {
            get => IndexID[index];
            set => IndexID[index] = value;
        }

        public bool Equals(Trail other)
        {
            if (other == null)
                return false;

            if (this.ID == other.ID)
                return true;
            else
                return false;
        }

        public bool CheckTrailID(BindingList<Trail> TrailList, Trail tempTrail)
        {
            foreach (var item in TrailList)
            {
                if (tempTrail.Equals(item))
                {
                    return true;
                }
            }
            return false;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public double Length { get; set; }
        public string Season { get; set; }
        public DateTime Timestamp { get; set; }
        public string Location { get; set; }
        public string Organizer { get; set; }

        public Trail CreateTrail(string Id, string Length, int _Season, DateTime StartDate, DateTime StartTime, string StartLocation, string Name = "Default Trail Name")
        {
            SeasonEnum temp = SeasonEnum.Summer;

            switch (_Season)
            {
                case 0:
                    temp = SeasonEnum.Summer;
                    break;

                case 1:
                    temp = SeasonEnum.Autumn;
                    break;

                case 2:
                    temp = SeasonEnum.Winter;
                    break;

                case 3:
                    temp = SeasonEnum.Spring;
                    break;

                default:
                    temp = SeasonEnum.Summer;
                    break;
            }

            IndexID[0] = int.Parse(Id);
            User OrganizerUser = _signInJson.JsonRead();
            Trail TempTrail = new Trail
            {
                ID = IndexID[0],
                Name = Name,
                Length = double.Parse(Length),
                Season = temp.ToString(),
                Timestamp = StartDate.Date + StartTime.TimeOfDay,
                Location = StartLocation,
                Organizer = OrganizerUser.Username
            };
            return TempTrail;
        }
    
        public Trail ModifyTrail(string Id, string Length, int _Season, DateTime StartDate, DateTime StartTime, string StartLocation, Trail CurrentTrail, string Name = "Default Trail Name")
        {
            SeasonEnum temp = SeasonEnum.Summer;

            switch (_Season)
            {
                case 0:
                    temp = SeasonEnum.Summer;
                    break;

                case 1:
                    temp = SeasonEnum.Autumn;
                    break;

                case 2:
                    temp = SeasonEnum.Winter;
                    break;

                case 3:
                    temp = SeasonEnum.Spring;
                    break;

                default:
                    temp = SeasonEnum.Summer;
                    break;
            }

            IndexID[0] = int.Parse(Id);
            User OrganizerUser = _signInJson.JsonRead();
            Trail TempTrail = new Trail
            {
                ID = IndexID[0],
                Name = Name,
                Length = double.Parse(Length),
                Season = temp.ToString(),
                Timestamp = StartDate.Date + StartTime.TimeOfDay,
                Location = StartLocation,
                Organizer = OrganizerUser.Username
            };
            TempTrail.Organizer = CurrentTrail.Organizer;
            return TempTrail;
        }
    }
}
