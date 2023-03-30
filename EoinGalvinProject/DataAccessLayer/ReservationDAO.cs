using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem.DataAccessLayer
{
     public interface ReservationDAO
    {
        void addReservationToDB(int resId, DateTime resDate, int stationNo, String custName, int sitting, String custNum, int seatingRequired);
        void deleteFromDatabase(int resId);
        void checkIntoSystem(int resID);
        void checkOutSystem(float cost, int resID);
        DataTable reservationSearch(String custName);
        DataTable fillResIDCboOnSearch(String custName);
        int getNextResID();
        DataTable getRevenueData(int givenYear);
        DataTable returnTable(string query);
        DataTable getAnyCboData(String sql);

    }
}
