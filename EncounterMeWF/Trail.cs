using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncounterMeWF
{
    [Serializable]
    class Trail
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }

        /*public override string ToString()
        {
            return string.Format("Trail information:\r\nID: {0}," +
                " \r\nName: {1}, \r\nDateOfBirth: {2}, \r\nAdress: {3}", ID, Name, DateOfBirth, Address);
        }*/
    }
}
