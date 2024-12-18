﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace MonoGame
{
    public abstract class GameObject
    {
        protected Texture2D sprite;
        protected Texture2D[] sprites = new Texture2D[4];
        protected Vector2 position;
        protected float fps = 10;
        protected float speed;
        protected Vector2 velocity;
        private float timeElapsed;
        private int currentIndex;
        public Rectangle CollisionBox
        {
            get
            {
                return new Rectangle(
                    (int)(position.X - sprite.Width / 2),
                    (int)(position.Y - sprite.Height / 2),
                    sprite.Width,
                    sprite.Height
                );
            }
        }

        public abstract void LoadContent(ContentManager content);

        public abstract void Update(GameTime gameTime);

        public virtual void Draw(SpriteBatch spritebatch)
        {
            spritebatch.Draw(sprite, position, null, Color.White, 0, new Vector2(sprite.Width / 2, sprite.Height / 2), 1, SpriteEffects.None, 1);
        }

        protected virtual void Animate(GameTime gameTime)
        {
            timeElapsed += (float)gameTime.ElapsedGameTime.TotalSeconds;

            currentIndex = (int)(timeElapsed * fps);

            sprite = sprites[currentIndex];

            if (currentIndex >= sprites.Length - 1)
            {
                timeElapsed = 0;
                currentIndex = 0;
            }
        }

        protected void Move(GameTime gameTime)
        {
            float deltaTime = (float)gameTime.ElapsedGameTime.TotalSeconds;
            position += ((velocity * speed) * deltaTime);
        }

        public abstract void OnCollision(GameObject other);

        public void CheckCollision(GameObject other)
        {
            if (CollisionBox.Intersects(other.CollisionBox))
            {
                OnCollision(other);
            }
        }       
    }
}

