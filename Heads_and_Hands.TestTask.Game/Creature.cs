using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heads_and_Hands.TestTask.Game
{
    public class Creature
    {
        public string Name { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Health { get; set; }
        public Tuple<int, int> DamageRange { get; set; }

        public Creature(string name)
        {
            Name = name;
            GenerateRandomStats();
        }

        Random random = new Random();
        protected void GenerateRandomStats()
        {
            Attack = random.Next(1, 31);
            Defense = random.Next(1, 31);
            Health = random.Next(1, 101); 
            DamageRange = new Tuple<int, int>(random.Next(1, 11), random.Next(11, 31));
        }

        public int CalculateAttackModifier(Creature opponent)
        {
            return Attack - opponent.Defense + 1;
        }

        public int CalculateDamage()
        {
            Random random = new Random();
            return random.Next(DamageRange.Item1, DamageRange.Item2 + 1);
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;
            if (Health < 0)
                Health = 0;
        }

        public bool IsAlive()
        {
            return Health > 0;
        }
    }
}
