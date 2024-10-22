using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_D2
{
    internal static class HighscoreList
    {
        private static int x = 0;
        private static Score[] scores = new Score[10];

        internal static Score[] Scores { get => scores; set => scores = value; }

        public static void AddScore(Score score)
        {
            if (x < scores.Length)
            {
                Scores[x] = score;
                x++;
            }
            else
            {
                Array.Resize(ref scores, scores.Length * 2);
            }
        }

        public static void PrintToScreen()
        {
            for (int i = 0; i < scores.Length; i++)
            {
                Console.Write(i + 1 + ". ");
                Console.Write(scores[i].Name);
                Console.Write(" ");
                Console.Write(scores[i].Points);
                Console.WriteLine();
            }
        }
    }
}
