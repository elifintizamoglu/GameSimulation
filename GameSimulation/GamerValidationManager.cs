using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation
{
    class GamerValidationManager : IGamerValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if ((!string.IsNullOrEmpty(gamer.FirstName))
                && (!string.IsNullOrEmpty(gamer.LastName))
                && gamer.NationalityId.Length == 11
                && 1900<gamer.YearOfBirth 
                && gamer.YearOfBirth<2022)
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
