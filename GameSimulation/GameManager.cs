using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation
{
    class GameManager : IGameService
    {
        public void AddGame(Game game)
        {
            Console.WriteLine("Game " + game.GameName+ " added.");
        }

        public void DeleteGame(Game game)
        {
            Console.WriteLine("Game " + game.GameName + " deleted.");
        }

        public void UpdateGame(Game game)
        {
            Console.WriteLine("Game " + game.GameName + " updated.");
        }
    }
}
