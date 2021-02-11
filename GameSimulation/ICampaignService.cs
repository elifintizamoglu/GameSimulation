using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation
{
    interface ICampaignService
    {
        void AddCampaign(Campaign campaign);
        void DeleteCampaign(Campaign campaign);
        void UpdateCampaign(Campaign campaign);

    }
}
