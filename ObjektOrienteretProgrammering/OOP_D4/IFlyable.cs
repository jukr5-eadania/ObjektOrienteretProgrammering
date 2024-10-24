using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_D4
{
    internal interface IFlyable
    {
        float FlySpeed
        {
            get;
            set;
        }

        void Fly();
    }
}
