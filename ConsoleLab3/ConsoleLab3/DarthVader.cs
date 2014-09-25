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
        { }
        public override void Speech()
        {
            Random rnd = new Random();
            int speach = rnd.Next(1, 3);
            if (speach == 1)
            {
                Console.WriteLine("  " + name + " > ' If you only knew the power... '");
            }
            else if (speach == 2)
            {
                Console.WriteLine("  " + name + " > ' All to easy. '");
            }
            else
            {
                Console.WriteLine("  " + name + " > ' I find your lack of faith disturbing. '");
            }
        }
        
    }
}
