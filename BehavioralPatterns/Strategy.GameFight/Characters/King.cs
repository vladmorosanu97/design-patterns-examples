using System;
using System.Collections.Generic;
using System.Text;
using Strategy.GameFight.WeaponBehavior;

namespace Strategy.GameFight.Characters
{
    public class King: Character
    {
        public King(IWeaponBehavior weaponBehavior) : base(weaponBehavior)
        {
        }
    }
}
