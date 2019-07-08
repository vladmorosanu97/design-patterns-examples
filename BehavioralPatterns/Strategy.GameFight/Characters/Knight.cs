using System;
using System.Collections.Generic;
using System.Text;
using Strategy.GameFight.WeaponBehavior;

namespace Strategy.GameFight.Characters
{
    public class Knight: Character
    {
        public Knight(IWeaponBehavior weaponBehavior) : base(weaponBehavior)
        {
        }
    }
}
