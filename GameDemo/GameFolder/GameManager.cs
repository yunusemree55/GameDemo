using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.GameFolder
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.Name + " Added!");
        }

        public void End(Game game)
        {
            Console.WriteLine(game.Name + " Out of Stock!");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.Name + " Updated!");
        }
    }
}
