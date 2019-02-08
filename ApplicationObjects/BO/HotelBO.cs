using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationObjects.BO
{
    public class HotelBO
    {
        public string Name { get; set; }

        public int Id { get; set; }

        public string ShortDescription { get; set; }

        public IList<string> HotelTips { get; set; }

        public HotelRatingsBO HotelRatings { get; set; }
    }
}
