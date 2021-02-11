using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation
{
    interface IGamerValidationService
    {
        bool Validate(Gamer gamer);
    }
}
