using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EoinGalvinProject.BusinessLayer
{
    public class CentreStation : Station
    {
        public CentreStation()
        {
            setStationType('C');
        }

        public override void addStationToDB(){
            DAO.addStationToDB(getStationNo(), getStationCapacity(), 'C', getStationStatus());
        }
        public override void updateStation(){
            DAO.updateStation(getStationNo(), getStationCapacity(), 'C', getStationStatus());
        }
    }
}
