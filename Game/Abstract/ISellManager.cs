
using System;
using System.Collections.Generic;
using System.Text;
using Game.Entities;

namespace Game.Abstract
{
    interface ISellManager
    {
        void SellWithSale(Gamer gamer, Entities.Game game,Sale sale);
        void SellWithoutSale(Gamer gamer, Entities.Game game);
    }
}
