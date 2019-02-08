using ApplicationObjects.BO;
using ApplicationObjects.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Interfaces
{
    public interface ILocation
    {
        LocationBO GetLocationDetails(Search searchDetails);
    }
}
