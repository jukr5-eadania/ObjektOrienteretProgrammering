using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjektOrienteretProgrammering
{
    internal class Weapon
    {
        private int ammo;
        private string name;

        public Weapon(int ammo, string name)
        {
            this.ammo = ammo;
            this.name = name;
        }

        public Weapon()
        {
            this.ammo = 30;
            this.name = "AK47";
        }
    }
}
