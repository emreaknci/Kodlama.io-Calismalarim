using System;
using System.Collections.Generic;
using System.Text;
using GameProjectDemo.Entities;

namespace GameProjectDemo.Abstract
{
    interface ICampaignService
    {
        void NewCampaign(Campaigns campaign);
        void CampaignDelete(Campaigns campaign);
        void CampaignUpdate(Campaigns campaign);

    }
}
