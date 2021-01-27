using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.PlayerFolder
{
     class PlayerManager : IPlayerService
    {
        public void Add(Player player)
        {
            Console.WriteLine("Welcome " + player.UserName);
        }

        public void Delete(Player player)
        {
            Console.WriteLine("Good bye " + player.UserName);
        }

        public void Updated(Player player)
        {
            Console.WriteLine(player.UserName + " Updated!");
        }
    }
}
