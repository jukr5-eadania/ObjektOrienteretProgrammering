using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_D2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HighscoreList highscorelist = new HighscoreList();

            Score score1 = new Score("Jhonny", 300);

            HighscoreList.AddScore(score1);

            HighscoreList.PrintToScreen();

            Console.ReadLine();
        }
    }
}
