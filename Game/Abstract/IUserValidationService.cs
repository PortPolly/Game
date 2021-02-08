using System;
using System.Collections.Generic;
using System.Text;
using Game.Entities;

namespace Game.Abstract
{
    interface IUserValidationService
    {
        bool Validate(Gamer gamer);
    }
}
