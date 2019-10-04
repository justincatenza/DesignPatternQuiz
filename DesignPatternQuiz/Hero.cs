using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternQuiz
{
    public class Hero
    {
        Monster Monster;
        public string Name = "Hero";
        public double Health = 100;
        Weapon Weapon;
        public Hero(Weapon weapon)
        {
            Weapon = weapon;
        }
        public void Fight(Monster monster)
        {
            Monster = monster;
            Monster.Health -= Weapon.Damage;
        }

    }
    public class Weapon
    {
        public string Name;
        public double Damage;
       public Weapon(string name, double damage)
        {
            Name = name;
            Damage = damage;
        }

    }
    public abstract class Monster
    {
        public string Name;
        public double Health;
        public double AttackDamage;
        
        public abstract void Fight(Hero hero);
    }

    public class smallMonster : Monster
    {
        Hero Hero;
        public smallMonster()
        {
            Name = "small Monster";
            Health = 100;
            AttackDamage = 20;
        }
        public override void Fight(Hero hero)
        {
            Hero = hero;
            Hero.Health -= AttackDamage;
            Console.ReadLine();
        }
    }

    public class bigMonster : Monster
    {
        Hero Hero;
        public bigMonster()
        {
            Name = "small Monster";
            Health = 100;
            AttackDamage = 40;
        }
        public override void Fight(Hero hero)
        {
            Hero = hero;
            Hero.Health -= AttackDamage;
            Console.ReadLine();
        }
    }
}
