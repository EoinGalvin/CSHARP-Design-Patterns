using RestaurantSystem.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EoinGalvinProject.BusinessLayer.ReservationAbstractFactory
{
    public class EarlyReservationFactory : ReservationFactory
    {
        public override Reservation GetReservation(int seatingRequired)
        {
            if(seatingRequired == 2) { return new EarlyTwoReservation();}
            if (seatingRequired == 4) { return new EarlyFourReservation(); }
            if (seatingRequired == 6) { return new EarlySixReservation(); }
            if (seatingRequired == 8) { return new EarlyEightReservation(); }
            if (seatingRequired == 10) { return new EarlyTenReservation(); }
            if (seatingRequired == 12) { return new EarlyTwelveReservation(); }
            if (seatingRequired == 14) { return new EarlyFourteenReservation(); }
            if (seatingRequired == 16) { return new EarlySixteenReservation(); }
            else { return null; }
        }
    }
}
