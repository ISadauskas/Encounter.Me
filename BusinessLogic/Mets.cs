using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
   public class Mets
    {
        public double MetValue(double Speed)
        {
            if (Speed <= 4)
                return 3;
            if (Speed <= 4.8)
                return 3.5;
            if (Speed <= 5.6)
                return 4;
            if (Speed <= 7.2)
                return 4.5;
            if (Speed <= 8)
                return 8;
            if (Speed <= 9.7)
                return 10;
            if (Speed <= 11.3)
                return 11.5;
            if (Speed <= 12.9)
                return 13.5;
            else return 0;
        }
    }
}
