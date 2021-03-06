using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_game
{
    class player
    {
        room location;

        public void UpdateLocation(room destination)
        {
            this.location = destination;
        }
    }
}
