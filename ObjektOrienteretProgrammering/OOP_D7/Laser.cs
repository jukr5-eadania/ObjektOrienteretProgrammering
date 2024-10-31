using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace OOP_D7
{
    internal class Laser : GameObject
    {
        public Laser(Texture2D sprite, Vector2 position)
        {
            this.sprite = sprite;
            this.position = position;
            velocity = new Vector2(0, -1);
            speed = 300;
        }

        public override void LoadContent(ContentManager content)
        {
            
        }

        public override void Update(GameTime gameTime)
        {
            Move(gameTime);
            Despawn();
        }

        public void Despawn()
        {
            if (position.Y < 0 - sprite.Height)
            {
                GameWorld.RemoveGameObject(this);
            }
        }
    }
}
