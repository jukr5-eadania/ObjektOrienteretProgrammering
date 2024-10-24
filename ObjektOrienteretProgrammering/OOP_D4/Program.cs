using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_D4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[10] { new Cow(), new Bat(), new Pinguin(), new Duck(), new Cow(), new Bat(), new Pinguin(), new Duck(), new Pinguin(), new Bat() };

            foreach (Animal animal in animals)
            {
                if (animal is IFlyable)
                {
                    (animal as IFlyable).Fly();

                }
            }

            Console.ReadLine();
        }
    }
}
