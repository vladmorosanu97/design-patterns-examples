using System;

namespace Strategy.GameFight.WeaponBehavior
{
    public class AxeBehavior : IWeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("Using an axe");
        }
    }
}