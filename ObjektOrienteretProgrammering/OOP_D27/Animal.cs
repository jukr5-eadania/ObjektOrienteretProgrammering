using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_D27
{
    abstract class Animal
    {
        protected string name;
        protected int health;
        protected int legs;
        protected int age;

        public Animal(string name, int health, int legs, int age)
        {
            this.name = name;
            this.health = health;
            this.legs = legs;
            this.age = age;
        }

        public virtual void Eat()
        {
            Console.WriteLine("I am an animal and i am eating");
        }

        public abstract void Sleep();
    }
}
