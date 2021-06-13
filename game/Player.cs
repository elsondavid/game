using System;
using System.Collections.Generic;
using System.Drawing;

namespace game

{
   public class Player : Mover
    {
        private Weapon _equippedWeapon;
        private int _hitPoints = 100;
        public int HitPoints { get { return _hitPoints; } }
       
        private List<Weapon> _inventory = new List<Weapon>();
        public List<string> Weapons// um player pode manter muitas armas no inventario mas só pode usar uma de cada vez
        {
            get
            {
                List<string> names = new List<string>();
                foreach (Weapon weapon in _inventory)
                    names.Add(weapon.Name);
                return names;
            }
        }

        public Player(Game game, Point location, Rectangle boundaries) 
            : base(game, location)
        {
            _hitPoints = 10;
        }

        internal void Hit(int maxDamage, Random random)// quando um inimigo ataca um jogador ele causa um dano aleatorio
        {
            _hitPoints -= random.Next(1, maxDamage);
        }

        internal void IncreaseHealth(int health, Random random)// porção aumenta a força do jogador, quantidade aumentada aleatoriamente 
        {
            _hitPoints += random.Next(1, health);
        }
        internal void Equip(string weaponName)//diz ao jogador para usar uma de suas armas. o objeto game chama esse método quando um dos icones do inventario é clicado
        {
            foreach (Weapon weapon in _inventory)
                if (weapon.Name == weaponName)
                    _equippedWeapon = weapon;
        }
        internal void Move(Direction direction)// falta terminar
        {
          base._location = Move(direction, _game.Boundaries);
            if (!_game.WeaponInRoom.PickedUp)
            {
                if (Nearby(_game.WeaponInRoom.Location, 25))
                {
                    _inventory.Add(_game.WeaponInRoom);
                    _game.WeaponInRoom.PickUpWeapon();
                }
            }
        }

        public void Attack(Direction direction, Random random)// falta terminar
        {
            if (_equippedWeapon != null)
            {
                _equippedWeapon.Attack(direction, random);
            }
        }
    }
}