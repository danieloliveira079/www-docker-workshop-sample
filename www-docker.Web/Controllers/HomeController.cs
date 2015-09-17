using System.Web.Mvc;

namespace www-docker.Web.Controllers
{
    public class HomeController : www-dockerControllerBase
    {
        public ActionResult Index()
        { 
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}