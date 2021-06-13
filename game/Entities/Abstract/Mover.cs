using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
  public abstract class Mover
    {

        private const int MoveInterval = 10;
        protected Point _location;
        public Point Location { get { return _location; } }
        protected Game _game;

        public Mover(Game game, Point location)// recebe o objeto game e uma posição atual
        {
            this._game = game;
            this._location = location;
        }

        public bool Nearby(Point locationToCheck, int distance)//checa a distancia de Point em relação a posição atual do objeto
        {
            
            if(Math.Abs(_location.X- locationToCheck.X)< distance &&(Math.Abs(_location.Y - locationToCheck.Y)<distance))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Point Move(Direction direction, Rectangle boundaries)// tenta move-se um passo em uma direção 
        {
            Point newLocation = Location;
            switch (direction)
            {
                case Direction.UP:
                    if (newLocation.Y - MoveInterval >= boundaries.Top)
                    {
                        newLocation.Y -= MoveInterval;
                    }
                    break;
                case Direction.DOWN:
                    if (newLocation.Y + MoveInterval <= boundaries.Bottom)
                    {
                        newLocation.Y += MoveInterval;
                    }
                    break;
                case Direction.LEFT:
                    if (newLocation.X - MoveInterval >= boundaries.Left)
                    {
                        newLocation.X -= MoveInterval;
                    }
                    break;
                case Direction.RIGHT:
                    if (newLocation.X + MoveInterval <= boundaries.Right)
                    {
                        newLocation.X += MoveInterval;
                    }
                    break;
                default: break;
            }
            return newLocation;
        }
    }
}
