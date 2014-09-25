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
        {  }
        public override void Speech()
        {
            Random rnd = new Random();
            int speach = rnd.Next(1, 3);
            if (speach == 1)
            {
                Console.WriteLine("  " + name + " > ' He's no good to me dead. '");
            }
            else if (speach == 2)
            {
                Console.WriteLine("  " + name + " > ' Jedi scum. '");
            }
            else
            {
                Console.WriteLine("  " + name + " > /draws his blaster/ ");
            }
        }
    }
}
