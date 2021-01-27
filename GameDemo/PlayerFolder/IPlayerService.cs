using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.PlayerFolder
{
    interface IPlayerService
    {
        void Add(Player player);
        void Updated(Player player);
        void Delete(Player player);
    }
}
