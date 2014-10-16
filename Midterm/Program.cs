using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player("Bill", 5);
            
            RangedWeapon laser = new RangedWeapon("Beam",
                Ammo.AMMO_TYPE.LASER, 
                2.5f, 
                100,
                50);
            
            MeleeWeapon spearOfLonginus = new MeleeWeapon("Spear of Longinus", 
                4,
                10.5f);

            // Add some weapons
            player1.AddWeapon(laser);
            player1.AddWeapon(spearOfLonginus);

            // Test weapon use
            player1.UseWeapon();
            player1.SwitchWeapon(1);
            player1.UseWeapon();

            // Hurt the player
            player1.TakeDamage(2, "God");

            // Kill the player
            player1.TakeDamage(99, "Fate");
        }
    }
}
