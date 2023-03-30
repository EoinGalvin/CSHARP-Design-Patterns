using RestaurantSystem.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EoinGalvinProject.BusinessLayer.ReservationAbstractFactory
{
    public class LateReservationFactory : ReservationFactory
    {
        public override Reservation GetReservation(int seatingRequired)
        {
            if (seatingRequired == 2) { return new LateTwoReservation(); }
            if (seatingRequired == 4) { return new LateFourReservation(); }
            if (seatingRequired == 6) { return new LateSixReservation(); }
            if (seatingRequired == 8) { return new LateEightReservation(); }
            if (seatingRequired == 10) { return new LateTenReservation(); }
            if (seatingRequired == 12) { return new LateTwelveReservation(); }
            if (seatingRequired == 14) { return new LateFourteenReservation(); }
            if (seatingRequired == 16) { return new LateSixteenReservation(); }
            else { return null; }
        }
    }
}
