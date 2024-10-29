using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace OOP_D7
{
    internal abstract class GameObject
    {
        protected Texture2D playerSprite;
        protected Texture2D enemySprite;
        protected Texture2D[] playerSprites = new Texture2D[4];
        protected Vector2 position = new Vector2 (GameWorld.Width/2, GameWorld.Height);
        protected Vector2 enemyPosition;
        protected float fps = 10;
        private float timeElapsed;
        private int currentIndex;

        public abstract void LoadContent(ContentManager content);

        public abstract void Update(GameTime gameTime);

        public void Draw(SpriteBatch spritebatch)
        {
            spritebatch.Draw(playerSprite, position, null, Color.White, 0, new Vector2(playerSprite.Width / 2, playerSprite.Height / 2), 1, SpriteEffects.None, 1);
            for (int i = 0; i < 5; i++)
            {
                spritebatch.Draw(enemySprite, enemyPosition, Color.White);
            }
        }

        protected void Animate(GameTime gameTime)
        {
            timeElapsed += (float)gameTime.ElapsedGameTime.TotalSeconds;

            currentIndex = (int)(timeElapsed * fps);

            playerSprite = playerSprites[currentIndex];

            if (currentIndex >= playerSprites.Length - 1)
            {
                timeElapsed = 0;
                currentIndex = 0;
            }
        }
    }
}
