using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Runs<TRunOrWalk, TDistance, TCalloriesLost>
    {
        public TRunOrWalk RunOrWalk { get; set; }
        public TDistance Distance { get; set; }
        public TCalloriesLost CalloriesLost { get; set; }
    }
}
