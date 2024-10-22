using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_D2
{
    internal class HighscoreList
    {
        private static Score[] scores = new Score[1];

        internal static Score[] Scores { get => scores; set => scores = value; }

        public static void AddScore(Score score)
        {
            Scores[0] = score;
        }

        public static void PrintToScreen()
        {
            for (int i = 0; i < scores.Length; i++)
            {
                Console.Write(scores[i].Name);
                Console.Write(" ");
                Console.Write(scores[i].Points);
            }
        }
    }
}
