using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EoinGalvinProject.BusinessLayer.ReservationAbstractFactory
{
    public abstract class EarlyReservation : Reservation
    {
        public EarlyReservation() { sitting = 7;}
    }
}
