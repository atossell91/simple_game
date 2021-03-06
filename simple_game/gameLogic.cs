using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_game
{
    class gameLogic
    {
        private player Player;
        public gameLogic()
        {
            room r = new room();
            r.TraverseDoorEvent += MovePlayerThroughDoor;
        }
        private void MovePlayerThroughDoor(object sender, room destination)
        {
            Player.UpdateLocation(destination);
        }
    }
}
