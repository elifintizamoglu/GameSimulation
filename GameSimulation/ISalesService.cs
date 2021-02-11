using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation
{
    interface ISalesService
    {
        void Saled(Game game, Gamer gamer, Sales sales);
        void SaledWithCampaign(Game game, Gamer gamer, Sales sales, Campaign campaign);
    }
}
