using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_D4
{
    internal class Bat : Animal, IFlyable
    {
        private float flySpeed;

        public float FlySpeed { get => flySpeed; set => flySpeed = value; }

        public void Fly()
        {
            Console.WriteLine("I am a bat I am flying");
        }
    }
}
