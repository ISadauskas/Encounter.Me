using BusinessLogic;
using System;
using System.Collections.Generic;

namespace EncounterMeWF
{
    [Serializable]
    public class Trail
    {
        
        public int[] IndexID = new int[1];
        public int this[int index]
        {
            get => IndexID[index];
            set => IndexID[index] = value;
        }


        public int ID { get; set; }
        public string Name { get; set; }

        private double length;
        public double Length
        {
            get
            {
                return this.length;
            }
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                this.length = value;
            }
        }
        public List<string> Coordinates { get; set; }
        public string Season { get; set; }



        public Trail CreateTrail(string Id, string Length, int _Season, string Name = "Default Trail Name")
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
            Trail TempTrail = new Trail
            {
                ID = IndexID[0],
                Name = Name,
                Length = double.Parse(Length),
                Coordinates = new List<string> { },
                Season = temp.ToString(),
            };
            return TempTrail;
        }
    }
}
