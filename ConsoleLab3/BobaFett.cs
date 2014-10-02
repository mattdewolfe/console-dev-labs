using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLab3
{
    class BobaFett :  Player
    {
        public BobaFett()
            : base("Boba Fett")
        {
            base.speech[0] = "He's no good to me dead.";
            base.speech[1] = "Jedi scum.";
            base.speech[2] = "/draws his blaster/";
        }
    }
}
