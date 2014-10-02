using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLab3
{
    abstract class Player
    {
        // Track the player position on the map
        // Position starts at -1 in order to flag it as unused
        public int position;
        // Store how much cash the player has
        protected int money;
        // Store the piece name
        public string name;
        // Store the player who is using this piece
        protected int player;
        // Store the players speech output
        protected string[] speech;

        public Player(string _name)
        {
            player = 0;
            position = -1;
            money = 1500;
            name = _name;
            speech = new String[3];
        }
        public void Move(int _value)
        {
            Console.WriteLine(" :>: Player " + player + " moves " + _value + " spaces.");
            position += _value;
            if (position > 40)
            {
                position -= 40;
            }
            Console.WriteLine(" :>: Player " + player + " is on space " + position + ".");
        }
        public void SetPlayer(int val) 
        { 
            player = val;
            position = 0;
        }
        public int GetPlayer() { return player; }
        public void Speech()
        {
            Random rnd = new Random();
            int num = rnd.Next(0, 2);  
            Console.WriteLine("  " + name + " > ' " + speech[num] + " '");
        }
        
    }
}
