using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLab3
{
    class Chewie : Player
    {
        public Chewie()
            : base("Chewie")
        {
            base.speech[0] = "Rawwwwrwar.";
            base.speech[1] = "Waaaaaor.";
            base.speech[2] = "Mmph Rrrr.";
        }
    }
}
