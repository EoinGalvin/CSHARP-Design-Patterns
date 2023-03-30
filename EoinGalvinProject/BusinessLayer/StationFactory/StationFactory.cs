using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EoinGalvinProject.BusinessLayer
{
    public class StationFactory
    {
        public static Station CreateStation(char stationType)
        {
            switch(stationType)
            {
                case 'W':
                    return new WindowStation();
                case 'B':
                    return new BalconyStation();
                case 'C':
                    return new CentreStation();
                default:
                    throw new Exception("Invalid station type");
            }
        }
    }
}
