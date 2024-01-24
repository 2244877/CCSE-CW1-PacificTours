using Microsoft.AspNetCore.Mvc;
using PacificTours.Models;

namespace PacificTours.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TourBookingController : Controller
    {
        private readonly ITourBookingRepository _tourBookingRepository;
        public TourBookingController(ITourBookingRepository tourBookingRepository)
        {
            _tourBookingRepository = tourBookingRepository;
        }
        // Get: api/TourBooking
        [HttpGet]
        public ActionResult<IEnumerable<TourBooking>> Get()
        {
            return Ok(_tourBookingRepository.GetTourBookings());
        }
        // Get:api/TourBooking/
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return Ok(_tourBookingRepository.GetTourBookingById(id));
        }
        // Post: api/TourBooking/
        [HttpPost]
        public void Post([FromBody] TourBooking value)
        {
            if (ModelState.IsValid)
            {
                _tourBookingRepository.InsertTourBooking(value);
            }
        }
        // Delete: api/TourBooking
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _tourBookingRepository.DeleteTourBooking(id);
        }
    }
}
