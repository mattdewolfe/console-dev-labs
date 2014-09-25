using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLab3
{
    /* Medusa head enemy
     * Movements across screen from left or right side
     * in parabolic arcs
     * Should only have 1 hitpoint
     * */
    class Medusa : Enemy
    {
        float rangeY;   // How far along Y axis head will arc
        float speedY;   // How fast medusa head moves along arcing path
        float startY;   // Store starting position of head to determine when to reverse path
        float speedX;   // How fast meduas head moves along the screen
        bool isGolden;  // Store if it is a golden meduas head (will turn enemies to stone)
        Medusa(float x, float y, Sprite sprite, bool _golden)
            : base(x, y, 1, sprite)
        {
            /* 
             * if (x >= screen.width)
             *      speedX = -1.0f;
             * else
             *      speedX = 1.0f;
             * rangeY = screen.height/3;
             */
            rangeY = 0;
            speedY = 2.0f;
            isGolden = _golden;
        }
        public override void Move()
        {
            if (speedY > 0)
            {
                if (y > startY + rangeY)
                {
                    SwitchYDirection();
                }
            }
            else if (y < startY - rangeY)
            {
                SwitchYDirection();
            }
            y += speedY;
            x += speedX;
        }
        void SwitchYDirection()
        {
            speedY *= -1.0f;
        }
    }
}
