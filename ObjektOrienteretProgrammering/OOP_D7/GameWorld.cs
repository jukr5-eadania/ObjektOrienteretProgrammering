using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace OOP_D7
{
    public class GameWorld : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private List<GameObject> gameObjects = new List<GameObject>();
        private Texture2D collisionTexture;
        public static int Height { get; set; }
        public static int Width { get; set; }

        public GameWorld()
        {
            _graphics = new GraphicsDeviceManager(this);
            _graphics.PreferredBackBufferHeight = 1200;
            _graphics.PreferredBackBufferWidth = 1920;
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            GameWorld.Height = _graphics.PreferredBackBufferHeight;
            GameWorld.Width = _graphics.PreferredBackBufferWidth;
            gameObjects.Add(new Player());
            gameObjects.Add(new Enemy());
            gameObjects.Add(new Background());
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            foreach (GameObject gameObject in gameObjects)
            {
                gameObject.LoadContent(Content);
            }

            collisionTexture = Content.Load<Texture2D>("CollisionTexture");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            foreach (GameObject gameObject in gameObjects)
            {
                gameObject.Update(gameTime);
            }

            foreach (GameObject go in gameObjects)
            {
                go.Update(gameTime);
                foreach (GameObject other in gameObjects)
                {
                    go.CheckCollision(other);
                }
            }

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin();

            foreach (GameObject gameObject in gameObjects)
            {
                gameObject.Draw(_spriteBatch);
            }

            foreach (GameObject go in gameObjects)
            {
                go.Draw(_spriteBatch);
                #if DEBUG
                DrawCollisionBox(go);
                #endif

            }

            _spriteBatch.End();

            base.Draw(gameTime);
        }

        private void DrawCollisionBox(GameObject go)
        {
            Rectangle collisionBox = go.CollisionBox;
            Rectangle topLine = new Rectangle(collisionBox.X, collisionBox.Y, collisionBox.Width, 1);
            Rectangle bottomLine = new Rectangle(collisionBox.X, collisionBox.Y + collisionBox.Height, collisionBox.Width, 1);
            Rectangle rightLine = new Rectangle(collisionBox.X + collisionBox.Width, collisionBox.Y, 1, collisionBox.Height);
            Rectangle leftLine = new Rectangle(collisionBox.X, collisionBox.Y, 1, collisionBox.Height);

            _spriteBatch.Draw(collisionTexture, topLine, null, Color.Red, 0, Vector2.Zero, SpriteEffects.None, 1);
            _spriteBatch.Draw(collisionTexture, bottomLine, null, Color.Red, 0, Vector2.Zero, SpriteEffects.None, 1);
            _spriteBatch.Draw(collisionTexture, rightLine, null, Color.Red, 0, Vector2.Zero, SpriteEffects.None, 1);
            _spriteBatch.Draw(collisionTexture, leftLine, null, Color.Red, 0, Vector2.Zero, SpriteEffects.None, 1);
        }
    }
}
