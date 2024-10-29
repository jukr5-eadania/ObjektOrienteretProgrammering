using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace OOP_D7
{
    internal abstract class GameObject
    {
        private Texture2D sprite;
        protected Vector2 position;

        public void LoadContent(ContentManager content)
        {
            sprite = content.Load<Texture2D>("Sprites\\PlayerAnimation\\PlayerNormal\\Forward\\1fwd");
        }

        public abstract void Update(GameTime gametime);

        public void Draw(SpriteBatch spritebatch)
        {
            spritebatch.Draw(sprite, position, Color.White);
        }
    }
}
