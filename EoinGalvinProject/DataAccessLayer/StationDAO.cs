using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem.DataAccessLayer
{
    public interface StationDAO
    {
        void addStationToDB(int stationNo, int stationCapacity, char stationType, char stationStatus);
        void updateStation(int stationNo, int stationCapacity, char stationType, char stationStatus);
        void deleteStation(int stationNo);
        int getNextStationId();
        DataTable loadStationsNoFutureRes();
        DataTable returnCheckAvailTable(int stationNo, int sitting, String resDateAsString);
        DataTable getAvailableStations(DateTime resDate, int sitting, int stationCapacity, Boolean includeCapacity);
        DataTable getStationNoCboNotBkd(int stationCapacity, DateTime resDate, Char sitting);
    }

}
