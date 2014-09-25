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
        { }
        public override void Speech()
        {
            Random rnd = new Random();
            int speach = rnd.Next(1, 3);
            if (speach == 1)
            {
                Console.WriteLine("  " + name + " > ' Rawwwwrwar. '");
            }
            else if (speach == 2)
            {
                Console.WriteLine("  " + name + " > ' Waaaaaor. '");
            }
            else
            {
                Console.WriteLine("  " + name + " > ' Mmph Rrrr. '");
            }
        }
    }
}
