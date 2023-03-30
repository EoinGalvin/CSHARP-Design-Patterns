using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EoinGalvinProject.BusinessLayer.ReservationAbstractFactory
{
    public class LateTwoReservation : LateReservation
    {
        public override void addReservationToDB()
        {
            DAO.addReservationToDB(getNextResID(), this.resDate, this.stationNo, this.custName, this.sitting, this.custNum, 2);
        }
    }
    public class LateFourReservation : LateReservation
    {
        public override void addReservationToDB()
        {
            DAO.addReservationToDB(getNextResID(), this.resDate, this.stationNo, this.custName, this.sitting, this.custNum, 4);
        }
    }
    public class LateSixReservation : LateReservation
    {
        public override void addReservationToDB()
        {
            DAO.addReservationToDB(getNextResID(), this.resDate, this.stationNo, this.custName, this.sitting, this.custNum, 6);
        }
    }
    public class LateEightReservation : LateReservation
    {
        public override void addReservationToDB()
        {
            DAO.addReservationToDB(getNextResID(), this.resDate, this.stationNo, this.custName, this.sitting, this.custNum, 8);
        }
    }
    public class LateTenReservation : LateReservation
    {
        public override void addReservationToDB()
        {
            DAO.addReservationToDB(getNextResID(), this.resDate, this.stationNo, this.custName, this.sitting, this.custNum, 10);
        }
    }
    public class LateTwelveReservation : LateReservation
    {
        public override void addReservationToDB()
        {
            DAO.addReservationToDB(getNextResID(), this.resDate, this.stationNo, this.custName, this.sitting, this.custNum, 12);
        }
    }
    public class LateFourteenReservation : LateReservation
    {
        public override void addReservationToDB()
        {
            DAO.addReservationToDB(getNextResID(), this.resDate, this.stationNo, this.custName, this.sitting, this.custNum, 14);
        }
    }
    public class LateSixteenReservation : LateReservation
    {
        public override void addReservationToDB()
        {
            DAO.addReservationToDB(getNextResID(), this.resDate, this.stationNo, this.custName, this.sitting, this.custNum, 16);
        }
    }
}
