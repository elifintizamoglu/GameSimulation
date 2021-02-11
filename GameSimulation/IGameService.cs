using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation
{
    interface IGameService
    {
        void AddGame(Game game);
        void DeleteGame(Game game);
        void UpdateGame(Game game);

    }
}
