using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heads_and_Hands.TestTask.Game
{

    public class Game
    {
        private Battle battle;

        public Game(Battle battle)
        {
            this.battle = battle;
        }

        public void Play()
        {
            Console.WriteLine("Добро пожаловать в игру!");

            Player player = new Player("Игрок", 4, 0.3);
            Monster monster = new Monster("Монстр");

            Console.WriteLine($"Здоровье Игрока: {player.Health}");
            Console.WriteLine($"Здоровье Монстра: {monster.Health}");

            while (player.IsAlive() && monster.IsAlive())
            {
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1. Нанести удар");
                Console.WriteLine("2. Восстановить здоровье");
                Console.WriteLine("3. Закончить игру");

                int choice;
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            battle.Fight(player, monster);
                            break;
                        case 2:
                            player.Heal();
                            break;
                        case 3:
                            Console.WriteLine("Игра завершена.");
                            return;
                        default:
                            Console.WriteLine("Введите число из меню");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Недопустимый ввод. Попробуйте еще раз.");
                }
            }

            if (player.IsAlive())
            {
                Console.WriteLine("Игрок победил!");
            }
            else
            {
                Console.WriteLine("Монстр победил!");
            }
        }
    }
}


