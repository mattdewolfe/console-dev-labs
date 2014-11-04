using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Shooter
{
    class Player
    {
        // store position of player
        public Vector2 position;

        public bool isActive;

        // Hit points
        public int health;

        // Animation representing the player
        public Animation playerAnimation;

        // Get width and height of ship from texture
        public int width { get {return playerAnimation.frameWidth; } }
        public int height { get { return playerAnimation.frameHeight; } }

        // Initialize the player
        public void Initialize(Animation _animation, Vector2 _position)
        {
            playerAnimation = _animation;

            // Set the starting position of the player around the middle of the screen and to the back
            position = _position;

            // Set the player to be active
            isActive = true;

            // Set the player health
            health = 100;
        }

        // Update the player animation
        public void Update(GameTime _gameTime)
        {
            playerAnimation.position = position;
            playerAnimation.Update(_gameTime);
        }

        // Draw the player
        public void Draw(SpriteBatch _spriteBatch)
        {
            playerAnimation.Draw(_spriteBatch);
        }
    }
}