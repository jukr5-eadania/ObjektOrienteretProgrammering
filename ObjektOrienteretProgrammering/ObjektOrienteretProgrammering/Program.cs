﻿using System;
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
            Soldier mySoldier = new Soldier();

            Console.WriteLine(mySoldier.health);

            mySoldier.Jump();
            mySoldier.Shoot();
            mySoldier.Move();

            Console.ReadLine();
        }
    }
}
