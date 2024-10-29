using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using SharpDX.Direct3D9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_D7
{
    internal class Player : GameObject
    {
        private float speed = 1000;
        private Vector2 velocity;

        public override void Update(GameTime gametime)
        {
            HandleInput();
            Move(gametime);
            ScreenBounds();
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

        public void Move(GameTime gametime)
        {
            float deltaTime = (float)gametime.ElapsedGameTime.TotalSeconds;
            position += ((velocity * speed) * deltaTime);
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
    }
}
