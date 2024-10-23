using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace OOP_D3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> enemies = new List<string>(10);
            enemies.Add("Skeleton");
            enemies.Add("Zombie");
            enemies.Add("Elemental");
            enemies.Add("Spider");
            enemies.Add("Cultist");
            enemies.Add("Dragon");
            enemies.Add("Serpent");
            enemies.Add("Sorcerer");
            enemies.Add("Jimbo");
            enemies.Add("Imp");

            foreach (var item in enemies)
            {
                Console.WriteLine(item);
            }


            enemies.RemoveAt(7);
            enemies.Remove("Spider");
            enemies.RemoveRange(2,1);

            for (int i = 0; i < enemies.Count; i++)
            {
                Console.WriteLine(enemies[i]);
            }

            Console.ReadLine();
        }
    }
}
