using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using System.Collections.Generic;

namespace MonoGame
{
    public class GameWorld : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private List<GameObject> gameObjects = new List<GameObject>();
        private static List<GameObject> gameObjectsToAdd = new List<GameObject>();
        private static List<GameObject> gameObjectsToRemove = new List<GameObject>();
        private Texture2D collisionTexture;
        private Song backgroundMusic;
        private float spawnTimer;
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
            gameObjects.Add(new Background(0));
            gameObjects.Add(new Background(1));
            gameObjects.Add(new Player());
            base.Initialize();
        }

        protected override void LoadContent()
        {
            backgroundMusic = Content.Load<Song>("Sounds\\Music\\Having Fallen It Was Blood");
            MediaPlayer.Play(backgroundMusic);
            MediaPlayer.IsRepeating = true;

            _spriteBatch = new SpriteBatch(GraphicsDevice);

            foreach (GameObject gameObject in gameObjects)
            {
                gameObject.LoadContent(Content);
            }

            collisionTexture = Content.Load<Texture2D>("Sprites\\CollisionTexture");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            foreach (GameObject gameObject in gameObjects)
            {
                gameObject.Update(gameTime);
                foreach (GameObject other in gameObjects)
                {
                    gameObject.CheckCollision(other);
                }
            }

            foreach (GameObject gameObjectToSpawn in gameObjectsToAdd)
            {
                gameObjectToSpawn.LoadContent(Content);
                gameObjects.Add(gameObjectToSpawn);
            }
            gameObjectsToAdd.Clear();

            foreach (GameObject gameObjectToDespawn in gameObjectsToRemove)
            {
                gameObjects.Remove(gameObjectToDespawn);
            }
            gameObjectsToRemove.Clear();

            spawnTimer += (float)gameTime.ElapsedGameTime.TotalSeconds;

            SpawnEnemy();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin();

            foreach (GameObject gameObject in gameObjects)
            {
                gameObject.Draw(_spriteBatch);

#if DEBUG
                if (!(gameObject is Background) && !(gameObject is Explosion))
                {
                    DrawCollisionBox(gameObject);
                }
#endif
            }

            _spriteBatch.End();

            base.Draw(gameTime);
        }

        private void DrawCollisionBox(GameObject gameObject)
        {
            Rectangle collisionBox = gameObject.CollisionBox;
            Rectangle topLine = new Rectangle(collisionBox.X, collisionBox.Y, collisionBox.Width, 1);
            Rectangle bottomLine = new Rectangle(collisionBox.X, collisionBox.Y + collisionBox.Height, collisionBox.Width, 1);
            Rectangle rightLine = new Rectangle(collisionBox.X + collisionBox.Width, collisionBox.Y, 1, collisionBox.Height);
            Rectangle leftLine = new Rectangle(collisionBox.X, collisionBox.Y, 1, collisionBox.Height);

            _spriteBatch.Draw(collisionTexture, topLine, null, Color.Red, 0, Vector2.Zero, SpriteEffects.None, 1);
            _spriteBatch.Draw(collisionTexture, bottomLine, null, Color.Red, 0, Vector2.Zero, SpriteEffects.None, 1);
            _spriteBatch.Draw(collisionTexture, rightLine, null, Color.Red, 0, Vector2.Zero, SpriteEffects.None, 1);
            _spriteBatch.Draw(collisionTexture, leftLine, null, Color.Red, 0, Vector2.Zero, SpriteEffects.None, 1);
        }

        public static void InstatiateGameObject(GameObject gameObject)
        {
            gameObjectsToAdd.Add(gameObject);
        }

        public static void RemoveGameObject(GameObject gameObject)
        {
            gameObjectsToRemove.Add(gameObject);
        }

        public void SpawnEnemy()
        {
            if (spawnTimer >= 3)
            {
                Enemy enemy = new Enemy();
                InstatiateGameObject(enemy);
                spawnTimer = 0;
            }
        }
    }
}
