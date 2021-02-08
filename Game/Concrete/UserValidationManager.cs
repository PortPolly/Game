using System;
using System.Collections.Generic;
using System.Text;
using Game.Abstract;
using Game.Entities;
using Microsoft.VisualBasic;

namespace Game.Concrete
{
    class UserValidationManager:IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.FirstName == "Port" & gamer.LastName == "Polly" & gamer.NationalityId == "123456789" & gamer.DateOfBirth == new DateTime(2005,3,25) )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
