using Strategy.GameFight.Characters;
using Strategy.GameFight.WeaponBehavior;

namespace Strategy.GameFight
{
    class Program
    {
        static void Main(string[] args)
        {
            IWeaponBehavior axeBehavior = new AxeBehavior();
            IWeaponBehavior bowBehavior = new BowAndArrowBehavior();
            IWeaponBehavior knifeBehavior = new KnifeBehavior();
            IWeaponBehavior swordBehavior = new SwordBehavior();

            Character kingCharacter = new King(swordBehavior);
            kingCharacter.Fight();
            kingCharacter.SetWeapon(knifeBehavior);
            kingCharacter.Fight();

            Character queenCharacter = new Queen(knifeBehavior);
            queenCharacter.Fight();

            Character knightCharacter = new Knight(swordBehavior);
            knightCharacter.Fight();

            Character trollCharacter = new Troll(axeBehavior);
            trollCharacter.Fight();
        }
    }
}