using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Outing_Advisor.Controllers
{
    public class HotelController : Controller
    {
        BusinessLayer.Implementation.HotelBL _hotel;
        public HotelController()
        {
            _hotel = new BusinessLayer.Implementation.HotelBL();
        }

        public ActionResult HotelReview()
        {
            var _hotelDetails = _hotel.GetHotelDetails(1);
            return View(_hotelDetails);
        }

        public ActionResult AddHotel()
        {
            return View();
        }

    }
}
