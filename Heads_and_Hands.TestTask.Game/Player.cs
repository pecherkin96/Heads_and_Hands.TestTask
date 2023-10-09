using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Heads_and_Hands.TestTask.Game
{
    public class Player : Creature
    {
        public int MaxHealUses { get; set; }
        public double HealPercentage { get; set; }
        public int HealUses { get; set; }

        public Player(string name, int maxHealUses, double healPercentage)
            : base(name)
        {
            MaxHealUses = maxHealUses;
            HealPercentage = healPercentage;
            HealUses = 0;
        }

        public void Heal()
        {
            if (HealUses < MaxHealUses)
            {
                int healAmount = (int)(Health * HealPercentage);
                Health += healAmount;
                if (Health > 100)
                    Health = 100;
                HealUses++;
                Console.WriteLine($"Игрок восстановил здоровье. Здоровье Игрока: {Health}");
            }
            else
            {
                Console.WriteLine($"Исчерпан лимит восстановления здоровья");
            }
        }
    }

}
