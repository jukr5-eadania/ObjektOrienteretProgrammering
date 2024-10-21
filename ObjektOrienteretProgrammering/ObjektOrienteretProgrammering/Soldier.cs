using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ObjektOrienteretProgrammering
{
    internal class Soldier
    {
        private int health;
        private int armor;
        private int energy;
        private float speed;
        private string name;
        private Weapon myWeapon;
        private int x = 0;
        private int y = 0;

        public int Health
        {
            get { return health; }
            set
            {
                if (value >= 0)
                {
                    health = value;
                }
            }
        }

        public int Armor
        {
            get { return armor; }
            set
            {
                if (value <= 100)
                {
                    armor = value;
                }
            }
        }

        public int Energy
        {
            get { return energy; }
        }

        public float Speed
        {
            get { return speed; }
            set
            {
                if (value >= 0)
                {
                    speed = value;
                }
            }
        }

        public string Name
        {
            get { return name; }
        }

        public bool IsAlive
        {
            get
            {
                return health <= 0;
            }
        }

        public Soldier()
        {
            myWeapon = new Weapon();
            Console.WriteLine("Soldier created");
        }

        public Soldier(string name)
        {
            this.name = name;
            myWeapon = new Weapon();
            Console.WriteLine("Soldier created");
        }

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
