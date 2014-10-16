using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    class RangedWeapon : Pickup
    {
        // Ammo per magazine
        private int magazineSize;
        // Current ammo in weapon
        private int currentAmmo;
        // Max ammo count (based on full magazines)
        private int maxMagazines;
        // How many magazines does the weapon have left
        private int magazines;

        // Ammo type for this weapon
        public Ammo ammo;

        // Create a basic gun
        public RangedWeapon(string _n) :
            base(PICKUP_TYPE.RANGED_WEAPON, _n)
        {
            magazineSize = 9;
            currentAmmo = magazineSize;
            maxMagazines = 2;
            magazines = 1;
            ammo = new Ammo(Ammo.AMMO_TYPE.BULLET, 5, 30);
        }

        // Create custom weapons
         public RangedWeapon(string _n, Ammo.AMMO_TYPE _a, float _damage, int _range, int _magazineSize) :
            base(PICKUP_TYPE.RANGED_WEAPON, _n)
         {
             magazineSize = _magazineSize;
             currentAmmo = magazineSize;
             maxMagazines = 2;
             magazines = 1;
             ammo = new Ammo(_a, _damage, _range);
         }

        public void Use()
        {
            if (CheckAmmo())
            {
                Console.WriteLine(" You shot the " + name + "!");
            }
            else 
            {
                Console.WriteLine(" The " + name + " is out of ammo.");
            }
        }

        public bool CheckAmmo()
        {
            if (currentAmmo > 0)
                return true;
            else if (magazines > 0)
            {
                Reload();
                return false;
            }
            else
            {
                return false;
            }
        }
        // Reload the player weapon
        public void Reload()
        {
            // Ensure player has a magazine left and 
            // the current magazine is not full
            if (magazines > 0 && currentAmmo < magazineSize)
            {
                currentAmmo = magazineSize;
                magazines--;
                // Sprite.Play(Reload);
            }
        }
    }
}
