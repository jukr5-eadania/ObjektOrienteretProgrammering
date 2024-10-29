using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace OOP_D7
{
    internal class Enemy : GameObject
    {
        private string[] enemySprites = new string[20] {"enemyBlack1", "enemyBlack2", "enemyBlack3", "enemyBlack4", "enemyBlack5", "enemyBlue1", "enemyBlue2", "enemyBlue3", "enemyBlue4", "enemyBlue5", "enemyGreen1", "enemyGreen2", "enemyGreen3", "enemyGreen4", "enemyGreen5", "enemyRed1", "enemyRed2", "enemyRed3", "enemyRed4", "enemyRed5", };
        private Random rnd = new Random();
        private float enemySpeed;
        private int spriteIndex;

        public Enemy()
        {
            spriteIndex = rnd.Next(0, enemySprites.Length);
            enemyPosition = new Vector2(rnd.Next(0, GameWorld.Width), 0) ;
            enemySpeed = rnd.Next(50, 201);
        }

        public override void LoadContent(ContentManager content)
        {
            enemySprite = content.Load<Texture2D>($"Sprites\\Enemies\\{enemySprites[4]}");          
        }

        public override void Update(GameTime gameTime)
        {
            throw new NotImplementedException();
        }
    }
}
