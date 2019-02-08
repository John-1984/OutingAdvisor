using ApplicationObjects.BO;
using BusinessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Implementation
{
    public class HotelBL : IHotel
    {
        public DataLayer.Implementation.HotelDL _hotel;
        public HotelBL()
        {
            _hotel = new DataLayer.Implementation.HotelDL();
        }

        public HotelBO GetHotelDetails(int hotelId)
        {
            return _hotel.GetHotelDetails(hotelId);
        }
    }
}
