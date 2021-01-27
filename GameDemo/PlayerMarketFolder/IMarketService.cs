using GameDemo.GameFolder;
using GameDemo.PlayerFolder;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.PlayerMarketFolder
{
    interface IMarketService
    {
        void Buy(Game game, Player player);
        void Sell(Game game, Player player);
        void Basket(Game game, Player player);

    }
}
