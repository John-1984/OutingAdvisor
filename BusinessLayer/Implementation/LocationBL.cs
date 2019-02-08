using ApplicationObjects.BO;
using ApplicationObjects.Shared;
using BusinessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Implementation
{
    public class LocationBL : ILocation
    {
        public DataLayer.Implementation.LocationDL _location;
        public LocationBL()
        {
            _location = new DataLayer.Implementation.LocationDL();
        }

        public LocationBO GetLocationDetails(Search searchDetails)
        {
            return _location.GetLocationDetails(searchDetails);
        }
    }
}
