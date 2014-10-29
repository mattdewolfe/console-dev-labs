using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Generic> list = new List<Generic>();

            for (int i = 0; i < 6; i++)
            {
                list.Add(new Generic(i * i));
            }
            
            foreach (Generic gen in list)
            {
                Console.WriteLine(gen.ID + " " + gen.value);
                Console.WriteLine(gen.ID != list[0].ID);
            }
        }
    }
}
