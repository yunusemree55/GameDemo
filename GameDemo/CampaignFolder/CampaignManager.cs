using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.CampaignFolder
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " Added!");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " Finished!");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " Updated!");
        }
    }
}
