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

        public void Jump()
        {
            Console.WriteLine("I'm jumping");
        }

        public void Shoot()
        {
            Console.WriteLine("I'm shooting");
        }

        public void Move()
        {
            Console.WriteLine("I'm moving");
        }
    }
}
