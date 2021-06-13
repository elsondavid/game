using System;
using System.Drawing;

namespace game
{
    internal class RedPotion : Weapon, IPotion
    {
        public RedPotion(Game game, Point location) : base(game, location)
        {
            Used = false;
        }

        public override string Name
        {
            get
            {
                return "Red Potion";
            }
        }

        public bool Used { get; private set; }

        public override void Attack(Direction direction, Random random)
        {
            _game.IncreasePlayerHealth(5, random);
            Used = true;
        }
    }
}