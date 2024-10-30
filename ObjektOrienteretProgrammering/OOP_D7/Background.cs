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
            position = new Vector2(GameWorld.Width / 2, GameWorld.Height / 2);
        }

        public override void Draw(SpriteBatch spritebatch)
        {
            spritebatch.Draw(sprite, position, null, Color.White, 0, new Vector2(sprite.Width / 2, sprite.Height / 2), (float) 7.5, SpriteEffects.None, 1);
        }

        public override void Update(GameTime gameTime)
        {
            Move(gameTime);
        }
    }
}
