using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    class MeleeWeapon : Pickup
    {
        // Max range of this weapon (in meters)
        private int range;
        // Damage per attack
        private float weaponDamage;

        // Create a basic sword
        public MeleeWeapon(string _n) :
            base(PICKUP_TYPE.MELEE_WEAPON, _n)
        {
            range = 3;
            weaponDamage = 3;
        }

        // Create an advanced weapon
        public MeleeWeapon(string _n, int _range, float _damage) :
            base(PICKUP_TYPE.MELEE_WEAPON, _n)
        {
            range = _range;
            weaponDamage = _damage;
        }

        public void Use()
        {
            Console.WriteLine(" You attacked with the " + name + "!");
        }
    }
}
