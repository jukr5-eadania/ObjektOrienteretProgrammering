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
            //List<string> enemies = new List<string>(10);
            //enemies.Add("Skeleton");
            //enemies.Add("Zombie");
            //enemies.Add("Elemental");
            //enemies.Add("Spider");
            //enemies.Add("Cultist");
            //enemies.Add("Dragon");
            //enemies.Add("Serpent");
            //enemies.Add("Sorcerer");
            //enemies.Add("Jimbo");
            //enemies.Add("Imp");

            //foreach (var item in enemies)
            //{
            //    Console.WriteLine(item);
            //}


            //enemies.RemoveAt(7);
            //enemies.Remove("Spider");
            //enemies.RemoveRange(2,1);

            //for (int i = 0; i < enemies.Count; i++)
            //{
            //    Console.WriteLine(enemies[i]);
            //}

            HashSet<string> words = new HashSet<string>(10);
            words.Add("crowd");
            words.Add("cupboard");
            words.Add("possession");
            words.Add("goalkeeper");
            words.Add("extreme");
            words.Add("stake");
            words.Add("slide");
            words.Add("total");
            words.Add("surround");

            Console.WriteLine("There are 9 words in a list of 10 words. Please add the last word");
            words.Add(Console.ReadLine());

            Console.WriteLine("Word added");

            Console.WriteLine("Here are the 10 words");
            foreach (var item in words)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Please guess a word from the list");
            string word = Console.ReadLine();

            if (words.Contains(word))
            {
                Console.WriteLine($"You guessed correct {word} is now removed");
                words.Remove(word);
            }

            foreach (var item in words)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
