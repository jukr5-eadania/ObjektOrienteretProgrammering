using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_D4
{
    internal class Duck : Animal, IFlyable
    {
        private float flySpeed;

        public float FlySpeed { get => flySpeed; set => flySpeed = value; }

        public void Fly()
        {
            Console.WriteLine("I am a duck I am flying");
        }
    }
}
