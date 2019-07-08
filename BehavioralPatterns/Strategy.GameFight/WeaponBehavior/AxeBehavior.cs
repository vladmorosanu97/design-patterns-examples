using System;
using System.Collections.Generic;
using System.Text;

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