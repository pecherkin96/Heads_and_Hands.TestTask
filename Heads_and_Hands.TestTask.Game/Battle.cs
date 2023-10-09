using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heads_and_Hands.TestTask.Game
{
    public class Battle
    {
        private Random random = new Random();

        public void Fight(Player player, Monster monster)
        {
            int playerModifier = player.CalculateAttackModifier(monster);
            int monsterModifier = monster.CalculateAttackModifier(player);

            bool playerAttackSuccess = RollDice(playerModifier);
            bool monsterAttackSuccess = RollDice(monsterModifier);

            if (playerAttackSuccess)
            {
                int damage = player.CalculateDamage();
                monster.TakeDamage(damage);
                Console.WriteLine($"Игрок атаковал и нанес {damage} урона Монстру. Здоровье Монстра: {monster.Health}");
            }

            if (monsterAttackSuccess)
            {
                int damage = monster.CalculateDamage();
                player.TakeDamage(damage);
                Console.WriteLine($"Монстр атаковал и нанес {damage} урона Игроку. Здоровье Игрока: {player.Health}");
            }
        }

        private bool RollDice(int modifier)
        {
            int rolls = Math.Max(1, modifier);
            for (int i = 0; i < rolls; i++)
            {
                if (random.Next(1, 7) >= 5 || random.Next(1, 7) >= 6)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
