using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Weapons
{
    class CriticalSword : WeaponBehaviour
    {
        public void attack()
        {
            Console.WriteLine("Sword critcally hits");
        }
    }
}
