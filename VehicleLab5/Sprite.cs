using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleLab5
{
    class Sprite : Component
    {
        // Store visuals
        private string[] image;
        // Store x position
        public int x;
        // Store y position
        public int y;

        // Constructor requires a string for image
        // Optional x and y positions
        public Sprite(string[] _img, int _x = 0, int _y = 0) :
            base("Sprite", true)
        {
            x = _x;
            y = _y;
            image = _img;
        }

        // Draw the sprite
        public override void Update()
        {
            // Store array length
            int tempCount = image.Count();
            // Iterate through and draw each string
            // Offset by x and y
            for (int i = 0; i < tempCount; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    Console.Write(" ");
                }
                Console.Write(image[i]);
                Console.Write("\n");
            }
        }
        // Update the x and y positions of sprite
        public void UpdatePOS(int _x, int _y)
        {
            x = _x;
            y = _y;
        }
    }
}
