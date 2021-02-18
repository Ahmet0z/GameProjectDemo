using GameProjectDemo.Abstract;
using GameProjectDemo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
    public class CampaignManager : ICampaignManager
    {
        void ICampaignManager.Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " başarıyla silindi.");
        }

        void ICampaignManager.NewCampaign(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " başarıyla eklendi.");
        }

        void ICampaignManager.Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " başarıyla güncellendi.");
        }
    }
}
