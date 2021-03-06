using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_game
{
    class room
    {
        public event ChangePlayerLocationEventHandler TraverseDoorEvent;
        public room()
        {
            door d = new door();
            d.TraverseDoorEvent += TraverseDoor;
        }
        private void TraverseDoor(object sender, room destination)
        {
            TraverseDoorEvent?.Invoke(sender, destination);
        }
    }
}
