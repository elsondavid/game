using System;
using System.Drawing;

namespace game
{
    public abstract class Enemy : Mover
    {
        private const int NearPlayerDistance = 25;
        private int _hitPoints;
        public int HitPoints { get { return _hitPoints; } }
        public bool Dead //o formulario pode usar esta propriedade de apenas leitura para ver se o inimigo deve ser visivel na masmorra 
        {
            get
            {
                if (_hitPoints <= 0)
                    return true;
                else return false;
            }
        }
        public Enemy(Game game, Point location, int hitPoints) : base(game, location)
        {
            this._hitPoints = hitPoints;
        }
        public abstract void Move(Random random);
        public void Hit(int maxDamage, Random random)//quando o jogador ataca o inimigo, ele chama o método hit() do inimigo, que subtrai um número aleatório dos pontos de vida
        {
            _hitPoints -= random.Next(1, maxDamage);
        }
        protected bool NearPlayer()//pode ser usado para descobrir se o inimigo esta perto do jogador
        {
            return (Nearby(_game.PlayerLocation, NearPlayerDistance));
        }
        protected Direction FindPlayerDirection(Point playerLocation)// descobrir onde o jogador esta em relação ao inimigo. e infoma qual direção o inimigo precisa move-se para se aproximar do jogador
        {
            Direction directionToMove;
            if (playerLocation.X > _location.X + 10)
                directionToMove = Direction.RIGHT;
            else if (playerLocation.X < _location.X - 10)
                directionToMove = Direction.LEFT;
            else if (playerLocation.X < _location.Y - 10)
                directionToMove = Direction.UP;
            else
                directionToMove = Direction.DOWN;
            return directionToMove;
        }
    }
}