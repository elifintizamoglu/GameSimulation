using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation
{
    class CampaignManager : ICampaignService
    {
        public void AddCampaign(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " is added.");
        }

        public void DeleteCampaign(Campaign campaign)
        {
            Console.WriteLine( campaign.CampaignName + " is deleted.");
        }

        public void UpdateCampaign(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " is updated.");
        }
    }
}
