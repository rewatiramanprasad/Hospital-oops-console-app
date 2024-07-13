using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public class Reservation
    {
        public RoomInv roominv;

        public Reservation(RoomInv _roomInv) { 
        this.roominv=_roomInv;
        }
        public bool ReserveRoom(RoomType roomType)
        {
            return roominv.ReserveRoom(roomType);
        }

        public void DisplayAvailability() {
            roominv.remainAvailibility();
        }

        public void generatePatientId(RoomType roomType) {
        
        roominv.generatePatientId(roomType);
        }

        
    }
}
