
namespace StrategyPattern
{
    class Player
    {
        WeaponBehaviour weapon;

        public Player()
        {

        }

        public void setWeapon(WeaponBehaviour wb)
        {
            this.weapon = wb;
        }

        public void weaponAttack()
        {
            weapon.attack();
        }
    }

}
