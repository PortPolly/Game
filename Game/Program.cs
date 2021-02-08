using System;
using Game.Concrete;
using Game.Entities;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer()
            {
                DateOfBirth = new DateTime(2005, 3, 25), FirstName = "Port", LastName = "Polly",
                NationalityId = "123456789"
            };

            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            SaleManager saleManager = new SaleManager();
            SellManager sellManager = new SellManager();
            GameManager gameManager = new GameManager();
            Entities.Game game = new Entities.Game() {GameName = "Hades", GamePrice = 40, Id = 1};
            Sale sale = new Sale() {Discount = 10, SaleId = 1, SaleName = "Hades oyununda indirim"};
            saleManager.Add(sale);
            gameManager.Add(game);
            gamerManager.Add(gamer);
            sellManager.SellWithSale(gamer,game,sale);
            sellManager.SellWithoutSale(gamer,game);

        }
    }
}
