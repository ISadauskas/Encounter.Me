using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncounterMeWF
{
    [Serializable]
    public class Trail
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Length { get; set; }
        public List<string> Coordinates { get; set; }

    }
}
