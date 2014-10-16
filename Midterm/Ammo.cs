using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    class Ammo : Pickup
    {
        public enum AMMO_TYPE { BULLET, ROCKET, ARROW, LASER };
        public AMMO_TYPE ammo;
        // Damage of this ammo type
        public float damage;
        // Max range ( in meters )
        public int range;

        public Ammo(AMMO_TYPE _t, float _dam, int _range) :
            base (PICKUP_TYPE.AMMO, "ammo")
        {
            ammo = _t;
            damage = _dam;
            range = _range;
        }

        public bool CheckRange()
        {
            // Raycast at target to determine hit/not hit
            return true;
        }
    }
}
