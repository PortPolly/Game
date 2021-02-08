using System;
using System.Collections.Generic;
using System.Text;
using Game.Abstract;
using Game.Entities;

namespace Game.Concrete
{
    class SellManager:ISellManager
    {
        public void SellWithSale(Gamer gamer, Entities.Game game, Sale sale)
        {
            Console.WriteLine(gamer.FirstName+gamer.LastName+ " adlı oyuncu "+(game.GamePrice-sale.Discount)+" TL'ye "+game.GameName+ " adlı oyunu aldı.");
        }

        public void SellWithoutSale(Gamer gamer, Entities.Game game)
        {
            Console.WriteLine(gamer.FirstName + gamer.LastName + " adlı oyuncu " + game.GamePrice + " TL'ye " + game.GameName + " adlı oyunu aldı.");
        }
    }
}
