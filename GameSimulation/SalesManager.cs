using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation
{
    class SalesManager : ISalesService
    {
        public void Saled(Game game, Gamer gamer, Sales sales)
        {
            Console.WriteLine("Sales Id: "+ sales.SalesId);
            Console.WriteLine("Game " + game.GameName + " saled to " + gamer.FirstName);

        }

        public void SaledWithCampaign(Game game, Gamer gamer, Sales sales, Campaign campaign)
        {
            Console.WriteLine("Sales Id: " + sales.SalesId);
            Console.WriteLine("Game " + game.GameName + " saled to " + gamer.FirstName + " with campaign "+ campaign.CampaignName );
            Console.WriteLine("Game price: "+ game.GamePrice);
            Console.WriteLine("Game price with campaign: "+ (game.GamePrice-campaign.AmountOfDiscount));
        }
    }
}
