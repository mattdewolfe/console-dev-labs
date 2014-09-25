using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLab3
{
    class Zombie : Enemy
    {
        float targetX;
        float directionX;

        Zombie(float x, float y, Sprite sprite) : base (x, y, 2, sprite)
        {
            //targetX = GetPlayerX();
            directionX = 1.0f;
        }
        public override void Move()
        {
            if (targetX > x)
            {
                directionX *= -1.0f;
            }
            else if (targetX < x)
            {
                directionX *= -1.0f;
            }
        }
    }
}
