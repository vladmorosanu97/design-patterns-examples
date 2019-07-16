using System;

namespace Strategy.GameFight.WeaponBehavior
{
    public class KnifeBehavior: IWeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("Cutting with knife");
        }
    }
}
