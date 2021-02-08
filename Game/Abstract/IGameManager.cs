using System;
using System.Collections.Generic;
using System.Text;
using Game.Entities;

namespace Game.Abstract
{
     interface IGameManager
    {
        void Add(Entities.Game game);
        void Delete(Entities.Game game);
        void Update(Entities.Game game);
    }
}
