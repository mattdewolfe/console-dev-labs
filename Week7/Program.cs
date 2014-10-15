using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7
{
    class Program
    {
        public delegate void ConvertFromUSD(float USD);

        public event ConvertFromUSD moneyExchange;

        public void ToYen(float USD)
        { 
            float converted = USD*107;
            Console.WriteLine("$" + USD + " USD = " + converted + " Yen");
        }

        public void ToCad(float USD)
        {
            double converted = USD * 1.08;
            Console.WriteLine("$" + USD + " USD = " + converted + " CAD");
        }

        public void ToBaht(float USD)
        {
            float converted = USD * 1073;
            Console.WriteLine("$" + USD + " USD = " + converted + " Baht");
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.SetupConversions();
        }

        public void SetupConversions()
        {
            moneyExchange += ToCad;
            moneyExchange += ToYen;
            moneyExchange += ToBaht;
            moneyExchange += usd => Console.WriteLine("$" + usd + " USD = " + usd*10 + " Pesos");
            moneyExchange(100);
        }

    }
}

