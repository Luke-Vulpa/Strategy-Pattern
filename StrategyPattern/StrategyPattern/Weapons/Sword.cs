using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Weapons
{
    class Sword : WeaponBehaviour
    {
        public void attack()
        {
            Console.WriteLine("Slices and stabs");
        }
    }
}
