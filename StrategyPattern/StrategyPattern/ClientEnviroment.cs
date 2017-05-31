using System;
using StrategyPattern.Weapons;

namespace StrategyPattern
{
    public class ClientEnviroment
    {

        static int Main(string[] args)
        {
            Player knight = new Player();
            knight.setWeapon(new CriticalSword());
            knight.weaponAttack();

            Player cavalier = new Player();
            cavalier.setWeapon(new CriticalSword());
            cavalier.weaponAttack();

            Player swordsman = new Player();
            swordsman.setWeapon(new Sword());
            swordsman.weaponAttack();

            Console.ReadKey();
            return 0;
        
        } 

    }
}
