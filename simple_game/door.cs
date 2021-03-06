using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_game
{
    delegate void ChangePlayerLocationEventHandler(object sender, room destination);
    class door
    {
        public event ChangePlayerLocationEventHandler TraverseDoorEvent;

        room dest;

        public door()
        {
        }
        private void TraverseDoor(object sender, room destination)
        {
            TraverseDoorEvent?.Invoke(sender, destination);
        }
        public void Traverse()
        {
            TraverseDoor(this, dest);
        }
    }
}
