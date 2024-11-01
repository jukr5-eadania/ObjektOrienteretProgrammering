using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace MonoGame
{
    internal class Explosion : GameObject
    {
        private float timeElapsed;
        private int currentIndex;
        private Texture2D[] sprites = new Texture2D[16];

        public Explosion(Vector2 position)
        {
            this.position = position;
            fps = 24;
            currentIndex = 0;
        }

        public override void LoadContent(ContentManager content)
        {
            for (int i = 0; i < sprites.Length; i++)
            {
                if (i < 9)
                {
                    sprites[i] = content.Load<Texture2D>($"Sprites\\Effects\\explosion\\Explosion000{i + 1}");
                }
                else
                {
                    sprites[i] = content.Load<Texture2D>($"Sprites\\Effects\\explosion\\Explosion00{i + 1}");
                }
            }

            sprite = sprites[0];
        }

        public override void OnCollision(GameObject other)
        {
            
        }

        public override void Update(GameTime gameTime)
        {
            Animate(gameTime);
        }

        protected override void Animate(GameTime gameTime)
        {
            if (!(currentIndex >= sprites.Length - 1))
            {
                timeElapsed += (float)gameTime.ElapsedGameTime.TotalSeconds;

                currentIndex = (int)(timeElapsed * fps);

                sprite = sprites[currentIndex];

            }
            else
            {
                GameWorld.RemoveGameObject(this);
            }

        }
    }
}
