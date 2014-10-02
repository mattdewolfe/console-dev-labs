using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLab3
{
    class DarthVader : Player
    {
        public DarthVader()
            : base("Darth Vader")
        {
            base.speech[0] = "If you only knew the power...";
            base.speech[1] = "All to easy.";
            base.speech[2] = "I find your lack of faith disturbing.";
        }
    }
}
