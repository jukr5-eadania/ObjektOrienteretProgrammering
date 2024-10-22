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
            Score score1 = new Score("Jhonny", 300);
            Score score2 = new Score("Mhonny", 400);
            Score score3 = new Score("Thonny", 600);
            Score score4 = new Score("Fhonny", 100);
            Score score5 = new Score("Whonny", 200);
            Score score6 = new Score("Shonny", 800);
            Score score7 = new Score("Phonny", 900);
            Score score8 = new Score("Lhonny", 3200);
            Score score9 = new Score("Khonny", 2100);
            Score score10 = new Score("Xhonny", 1200);
            Score score11 = new Score("Bhonny", 3900);

            HighscoreList.AddScore(score1);
            HighscoreList.AddScore(score2);
            HighscoreList.AddScore(score3);
            HighscoreList.AddScore(score4);
            HighscoreList.AddScore(score5);
            HighscoreList.AddScore(score6);
            HighscoreList.AddScore(score7);
            HighscoreList.AddScore(score8);
            HighscoreList.AddScore(score9);
            HighscoreList.AddScore(score10);
            HighscoreList.AddScore(score11);


            HighscoreList.PrintToScreen();

            Console.WriteLine();


            Tiger tiger1 = new Tiger("Bobby", 100, 4, 15, 20);     
            tiger1.Eat();
            tiger1.Sleep();

            Parrot parrot1 = new Parrot("Polly", 20, 2, 5, 30, true);
            parrot1.Fly();
            parrot1.Talk();
            parrot1.Sleep();

            Console.ReadLine();
        }
    }
}
