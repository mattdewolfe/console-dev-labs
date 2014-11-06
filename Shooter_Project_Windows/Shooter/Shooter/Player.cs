using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Shooter
{
    class Player : Entity
    {
        public Player() : base(ENTITY_TYPE.PLAYER)
        { }
        // Initialize the player
        public override void Initialize(Animation _animation, Vector2 _position)
        {
            Animation = _animation;
            // Set the starting position of the player around the middle of the screen and to the back
            Position = _position;
            // Set the player to be active
            Active = true;
            // Set the player health
            Health = 100;
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }
        public override void OnHit(Entity _ent)
        {
            if (_ent.GetEntityType() == ENTITY_TYPE.ENEMY)
            {
                Health = 0;
                Active = false;
            }
            else
            {

            }
        }
        public override void OnHit(Projectile _proj)
        {
            
        }
    }
}
