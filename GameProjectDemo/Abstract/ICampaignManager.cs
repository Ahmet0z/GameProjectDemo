using GameProjectDemo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Abstract
{
    public interface ICampaignManager
    {
        void NewCampaign(Campaign campaign);
        void Delete(Campaign campaign);
        void Update(Campaign campaign);
    }
}
