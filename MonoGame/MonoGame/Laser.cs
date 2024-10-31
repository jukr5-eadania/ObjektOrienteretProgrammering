using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace MonoGame
{
    internal class Laser : GameObject
    {
        private SoundEffect explosion;

        public Laser(Texture2D sprite, Vector2 position)
        {
            this.sprite = sprite;
            this.position = position;
            velocity = new Vector2(0, -1);
            speed = 300;
        }

        public override void LoadContent(ContentManager content)
        {
            explosion = content.Load<SoundEffect>("Sounds\\Explosion");
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

        public override void OnCollision(GameObject other)
        {
            if ((other is Enemy))
            {
                GameWorld.RemoveGameObject(other);
                GameWorld.InstatiateGameObject(new Explosion(position));
                explosion.Play();
                GameWorld.RemoveGameObject(this);
            }
        }
    }
}
