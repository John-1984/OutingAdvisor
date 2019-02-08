using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationObjects.BO
{
    public class MasterBO
    {
        public QuickViewBO QuickView { get; set; }

        public LocationRatingsBO Ratings { get; set; }
    }
}
