using ApplicationObjects.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Outing_Advisor.Controllers
{
    public class SuggestionsController : Controller
    {
        BusinessLayer.Implementation.SuggestionsBL _suggestions;
        public SuggestionsController()
        {
            _suggestions = new BusinessLayer.Implementation.SuggestionsBL();
        }

        [HttpPost]
        public JsonResult SaveSuggestions(SuggestionsBO suggestions)
        {
            suggestions.IP = GetClientIP();
            var data = new {Result = _suggestions.SaveSuggestions(suggestions)} ;
            return Json(data, JsonRequestBehavior.AllowGet);
        }

        private string GetClientIP()
        {
            string ip = System.Web.HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
            if (string.IsNullOrEmpty(ip))
            {
                ip = System.Web.HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];
            }
            return ip;
        }

    }
}
