using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace OOP_D7
{
    internal class Background : GameObject
    {
        public Background()
        {
            velocity = new Vector2(0, 1);
            speed = 100;
        }

        public override void LoadContent(ContentManager content)
        {
            sprite = content.Load<Texture2D>("Backgrounds/darkPurple");
        }

        public override void Update(GameTime gameTime)
        {
            Move(gameTime);
        }
    }
}
