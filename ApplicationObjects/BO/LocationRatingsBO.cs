using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationObjects.BO
{
    public class LocationRatingsBO
    {
        public int Safety { get; set; }

        public int Accessibility { get; set; }

        public int Accomodation { get; set; }

        public int Travel { get; set; }

        public int Romantic { get; set; }
    }
}
