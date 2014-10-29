using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week9
{
    class Generic
    {
        public static int ID_COUNT = 0;
        public int ID;

        public int value;

        public Generic()
        {
            value = 0;
            ID = ID_COUNT;
            ID_COUNT++;
        }
        public Generic(int _val)
        {
            value = _val;
            ID = ID_COUNT;
            ID_COUNT++;
        }

        public static Generic operator +(Generic x, Generic y)
        {
            return new Generic(x.value + y.value);
        }

        public static bool operator ==(Generic x, Generic y)
        {
            return (x.ID == y.ID);
        }
        public static bool operator !=(Generic x, Generic y)
        {
            return (x.ID != y.ID);
        }
    }
}
