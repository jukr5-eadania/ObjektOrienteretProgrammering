using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace OOP_D6_Fixed
{
    public class GameWorld : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private Rectangle rectangle;
        private int speed = 3;
        Random rnd = new Random();
        Texture2D[] sprite = new Texture2D[5];
        int rndImg;
        private SpriteFont animalFont;
        private int animal;
        private int racoon;
        private int bat;
        private int chameleon;
        private int fox;
        private int snake;

        public GameWorld()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            sprite[0] = Content.Load<Texture2D>("tile_racoon");
            sprite[1] = Content.Load<Texture2D>("tile_bat");
            sprite[2] = Content.Load<Texture2D>("tile_chameleon");
            sprite[3] = Content.Load<Texture2D>("tile_fox");
            sprite[4] = Content.Load<Texture2D>("tile_snake");

            rectangle = new Rectangle(0, -200, sprite[0].Width * 5, sprite[0].Height * 5);

            animalFont = Content.Load<SpriteFont>("File");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            rectangle.Y += speed;
            rectangle.Height++;
            rectangle.Width++;

            if (rectangle.Y > _graphics.PreferredBackBufferHeight)
            {
                int rndX = rnd.Next(1, _graphics.PreferredBackBufferWidth);
                rectangle.Y = -200;
                rectangle.X = rndX;
                rectangle.Height = sprite[0].Height * 5;
                rectangle.Width = sprite[0].Width * 5;
                animal++;
                switch (rndImg)
                {
                    case 0:
                        racoon++;
                        break;

                    case 1:
                        bat++;
                        break;

                    case 2:
                        chameleon++;
                        break;

                    case 3:
                        fox++;
                        break;

                    case 4:
                        snake++;
                        break;
                }
                rndImg = rnd.Next(0, 5);
            }

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin(samplerState: SamplerState.PointClamp);

            _spriteBatch.Draw(sprite[rndImg], rectangle, Color.White);
            _spriteBatch.DrawString(animalFont, "Animals: " + animal, Vector2.Zero, Color.Black);
            _spriteBatch.DrawString(animalFont, "Racoons: " + racoon, new Vector2(0, 15), Color.Black);
            _spriteBatch.DrawString(animalFont, "Bats: " + bat, new Vector2(0, 30), Color.Black);
            _spriteBatch.DrawString(animalFont, "Chameleons: " + chameleon, new Vector2(0, 45), Color.Black);
            _spriteBatch.DrawString(animalFont, "Foxes: " + fox, new Vector2(0, 60), Color.Black);
            _spriteBatch.DrawString(animalFont, "Snakes: " + snake, new Vector2(0, 75), Color.Black);

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
