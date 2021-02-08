using System;
using System.Collections.Generic;
using System.Text;
using Game.Entities;

namespace Game.Abstract
{
    interface IGamerManager
    {
        void Add(Gamer gamer);
        void Delete(Gamer gamer);
        void Update(Gamer gamer);
    }
}
