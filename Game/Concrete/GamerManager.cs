using System;
using System.Collections.Generic;
using System.Text;
using Game.Abstract;
using Game.Entities;

namespace Game.Concrete
{
    class GamerManager:IGamerManager
    {
        private IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
            
        }

        public void Add(Gamer gamer)

        {
            if (_userValidationService.Validate(gamer))
            {
                Console.WriteLine(gamer.FirstName+gamer.LastName+" adlı oyuncu sisteme eklendi.");
            }
            else
            {
                Console.WriteLine("Oyuncu doğrulanamadı.");
                throw new Exception("Not a valid gamer");
            }

            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName+" adlı oyuncu sistemden silindi.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName+" adlı oyuncu güncellendi.");
        }
    }
}
