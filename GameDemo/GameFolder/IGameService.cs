using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.GameFolder
{
    interface IGameService
    {
        void Add(Game game);
        void End(Game game);
        void Update(Game game);
    }
}
