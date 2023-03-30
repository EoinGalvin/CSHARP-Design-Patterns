using RestaurantSystem.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EoinGalvinProject.BusinessLayer.ReservationAbstractFactory
{
    public abstract class ReservationFactory
    {
        public abstract Reservation GetReservation(int seatingRequired);

        public static ReservationFactory CreateReservationFactory(int sitting)
        {
            if (sitting == 7)
            {
                return new EarlyReservationFactory();
            }
            else
            {
                return new LateReservationFactory();
            }
        }
    }
}

