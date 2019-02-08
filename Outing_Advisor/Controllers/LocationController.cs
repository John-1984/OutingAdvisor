using ApplicationObjects.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Outing_Advisor.Controllers
{
    public class LocationController : Controller
    {
        BusinessLayer.Implementation.LocationBL _location;
        public LocationController()
        {
            _location = new BusinessLayer.Implementation.LocationBL();
        }

        //
        // GET: /Location/

        public ActionResult Location()
        {
            var locationDetails = _location.GetLocationDetails(new ApplicationObjects.Shared.Search());
            return View(locationDetails);
        }

        public ActionResult AddLocation()
        {
            return View();
        }

        public ActionResult LocationReview()
        {
            return View();
        }

        public ActionResult Home()
        {
            return View();
        }

        public ActionResult Suggestions()
        {
            return View();
        }
    }
}
