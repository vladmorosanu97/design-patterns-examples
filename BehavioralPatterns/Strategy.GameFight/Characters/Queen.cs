using System;
using System.Collections.Generic;
using System.Text;
using Strategy.GameFight.WeaponBehavior;

namespace Strategy.GameFight.Characters
{
    public class Queen: Character
    {
        public Queen(IWeaponBehavior weaponBehavior) : base(weaponBehavior)
        {
        }
    }
}
