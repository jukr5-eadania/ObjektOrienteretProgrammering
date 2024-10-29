using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace OOP_D7
{
    internal class GameObject
    {
        private Texture2D sprite;
        private Vector2 position;

        public void LoadContent(ContentManager content)
        {
            sprite = content.Load<Texture2D>("Sprites\\PlayerAnimation\\PlayerNormal\\Forward\\1fwd");
        }

        public void Draw(SpriteBatch spritebatch)
        {
            spritebatch.Draw(sprite, position, Color.White);
        }
    }
}
