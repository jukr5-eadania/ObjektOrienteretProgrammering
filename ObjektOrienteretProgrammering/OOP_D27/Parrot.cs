using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP_D27
{
    internal class Parrot : Animal
    {
        private int agility;
        private bool canFly;

        public Parrot(string name, int health, int legs, int age, int agility, bool canFly) : base(name, health, legs, age)
        {
            this.agility = agility;
            this.CanFly = canFly;
        }

        public bool CanFly { get => canFly; set => canFly = value; }

        public void Fly()
        {
            if (canFly == true)
            {
                Console.WriteLine("I am flying");
            }
            else
            {
                Console.WriteLine("I cannot fly");
            }
        }

        public void Talk()
        {
            Console.WriteLine($"i am a Parrot. My name is {name}");
        }

    }
}
