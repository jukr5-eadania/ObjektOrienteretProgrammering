using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace OOP_D7
{
    internal abstract class GameObject
    {
        protected Texture2D sprite;
        protected Vector2 position = new Vector2 (GameWorld.Width/2, GameWorld.Height);

        public void LoadContent(ContentManager content)
        {
            sprite = content.Load<Texture2D>("Sprites\\PlayerAnimation\\PlayerNormal\\Forward\\1fwd");
        }

        public abstract void Update(GameTime gametime);

        public void Draw(SpriteBatch spritebatch)
        {
            spritebatch.Draw(sprite, position, null, Color.White, 0, new Vector2(sprite.Width / 2, sprite.Height / 2), 1, SpriteEffects.None, 1);
        }
    }
}
