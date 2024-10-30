using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace OOP_D7
{
    internal class Player : GameObject
    {
        public Player()
        {
            speed = 1000;
        }

        public override void Update(GameTime gameTime)
        {
            HandleInput();
            Move(gameTime);
            ScreenBounds();
            Animate(gameTime);
        }

        public void HandleInput()
        {
            velocity = Vector2.Zero;

            KeyboardState keystate = Keyboard.GetState();

            if (keystate.IsKeyDown(Keys.W))
            {
                velocity += new Vector2(0, -1);
            }

            if (keystate.IsKeyDown(Keys.A))
            {
                velocity += new Vector2(-1, 0);
            }

            if (keystate.IsKeyDown(Keys.S))
            {
                velocity += new Vector2(0, 1);
            }

            if (keystate.IsKeyDown(Keys.D))
            {
                velocity += new Vector2(1, 0);
            }

            if (velocity != Vector2.Zero)
            {
                velocity.Normalize();
            }
        }

        public void ScreenBounds()
        {
            if (position.Y < 0)
            {
                position.Y = 0;
            }
            if (position.Y > GameWorld.Height - sprite.Height)
            {
                position.Y = GameWorld.Height - sprite.Height;
            }
            if (position.X > GameWorld.Width)
            {
                position.X = -sprite.Width;
            }
            if (position.X < -sprite.Width)
            {
                position.X = GameWorld.Width;
            }
        }

        public override void LoadContent(ContentManager content)
        {
            for (int i = 0; i < sprites.Length; i++)
            {
                sprites[i] = content.Load<Texture2D>($"Sprites\\PlayerAnimation\\PlayerNormal\\Forward\\{i + 1}fwd");
            }

            sprite = sprites[0];

            position = new Vector2(GameWorld.Width / 2, GameWorld.Height);
        }

        public override void OnCollision(GameObject other)
        {
            
        }
    }
}
