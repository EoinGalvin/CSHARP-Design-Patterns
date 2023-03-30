using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EoinGalvinProject.BusinessLayer.ReservationAbstractFactory
{
    public class EarlyTwoReservation : EarlyReservation
    {
        public override void addReservationToDB()
        {
            DAO.addReservationToDB(getNextResID(), this.resDate, this.stationNo, this.custName, this.sitting, this.custNum,2);
        }  
    }
    public class EarlyFourReservation : EarlyReservation
    {
        public override void addReservationToDB(){
            DAO.addReservationToDB(getNextResID(), this.resDate, this.stationNo, this.custName, this.sitting, this.custNum, 4);
        }
    }
    public class EarlySixReservation : EarlyReservation
    {
        public override void addReservationToDB(){
            DAO.addReservationToDB(getNextResID(), this.resDate, this.stationNo, this.custName, this.sitting, this.custNum, 6);
        }
    }
    public class EarlyEightReservation : EarlyReservation
    {
        public override void addReservationToDB()
        {
            DAO.addReservationToDB(getNextResID(), this.resDate, this.stationNo, this.custName, this.sitting, this.custNum, 8);
        }
    }
    public class EarlyTenReservation : EarlyReservation
    {
        public override void addReservationToDB()
        {
            DAO.addReservationToDB(getNextResID(), this.resDate, this.stationNo, this.custName, this.sitting, this.custNum, 10);
        }
    }
    public class EarlyTwelveReservation : EarlyReservation
    {
        public override void addReservationToDB()
        {
            DAO.addReservationToDB(getNextResID(), this.resDate, this.stationNo, this.custName, this.sitting, this.custNum, 12);
        }
    }
    public class EarlyFourteenReservation : EarlyReservation
    {
        public override void addReservationToDB()
        {
            DAO.addReservationToDB(getNextResID(), this.resDate, this.stationNo, this.custName, this.sitting, this.custNum, 14);
        }
    }
    public class EarlySixteenReservation : EarlyReservation
    {
        public override void addReservationToDB()
        {
            DAO.addReservationToDB(getNextResID(), this.resDate, this.stationNo, this.custName, this.sitting, this.custNum, 16);
        }
    }

}
