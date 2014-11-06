using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Shooter
{
    public enum POWERUP_TYPE
    {
        SHIELD = 0,
        GUNPOWER
    }
    class Powerup : Entity
    {
        private float yMoveSpeed;
        private float xMoveSpeed;
        private POWERUP_TYPE powerType;

        public Powerup(POWERUP_TYPE _ptype) : base(ENTITY_TYPE.PICKUP) 
        {
            powerType = _ptype;
        }

        public override void Initialize(Animation _animation, Vector2 _position)
        {
            // Load the enemy ship texture
            Animation = _animation;
            // Set the position of the enemy
            Position = _position;
            Damage = 0;
            // Set how fast the power up moves along each axis
            xMoveSpeed = 1f;
            yMoveSpeed = 1f;
            // Set to active
            Active = true;
        }

        public override void Update(GameTime _gameTime)
        {
            Position.X -= xMoveSpeed;
            //Position.Y -= yMoveSpeed;
            base.Update(_gameTime);
        }

        public override void OnHit(Entity _ent)
        {
            if (_ent.GetEntityType() == ENTITY_TYPE.PLAYER)
            {
                // Pass power to player
                Active = false;
            }
        }
        public override void OnHit(Projectile _proj)
        {

        }

    }
}
