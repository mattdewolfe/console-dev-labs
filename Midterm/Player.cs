using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    class Player
    {
        // Remaining hit points (0 = dead)
        private int hitPoints;
        // Store the players weapons
        public List<Pickup> weapons;
        // Unique ID
        private int ID;
        // Players name
        private string name;
        // Stores array position of currently equiped weapon
        private int currentWeapon;

        public Player()
        {
            name = "Bob";
            hitPoints = 3;
            ID = DateTime.Now.Millisecond + DateTime.Now.Second;
            currentWeapon = -1;
            weapons = new List<Pickup>(4);
        }
        public Player(string _n, int _hp)
        {
            hitPoints = _hp;
            name = _n;
            ID = DateTime.Now.Millisecond + DateTime.Now.Second;
            currentWeapon = -1;
            weapons = new List<Pickup>(4);
        }

        public void SetHp(int _val) { hitPoints = _val; }
        public int GetHp() { return hitPoints; }

        public void SetName(string _new) { name = _new; }
        public string GetName() { return name; }

        // Due to class structure this is very messy
        // would be ideal to add another base class seperate from pickup with necessary
        // functions to let us avoid these if statements
        public void UseWeapon()
        {
            if (weapons[currentWeapon].type == Pickup.PICKUP_TYPE.MELEE_WEAPON)
            {
                MeleeWeapon temp = (MeleeWeapon)weapons[currentWeapon];
                temp.Use();
            }
            else if (weapons[currentWeapon].type == Pickup.PICKUP_TYPE.RANGED_WEAPON)
            {
                RangedWeapon temp = (RangedWeapon)weapons[currentWeapon];
                temp.Use();
            }
        }

        public void SwitchWeapon(int _val)
        {
            // Error handle to ensure cannot switch to non-existent weapons
            // in future code
            currentWeapon = _val;
        }
        public void AddWeapon(RangedWeapon _new)
        {
            weapons.Add(_new);
            if (currentWeapon == -1)
                currentWeapon = 0;
        }
        public void AddWeapon(MeleeWeapon _new)
        {
            weapons.Add(_new);
            if (currentWeapon == -1)
                currentWeapon = 0;
        }
        public void TakeDamage(int _damage, string _source)
        {
            hitPoints -= _damage;
            if (hitPoints < 0)
                PlayerDied(_source);
        }

        public void PlayerDied(string _source)
        {
            Console.WriteLine(" " + name + " was fragged by " + _source + "!");
        }
    }
}
