using GameProjectDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using GameProjectDemo.Entities;

namespace GameProjectDemo.Concrete
{
    class SaleManager : ISaleService
    {
        public void GameSale(Game game, User user, Campaign campaign)
        {
            double discountedPrice = Math.Round(game.GamePrice - (game.GamePrice * (campaign.CampaignDiscount / 100)),2);
            Console.WriteLine(user.FirstName + " " + user.LastName + " Hosgeldiniz!" +
                "\nSatin aldiginiz oyun bilgileri asagida yer almaktadir." +
                "\n-------------------------------"+
                "\nOyun Adi: " + game.GameName +
                "\nOyun Fiyati: " + game.GamePrice + "TL" +
                "\nUygulanan kampanya:"+campaign.CampaignName+" (½" + campaign.CampaignDiscount + " indirim sepette uygulandi!)\n" +
                "Oyununuzun yeni fiyati: " + discountedPrice + "TL" +
                "\nKazanciniz: " + Math.Round((game.GamePrice * (campaign.CampaignDiscount / 100)),2) + "TL");
        }
    }
}
