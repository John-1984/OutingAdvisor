using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Outing_Advisor.Controllers
{
    public class SearchController : Controller
    {
        //
        // GET: /LocationListing/

        public ActionResult SearchResult()
        {
            return View();
        }

        public ActionResult SearchBar() {
            return PartialView("_Search");
        }

    }
}
