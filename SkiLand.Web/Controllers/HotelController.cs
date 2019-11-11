using Microsoft.AspNetCore.Mvc;
using SkiLand.Domain.Repositories;
using System.Threading.Tasks;

namespace SkiLand.Web.Controllers
{
    [Route("Hotels")]
    public class HotelController : Controller
    {
        private readonly IHotelRepository _repository;
        public HotelController(IHotelRepository repository)
        {
            _repository = repository;
        }
        // GET: Hotel
        public async Task <ActionResult> Index()
        {
            return View(await _repository.FindAll());
        }
    }
}