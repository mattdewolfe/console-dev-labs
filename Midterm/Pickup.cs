using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    class Pickup
    {
        public enum PICKUP_TYPE { AMMO = 0, RANGED_WEAPON, MELEE_WEAPON, HEALTH };
        public PICKUP_TYPE type;

        public string name;

        public Pickup(PICKUP_TYPE _t, string _n)
        {
            type = _t;
            name = _n;
        }
    }
}
