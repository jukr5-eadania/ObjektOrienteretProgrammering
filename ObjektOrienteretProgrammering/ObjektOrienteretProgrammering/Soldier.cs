using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjektOrienteretProgrammering
{
    internal class Soldier
    {
        public int health = 100;
        private int armor;
        private int energy;
        private float speed;
        private string name;
        private Weapon weapon;
        private int x = 0;
        private int y = 0;

        public void Jump()
        {
            Console.WriteLine("I'm jumping");
            y += 10;
            Console.WriteLine("y = " + y);
        }

        public void Shoot()
        {
            Console.WriteLine("I'm shooting");
        }

        public void Move()
        {
            Console.WriteLine("I'm moving");
            x += 1;
            Console.WriteLine("x = " + x);
        }
    }
}
