using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5
{
    class Program
    {
        static void Main(string[] args)
        {
            Dinklage<int> lList = new Dinklage<int>();

            lList.AddEntry(5);
            lList.AddEntry(3);
            lList.AddEntry(7);
            lList.AddEntry(17);
            lList.AddEntry(7);

            lList.OutputAll();
            lList.DeleteByValue(5);
            lList.OutputAll();
        }
    }
}
