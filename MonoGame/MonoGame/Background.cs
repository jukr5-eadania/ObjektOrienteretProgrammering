using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace MonoGame
{
    internal class Background : GameObject
    {
        private int number;

        public Background(int number)
        {
            this.number = number;
            velocity = new Vector2(0, 1);
            speed = 100;
        }

        public override void LoadContent(ContentManager content)
        {
            sprite = content.Load<Texture2D>("Backgrounds/darkPurple");
            position = new Vector2(0, sprite.Height * (float)-7.5 * number);
        }

        public override void Draw(SpriteBatch spritebatch)
        {
            spritebatch.Draw(sprite, position, null, Color.White, 0, new Vector2(0, 0), (float) 7.6, SpriteEffects.None, 1);
        }

        private void Respawn()
        {
            if (position.Y >= sprite.Height * 7.5)
            {
                position = new Vector2(0, sprite.Height * (float)-7.5);
            }
        }

        public override void Update(GameTime gameTime)
        {
            Move(gameTime);
            Respawn();
        }
    }
}
