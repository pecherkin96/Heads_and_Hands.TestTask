using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heads_and_Hands.TestTask.Game
{
    class Program
    {
        static void Main(string[] args)
        {
           Battle battle = new Battle();
            Game game = new Game(battle);
            game.Play();

        }
    }
}