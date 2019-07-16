using System;

namespace Strategy.GameFight.WeaponBehavior
{
    public class SwordBehavior: IWeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("Using a sword");
        }
    }
}
