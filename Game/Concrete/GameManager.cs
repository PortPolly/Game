using System;
using System.Collections.Generic;
using System.Text;
using Game.Abstract;

namespace Game.Concrete
{
    class GameManager:IGameManager
    {
        public void Add(Entities.Game game)
        {
            Console.WriteLine();
        }

        public void Delete(Entities.Game game)
        {
            throw new NotImplementedException();
        }

        public void Update(Entities.Game game)
        {
            throw new NotImplementedException();
        }
    }
}
