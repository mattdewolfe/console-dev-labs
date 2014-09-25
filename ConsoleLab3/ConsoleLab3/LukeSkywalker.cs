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
        {  }
        public override void Speech()
        {
            Random rnd = new Random();
            int speach = rnd.Next(1, 3);
            if (speach == 1)
            {
                Console.WriteLine("  " + name + " > ' I sense the conflict within you. '");
            }
            else if (speach == 2)
            {
                Console.WriteLine("  " + name + " > ' May the force be with you. '");
            }
            else
            {
                Console.WriteLine("  " + name + " > ' I'll never join you. '");
            }
        }
    }
}
