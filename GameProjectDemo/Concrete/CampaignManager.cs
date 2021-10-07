using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
    class CampaignManager : ICampaignService
    {
        public void CampaignDelete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " kampanyasi sona erdi.");
                           
        }

        public void CampaignUpdate(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " kampanyasi guncellendi." +
                           "\nGuncel kampanya indirimi %" + campaign.CampaignDiscount + " olarak belirlendi.");
        }

        public void NewCampaign(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName+" kampanyasi olusturuldu." +
                "\nKampanya indirimi %"+campaign.CampaignDiscount+" olarak belirlendi.");
        }
    }
}
