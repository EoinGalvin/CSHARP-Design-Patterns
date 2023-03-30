using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EoinGalvinProject.BusinessLayer
{
    public class BalconyStation : Station
    {
        public BalconyStation()
        {
            setStationType('B');
        }

        public override void addStationToDB(){
            DAO.addStationToDB(getStationNo(), getStationCapacity(), 'B', getStationStatus());
        }
        public override void updateStation(){
            DAO.updateStation(getStationNo(), getStationCapacity(), 'B', getStationStatus());
        }
    }
}
