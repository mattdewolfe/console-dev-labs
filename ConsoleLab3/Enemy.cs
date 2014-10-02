using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLab3
{
    abstract class Enemy
    {
        public float x;
        public float y;
        public int hp;
        public bool alive;
        Sprite sprite;

        public Enemy()
        {
            alive = true;
            hp = 1;
        }
        public Enemy(float _x, float _y, int _hp, Sprite _sprite)
        {
            x = _x;
            y = _y;
            hp = _hp;
            sprite = _sprite;
        }
        public void TakeDamage(int _dam)
        {
            hp -= _dam;
            if (hp < 1)
                alive = false;
        }
        public bool IsAlive()
        {
            return alive;
        }
        public abstract void Move();
    }
}
