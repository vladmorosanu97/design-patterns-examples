using System;
using System.Collections.Generic;
using System.Text;
using Strategy.GameFight.WeaponBehavior;

namespace Strategy.GameFight.Characters
{
    public abstract class Character
    {
        private IWeaponBehavior _weaponBehavior;

        protected Character(IWeaponBehavior weaponBehavior)
        {
            _weaponBehavior = weaponBehavior;
        }

        public void Fight()
        {
            _weaponBehavior.UseWeapon();
        }

        public void SetWeapon(IWeaponBehavior weaponBehavior)
        {
            _weaponBehavior = weaponBehavior;
        }
    }
}