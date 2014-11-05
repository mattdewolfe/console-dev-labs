using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Shooter
{
    class Entity
    {
        // Animation representing the player
        public Animation Animation;
        // Position of the Player relative to the upper left side of the screen
        public Vector2 Position;
        // State of the player
        public bool Active;
        // Amount of hit points that player has
        public int Health;
        // How much damage weapons do
        public int Damage;

        public Entity() { }

        public virtual void Init(Animation _animation, Vector2 _position) { }
        public virtual void OnHit(Entity _ent)
        {

        }

        public void Draw(SpriteBatch _spriteSheet)
        {
            Animation.Draw(_spriteSheet);
        }

        // Update the player animation
        public virtual void Update(GameTime gameTime)
        {
            Animation.Position = Position;
            Animation.Update(gameTime);
        }

        // Get the width of the player ship
        public int Width
        {
            get { return Animation.FrameWidth; }
        }

        // Get the height of the player ship
        public int Height
        {
            get { return Animation.FrameHeight; }
        }
    }
}
