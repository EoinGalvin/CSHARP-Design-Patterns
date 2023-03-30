using RestaurantSystem.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EoinGalvinProject.BusinessLayer.ReservationAbstractFactory
{
    public abstract class Reservation
    {
        public static ReservationDAO DAO = new ReservationDAOimpl();
        public int resID;
        public DateTime resDate;
        public int stationNo;
        public String custName;
        public String custNum;
        public int sitting;
        public float cost;
        public char active;

        // Constructor
        /*public Reservation(int resId, DateTime resDate, int stationNo, String custName, String custNum, int sitting, float cost, char active)
        { 
            this.resID = resId;
            this.resDate = resDate;
            this.stationNo = stationNo;
            this.custName = custName;
            this.custNum = custNum;
            this.sitting = sitting;
            this.cost = cost;
            this.active = active;
        } */
        //public Reservation() { }

        // getters
        public int getResId() { return resID; }
        public DateTime getResDate() { return resDate; }
        public int getStationNo() { return stationNo; }
        public String getCustName() { return custName; }
        public String getCustNum() { return custNum; }
        public int getSitting() { return sitting; }
        public float getCost() { return cost; }
        public char getActive() { return active; }
        
        //setters
        public void setResId(int resId){this.resID= resId;}
        public void setResDate(DateTime resDate) { this.resDate = resDate; }
        public void setStationNo(int stationNo) { this.stationNo= stationNo;}
        public void setCustName(String custname) { this.custName= custname;}
        public void setCustNum(String custNum) { this.custNum= custNum;}
        public void setSitting(int sitting) { this.sitting= sitting;}
        public void setCost(float cost) { this.cost= cost;}
        public void setActive(char active) { this.active= active;}

        public abstract void addReservationToDB();
        public static void deleteFromDatabase(int resId) {
            DAO.deleteFromDatabase(resId);}
        public static void checkIntoSystem(int resID){
            ReservationDAO DAO = new ReservationDAOimpl();
            DAO.checkIntoSystem(resID);
        }
        public static void checkOutSystem(float cost, int resID){
            DAO.checkOutSystem(cost, resID);
        }
        public static DataTable reservationSearch(String custName){
            return DAO.reservationSearch(custName);
        }
        public static DataTable fillResIDCboOnSearch(String custName){
            return DAO.fillResIDCboOnSearch(custName);
        }
        public static int getNextResID(){
            return DAO.getNextResID();
        }
        public static DataTable getRevenueData(int givenYear){
            return DAO.getRevenueData(givenYear);
        }
    }
}
