using System;

namespace Strategy.GameFight.WeaponBehavior
{
    public class BowAndArrowBehavior: IWeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("Using a bow and an arrow");
        }
    }
}
