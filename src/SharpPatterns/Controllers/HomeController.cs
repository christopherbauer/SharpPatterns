using System.Web.Mvc;

namespace SharpPatterns.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }

    }
}
