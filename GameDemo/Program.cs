using GameDemo.CampaignFolder;
using GameDemo.GameFolder;
using GameDemo.PlayerFolder;
using GameDemo.PlayerMarketFolder;
using System;
using System.Collections.Generic;

namespace GameDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            IPlayerService playerManager = new PlayerManager();

            Player player1 = new Player();
            player1.Id = 1;
            player1.TcNo = "12345678910";
            player1.DateOfYear = "2001";
            player1.FirstName = "Yunus Emre";
            player1.LastName = "Çiçek";
            player1.UserName = "yunusemre55";

            Player player2 = new Player { Id = 2, TcNo = "98732165401", DateOfYear = "2003", FirstName = "Enes Emir", LastName = "Çiçek", UserName = "enesemir55" };
 
            
            List<Player> players = new List<Player> { player1, player2 }; // Oyunculara daha kolay ulaşmak için List yapısı kullanıldı.


            Console.WriteLine("-_-_-_-_-_-_New Players-_-_-_-_-_-_-");
            foreach (var player in players)
            {
                playerManager.Add(player);
            }

            //-------------------------------------------------------------------------------------------------------------------

            ICampaignService campaignManager = new CampaignManager();
            Campaign campaign1 = new Campaign { Name = "Black Friday", Discount = 60 };
            Campaign campaign2 = new Campaign { Name = "Summer Pass", Discount = 70 };


            Console.WriteLine("-_-_-_-_-_-_Campaign List-_-_-_-_-_-_-");

            Campaign[] campaigns = new Campaign[] { campaign1, campaign2 };  //Kampanyalar listeye eklendi.
            
            foreach (var campaign in campaigns)
            {
                campaignManager.Add(campaign);
                campaignManager.Update(campaign);
                Console.WriteLine("----------------");
                campaignManager.Delete(campaign);
            }

            //-------------------------------------------------------------------------------------------------------------------
            IGameService gameManager = new GameManager();

            Game game1 = new Game { Name = "Days Gone", Price = 400 };
            Game game2 = new Game { Name = "Assasin's Creed Origins", Price = 299 };

            List<Game> games = new List<Game> { game1, game2 };    // Oluşturulan oyunlar için liste oluşturuldu.

            Console.WriteLine("-_-_-_-_-_-New Games-_-_-_-_-_-_-");
            foreach (var game in games)
            {
                gameManager.Add(game);
            }


            List<Game> outGames = new List<Game> { game1 };  // Stokta kalmayan oyunlar için liste oluşturuldu. Eğer başka oyunlar da biterse .Add komutu ile eklenilebilir.

            foreach (var outGame in outGames)
            {
                gameManager.End(outGame);
            }


            //-------------------------------------------------------------------------------------------------------------------
            IMarketService marketManager = new MarketManager();

            //marketManager.Basket(game2, player2);

            Console.WriteLine("Choose one of them to add your basket\n1){0}\n2){1}",game1.Name,game2.Name);
            int x = Convert.ToInt32(Console.ReadLine());  // Oyuncu, değer girer

            if (x==1)
            {
                marketManager.Basket(game1, player2);        //Oyuncu, 1 yazarsa 1.seçenekteki oyunu ekler.
            }
            else if(x==2)
            {
                marketManager.Basket(game2, player2);        //Oyuncu, 2 yazarsa 2.seçenekteki oyunu ekler.
            }
            else
            {
                Console.WriteLine("Game is not found");      //Oyuncu, 1 veya 2'den başka değer girerse bu komut çalışır.
            }

            //--------------------------------------------------------------------------------------------------------------------

            marketManager.Sell(game1, player1);     // Oyuncu, oyun sattığında ismiyle birlikte oyunu yazdırır.






        }
    }
}
