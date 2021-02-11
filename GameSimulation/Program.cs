using System;

namespace GameSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer() { FirstName = "Elif", LastName = "İntizam", NationalityId = "12345678910", YearOfBirth = 1999 };
            GamerManager gamermanager = new GamerManager(new GamerValidationManager());
            gamermanager.AddGamer(gamer1);

            Game game1 = new Game() { GameId = 11111, GameName = "Super Mario", GamePrice = 55.89 };
            GameManager gameManager = new GameManager();
            gameManager.AddGame(game1);

            Campaign campaign1 = new Campaign() { CampaignName = "New Year Campaign", AmountOfDiscount = 20 };
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.AddCampaign(campaign1);

            Sales sales1 = new Sales() { SalesId = "22222", BuyerName = gamer1.FirstName, SaledGame = game1.GameName };
            SalesManager salesManager = new SalesManager();
            salesManager.Saled(game1, gamer1, sales1);
            salesManager.SaledWithCampaign(game1, gamer1, sales1, campaign1);

        }
    }
}
