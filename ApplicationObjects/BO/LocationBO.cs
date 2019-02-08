using ApplicationObjects.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationObjects.BO
{
    public class LocationBO : MasterBO
    {
        public string Name { get; set; }

        public string ShortDescription { get; set; }

        public string FullDescription { get; set; }

        public IList<string> TravelTips { get; set; }

        public IList<string> HotelTips { get; set; }

        public IList<MasterListItem> HotelListing { get; set; }

        public IList<MasterListItem> ReviewListing { get; set; }

        public IList<MasterListItem> Pictures { get; set; }

    }
}
