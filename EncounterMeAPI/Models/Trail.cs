using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncounterMeAPI.Models
{
    // TODO: modify this according to our use
    [Serializable]
    public class Trail
    {
        public string Name { get; set; }
        public double Length { get; set; }
        public string StartLocation { get; set; }
        public string EndLocation { get; set; }
        public DateTime UploadDate { get { return _uploadDate; } }

        private DateTime _uploadDate;

        public Trail(string name, double length, DateTime uploadDate, string startLocation, string endLocation)
        {
            this.Name = name;
            this.Length = length;
            this.StartLocation = startLocation;
            this.EndLocation = endLocation;
            this._uploadDate = uploadDate;
        }
    }
}
