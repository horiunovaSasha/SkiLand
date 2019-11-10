using Microsoft.AspNetCore.Mvc;

namespace SkiLand.Web.Controllers
{
    [Route("Hotels")]
    public class HotelController : Controller
    {
        // GET: Hotel
        public ActionResult Index()
        {
            return View();
        }
    }
}