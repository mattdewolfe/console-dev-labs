using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace Shooter
{
    class Player : Entity
    {
        // Initialize the player
        public void Initialize(Animation _animation, Vector2 _position)
        {
            Animation = _animation;
            // Set the starting position of the player around the middle of the screen and to the back
            Position = _position;
            // Set the player to be active
            Active = true;
            // Set the player health
            Health = 100;
        }
    }
}
