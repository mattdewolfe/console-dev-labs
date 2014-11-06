using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Shooter
{
    public enum ENTITY_TYPE
    {
        ENEMY = 0,
        PLAYER,
        PICKUP
    };
    abstract class Entity
    {
        // Animation representing the player
        public Animation Animation;
        // Position of the Player relative to the upper left side of the screen
        public Vector2 Position;
        // Amount of hit points that player has
        public int Health;
        // How much damage weapons do
        public int Damage;
        // State of the player
        public bool Active;
        // What type of entity is this
        private ENTITY_TYPE type;

        public Entity(ENTITY_TYPE _type) { type = _type; }
        public abstract void Initialize(Animation _animation, Vector2 _position);
        public abstract void OnHit(Entity _ent);
        public abstract void OnHit(Projectile _proj);
        
        public void Draw(SpriteBatch _spriteSheet)
        {
            Animation.Draw(_spriteSheet);
        }

        // Update the player animation
        public virtual void Update(GameTime gameTime)
        {
            Animation.Position = Position;
            Animation.Update(gameTime);
            CheckActive();
        }

        public void CheckActive()
        {
            if (Health <= 0 || Position.X < -Width)
            {
                Active = false;
            }
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

        // Get the entity type
        public ENTITY_TYPE GetEntityType() { return type; }
    }
}
