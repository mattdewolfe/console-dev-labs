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

        public void Update(GameTime gameTime)
        {
            // The enemy always moves to the left so decrement x
            Position.X -= EnemyMoveSpeed;

            // Update the position of the Animation
            Animation.Position = Position;

            // Update Animation
            Animation.Update(gameTime);

            // If the enemy is past the screen or its health reaches 0, deactivate
            if (Position.X < -Width || Health <= 0)
            {
                // By setting the Active flag to false, the game will remove
                Active = false;
            }
        }
    }
}
