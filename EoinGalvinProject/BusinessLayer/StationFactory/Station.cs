using RestaurantSystem.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EoinGalvinProject.BusinessLayer
{
    public abstract class Station
    {
        public static StationDAO DAO = new StationDAOimpl();
        private int stationNo;
        private int stationCapacity;
        private char stationType;
        private char stationStatus;
        
        public int getStationNo() { return stationNo; }
        public int getStationCapacity() { return stationCapacity; }
        public char getStationType() { return stationType; }
        public char getStationStatus() { return stationStatus; }
        public void setStationNo(int stationNo) { this.stationNo = stationNo;}
        public void setStationCapacity(int stationCapacity) { this.stationCapacity = stationCapacity;}
        public void setStationType(char stationType) { this.stationType = stationType;}
        public void setStationStatus(char stationStatus) { this.stationStatus = stationStatus;}
        public abstract void addStationToDB();
        public abstract void updateStation();
        public static DataTable getStationNoCboNotBkd(int stationCapacity, DateTime resDate, Char sitting){
            return DAO.getStationNoCboNotBkd(stationCapacity, resDate, sitting);
        }
        public static void deleteStation(int stationNo){
            DAO.deleteStation(stationNo);
        }
        public static int getNextStationId(){
            return DAO.getNextStationId();
        }
        public static DataTable loadStationsNoFutureRes(){
            return DAO.loadStationsNoFutureRes();
        }
        public static DataTable returnCheckAvailTable(int stationNo, int sitting, String resDateAsString){
            return DAO.returnCheckAvailTable(stationNo, sitting, resDateAsString);
        }
        public static DataTable getAvailableStations(DateTime resDate, int sitting, int stationCapacity, Boolean includeCapacity){
            return DAO.getAvailableStations(resDate, sitting, stationCapacity, includeCapacity);
        }
    }
}
