using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Shooter
{
    class Player
    {
        // player sprite
        public Texture2D playerTexture;
        // store position of player
        public Vector2 position;

        public bool isActive;

        // Hit points
        public int health;
        
        // Get width and height of ship from texture
        public int width { get {return playerTexture.Width; }
        public int height { get {return playerTexture.Height; }

        public void Initialize()
        {
        }

        public void Update()
        {
        }

        public void Draw()
        {
        }
    }
}