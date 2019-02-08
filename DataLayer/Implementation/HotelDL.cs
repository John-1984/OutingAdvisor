using ApplicationObjects.BO;
using DataLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Implementation
{
    public class HotelDL : IHotel
    {
        public HotelBO GetHotelDetails(int hotelId)
        {
            var _hotelTips = new List<string>();
            _hotelTips.Add("Choose a corner room for couples");

            return new HotelBO()
            {
                HotelRatings = new HotelRatingsBO()
                {
                    Accesibility = 3,
                    CoupleFriendly = 3,
                    FoodAndBeverage = 3,
                    Hospitality = 3,
                    Hygiene = 3,
                    Overall = 3,
                    PetFriendly = 3,
                    Romantic = 3
                },
                HotelTips = _hotelTips,
                Id = 1,
                Name = "Silver Cloud",
                ShortDescription = "Hotel was a nice place to stay. The staff is friendly.",
            };
        }
    }
}
