using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_D27
{
    internal class Tiger : Animal
    {
        private int strength;

        public Tiger(string name, int health, int legs, int age, int strength) : base(name, health, legs, age)
        {
            this.strength = strength;
        }

        public override void Eat()
        {
            Console.WriteLine("I am a tiger and i am eating");
        }
    }
}
