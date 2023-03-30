using RestaurantSystem.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EoinGalvinProject.BusinessLayer
{
    public class WindowStation : Station
    {
        public WindowStation()
        {
            setStationType('W');
        }

        public override void addStationToDB(){
            DAO.addStationToDB(getStationNo(), getStationCapacity(),'W', getStationStatus());
        }
        public override void updateStation(){
            DAO.updateStation(getStationNo(), getStationCapacity(), 'W', getStationStatus());
        }
    }
}
