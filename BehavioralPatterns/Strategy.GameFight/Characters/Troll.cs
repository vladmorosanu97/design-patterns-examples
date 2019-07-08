using System;
using System.Collections.Generic;
using System.Text;
using Strategy.GameFight.WeaponBehavior;

namespace Strategy.GameFight.Characters
{
    public class Troll: Character
    {
        public Troll(IWeaponBehavior weaponBehavior) : base(weaponBehavior)
        {
        }
    }
}
