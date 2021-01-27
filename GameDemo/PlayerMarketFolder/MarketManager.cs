using GameDemo.GameFolder;
using GameDemo.PlayerFolder;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.PlayerMarketFolder
{
    class MarketManager : IMarketService
    {
        public void Basket(Game game, Player player)
        {
            Console.WriteLine(game.Name + " was added in basket by " + player.UserName);
        }

        public void Buy(Game game, Player player)
        {
            Console.WriteLine(player.UserName + " bought " + game.Name);
        }

        public void Sell(Game game, Player player)
        {
            Console.WriteLine(player.UserName + " sold " + game.Name);
        }
    }
}
