using System;
using System.Collections.Generic;
using System.Text;
using Game.Entities;

namespace Game.Abstract
{
    interface ISaleManager
    {
        void Add(Sale sale);
        void Delete(Sale sale);
        void Update(Sale sale);

    }
}
