using RestaurantSystem.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EoinGalvinProject.BusinessLayer.ReservationAbstractFactory
{
    public abstract class LateReservation : Reservation
    {
        public LateReservation() { sitting = 9; }
    }
}
