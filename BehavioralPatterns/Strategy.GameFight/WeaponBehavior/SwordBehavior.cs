using System;
using System.Collections.Generic;
using System.Text;

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
