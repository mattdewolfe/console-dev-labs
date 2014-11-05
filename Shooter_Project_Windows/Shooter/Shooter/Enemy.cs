using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace Shooter
{

    class Enemy : Entity
    {
        // The speed at which the enemy moves
        public float EnemyMoveSpeed;
        // Point value for killing this enemy
        public int Value;

        public void Initialize(Animation _animation, Vector2 _position)
        {
            // Load the enemy ship texture
            Animation = _animation;
            // Set the position of the enemy
            Position = _position;
            // Set the amount of damage the enemy can do
            Damage = 10;
            // Set how fast the enemy moves
            EnemyMoveSpeed = 6f;
            // Set the score value of the enemy
            Value = 100;
        }

        public override void Update(GameTime _gameTime)
        {
            // The enemy always moves to the left so decrement x
            Position.X -= EnemyMoveSpeed;
            base.Update(_gameTime);
        }

        public override void OnHit(Entity _ent)
        {
            base.OnHit(_ent);
        }
        public override void OnHit(Projectile _proj)
        {
            base.OnHit(_proj);
        }

        
    }
}
