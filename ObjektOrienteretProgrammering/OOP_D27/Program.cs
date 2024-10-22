using OOP_D27;
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

            Console.WriteLine();

            Animal animal1 = new Animal("Biboo", 50, 2, 20);

            animal1.Eat();

            Tiger tiger1 = new Tiger("Bobby", 100, 4, 15, 20);
                        
            tiger1.Eat();

            Parrot parrot1 = new Parrot("Polly", 20, 2, 5, 30, true);

            parrot1.Fly();
            parrot1.Talk();

            Console.ReadLine();
        }
    }
}
