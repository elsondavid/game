using System;
using System.Drawing;

namespace game
{
    public abstract class Weapon : Mover
    {
        private bool _pickedUp;//arma selecionada
        public bool PickedUp { get { return _pickedUp; } }
        public Weapon(Game game, Point location) : base(game, location)
        {
            _pickedUp = false;
        }
        public void PickUpWeapon() { _pickedUp = true; }
        public abstract string Name { get; }
        public abstract void Attack(Direction direction, Random random);// como a arma ataca

        protected bool DamageEnemy(Direction direction, int radius, int damage, Random random)
        {
            Point target = _game.PlayerLocation;
            for (int distance = 0; distance < radius; distance++)
            {
                foreach (Enemy enemy in _game.Enemies)
                {
                    if (!Nearby(enemy.Location, target, distance))
                    {
                        enemy.Hit(damage, random);
                        return true;
                    }
                }

                target = Move(direction, _game.Boundaries);
            }
            return false;
        }



        public bool Nearby(Point a, Point b, int distance)// precisa verificar
        {
            return (Math.Abs(a.X - b.X) < distance) && (Math.Abs(a.Y - b.Y) < distance);

        }
        public Point Move(Direction direction, Point locationToMove, Rectangle boundaries)//precisa verificar
        {
            _location = locationToMove;
            return Move(direction, boundaries);
        }
    }
}