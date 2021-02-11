using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation
{
    class GamerManager : IGamerService
    {
        IGamerValidationService gamerValidationService;

        public GamerManager(IGamerValidationService gamerValidationService)
        {
            this.gamerValidationService = gamerValidationService;
        }
        public void AddGamer(Gamer gamer)
        {
            if (gamerValidationService.Validate(gamer) == true)
            {
                Console.WriteLine("Gamer " + gamer.FirstName + " added.");
            }
            else
            {
                Console.WriteLine("Gamer " + gamer.FirstName + " is not valid for adding.");
            }
        }

        public void DeleteGamer(Gamer gamer)
        {
            Console.WriteLine("Gamer " + gamer.FirstName + " deleted.");
        }

        public void UpdateGamer(Gamer gamer)
        {
            Console.WriteLine("Gamer " + gamer.FirstName + " updated.");
        }
    }
}
