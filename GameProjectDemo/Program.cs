using GameProjectDemo.Concrete;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;

namespace GameProjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User()
            {
                FirstName = "Yunus Emre",
                LastName = "Akinci",
                Id = 1,
                DateOfBirth = new DateTime(2002, 5, 19),
                NationalityId = "12345678910"
            };
            User user2 = new User()
            {
                FirstName = "Engin",
                LastName = "Demirog",
                Id = 2,
                DateOfBirth = new DateTime(1986, 1, 1),
                NationalityId = "10234567890"
            };
            User user3 = new User()
            {
                FirstName = "Ali Fuat",
                LastName = "Cebesoy",
                Id = 3,
                DateOfBirth = new DateTime(1950, 1, 1),
                NationalityId = "23158760910"
            };

            Game game1 = new Game() { GameName = "GTA V", GamePrice = 79 };
            Game game2 = new Game() { GameName = "FIFA 22", GamePrice = 419 };
            Game game3 = new Game() { GameName = "PUBG", GamePrice = 88 };

            Campaigns campaign1 = new Campaigns() { CampaignName = "Haftasonuna Ozel Indirim", CampaignDiscount = 20 };
            Campaigns campaign2 = new Campaigns() { CampaignName = "Yaza Ozel Indirim", CampaignDiscount = 45 };
            Campaigns campaign3 = new Campaigns() { CampaignName = "Size Ozel Indirim", CampaignDiscount = 10 };

            Console.WriteLine("\n***************************************************************************");
            UserManager userManager = new UserManager();
            userManager.Add(user1);
            userManager.Add(user2);
            userManager.Add(user3);
            Console.WriteLine("***************************************************************************\n");

            Console.WriteLine("\n***************************************************************************");
            GameManager gameManager = new GameManager();
            gameManager.Add(game1);
            gameManager.Add(game2);
            gameManager.Add(game3);
            Console.WriteLine("***************************************************************************\n");

            Console.WriteLine("\n***************************************************************************");
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.NewCampaign(campaign1); Console.WriteLine();
            campaignManager.NewCampaign(campaign2); Console.WriteLine();
            campaignManager.NewCampaign(campaign3);
            Console.WriteLine("***************************************************************************\n");

            Console.WriteLine("\n***************************************************************************\n");
            SaleManager saleManager = new SaleManager();
            saleManager.GameSale(game1, user1, campaign1); Console.WriteLine();
            saleManager.GameSale(game3, user2, campaign2); Console.WriteLine();
            saleManager.GameSale(game2, user3, campaign3);
            Console.WriteLine("\n***************************************************************************\n");

            Console.ReadLine();
        }
    }
}
