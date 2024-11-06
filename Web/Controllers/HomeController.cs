using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Web.Controllers
{
	[Authorize]
	[RoutePrefix("")]
	public class HomeController : Controller
	{
		[Route("app/{a}/{u}")]
		public ActionResult Index(String a, String u)
		{
			if (!System.Threading.Thread.CurrentPrincipal.Identity.Name.ToLower().Equals(u.ToLower()))
			{
                //return the blocked view
                return View("NotAuthorized");
            }


			return View();

			
		}

		public ActionResult StreetView(Double lon, Double lat)
		{
			ViewBag.Lat = lat;
			ViewBag.Lon = lon;
			return View("StreetView");
		}

	}
}