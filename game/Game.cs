using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
  public  class Game
    {
        public List<Enemy> Enemies;  // inimigos  
        public Weapon WeaponInRoom { get; set; } // arma na sala

        private Player player;// o formulario interagirar com obj player atraves do metodo game
        public Point PlayerLocation { get { return player.Location; } }
        public int PlayerHitPoints { get { return player.HitPoints; } }
        public List<string> PlayerWeapons { get { return player.Weapons; } }

        private int level = 0;
        public int Level { get { return level; } }

        private Rectangle boundaries;// caixa delimitadora. area geral do jogo. 
        public Rectangle Boundaries { get { return boundaries; } }

        public Game(Rectangle boundaries)
        {
            this.boundaries = boundaries; 
            player = new Player(this, new Point(boundaries.Left + 10, boundaries.Top + 70), boundaries);
            // cria o objeto jogador 
        }
        public void Move(Direction direction, Random random)
        {
            player.Move(direction);// move o jgador na direção informada pelo formulario
            foreach (Enemy enemy in Enemies)// move o inimigo em uma direçao aleatoria  
            {
                enemy.Move(random);
            }
        }

        public void Equip(string weaponName)
        {
            player.Equip(weaponName);
        }

        public bool CheckPlayerInventory(string weaponName)
        {
            return player.Weapons.Contains(weaponName);
        }

        public void HitPlayer(int maxDamage, Random randon)
        {
            player.Hit(maxDamage, randon);
        }

        public void IncreasePlayerHealth(int health, Random random)
        {
            player.IncreaseHealth(health, random);
        }

        public void Attack(Direction direction, Random random)
        {
            player.Attack(direction, random);//o jogador ataca e os inimigos tem sua vez de jogar
            foreach (Enemy enemy in Enemies)
            {
                enemy.Move(random);
            }
        }

        private Point GetRandomLocation(Random random)//onde coloca os inimigos e as armas. que vai usar é o NewLevel() 
        {
            return new Point(boundaries.Left + random.Next(boundaries.Right / 10 - boundaries.Left / 10) * 10, boundaries.Top + random.Next(boundaries.Bottom / 10
                - boundaries.Top / 10) * 10);
        }

        public void NewLevel(Random random)//
        {
            level++;
            switch (level)               
            {
                case 1:
                    Enemies = new List<Enemy>();
                    Enemies.Add(new Bat(this, GetRandomLocation(random)));
                    WeaponInRoom = new Sword(this, GetRandomLocation(random));
                 //   WeaponInRoom = new BluePotion(this, GetRandomLocation(random));
                    break;

                case 2:
                    Enemies.Clear();
                    Enemies.Add(new Ghost(this, GetRandomLocation(random)));
                    WeaponInRoom = new BluePotion(this, GetRandomLocation(random));
                    break;

                case 3:
                    Enemies.Clear();
                    Enemies.Add(new Ghoul(this, GetRandomLocation(random)));
                    WeaponInRoom = new Bow(this, GetRandomLocation(random));
                    break;

                case 4:
                    Enemies.Clear();
                    Enemies.Add(new Bat(this, GetRandomLocation(random)));
                    Enemies.Add(new Ghost(this, GetRandomLocation(random)));
                    WeaponInRoom = null;
                    if (CheckPlayerInventory("Bow"))
                    {
                        WeaponInRoom = new BluePotion(this, GetRandomLocation(random));
                    }
                    else
                    {
                        WeaponInRoom = new Bow(this, GetRandomLocation(random));
                    }
                    break;

                case 5:
                    Enemies.Clear();
                    Enemies.Add(new Bat(this, GetRandomLocation(random)));
                    Enemies.Add(new Ghoul(this, GetRandomLocation(random)));
                    WeaponInRoom = new RedPotion(this, GetRandomLocation(random));
                    break;

                case 6:
                    Enemies.Clear();
                    Enemies.Add(new Ghost(this, GetRandomLocation(random)));
                    Enemies.Add(new Ghoul(this, GetRandomLocation(random)));
                    WeaponInRoom = new Mace(this, GetRandomLocation(random));
                    break;

                case 7:
                    Enemies.Clear();
                    Enemies.Add(new Bat(this, GetRandomLocation(random)));
                    Enemies.Add(new Ghost(this, GetRandomLocation(random)));
                    Enemies.Add(new Ghoul(this, GetRandomLocation(random)));
                    WeaponInRoom = null;
                    if (CheckPlayerInventory("Mace"))
                    {
                        WeaponInRoom = new RedPotion(this, GetRandomLocation(random));
                    }
                    else
                    {
                        WeaponInRoom = new Mace(this, GetRandomLocation(random));
                    }
                    break;

                case 8:
                    //Application.Exit();
                    break;
            }
        }

        

    }
}
