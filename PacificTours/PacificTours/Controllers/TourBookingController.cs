using Microsoft.AspNetCore.Mvc;

namespace PacificTours.Controllers
{
    public class TourBookingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
