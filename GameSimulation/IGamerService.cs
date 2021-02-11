using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation
{
    interface IGamerService
    {
        void AddGamer(Gamer gamer);
        void UpdateGamer(Gamer gamer);
        void DeleteGamer(Gamer gamer);
    }
}
