using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLab3
{
    class LukeSkywalker : Player
    {
        public LukeSkywalker()
            : base("Luke Skywalker")
        {
            base.speech[0] = "I sense the conflict within you.";
            base.speech[1] = "May the force be with you";
            base.speech[2] = "I'll never join you.";
        }
    }
}
