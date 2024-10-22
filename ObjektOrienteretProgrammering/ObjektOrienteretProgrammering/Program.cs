using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjektOrienteretProgrammering
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Soldier mysoldier = new Soldier();
            Soldier mySoldier = new Soldier("Jhonny");

            Console.WriteLine("Health: " + mySoldier.Health);
            mySoldier.Health += 50;
            Console.WriteLine("Health: " + mySoldier.Health);
            mySoldier.Health -= 100;
            Console.WriteLine("Health: " + mySoldier.Health);

            Console.WriteLine("Armor: " + mySoldier.Armor);
            mySoldier.Armor += 100;
            Console.WriteLine("Armor: " + mySoldier.Armor);
            mySoldier.Armor += 100;
            Console.WriteLine("Armor: " + mySoldier.Armor);

            Console.WriteLine("Energy: " + mySoldier.Energy);

            Console.WriteLine("Speed: " + mySoldier.Speed);
            mySoldier.Speed += 50;
            Console.WriteLine("Speed: " + mySoldier.Speed);
            mySoldier.Speed -= 100;
            Console.WriteLine("Speed: " + mySoldier.Speed);

            Console.WriteLine(mySoldier.Name);

            mySoldier.Jump();
            mySoldier.Shoot();
            mySoldier.Move();

            mySoldier.Health -= 50;
            if (mySoldier.IsAlive == true)
            {
                Console.WriteLine("I'm Dead");
            }

            Console.ReadLine();
        }
    }
}
