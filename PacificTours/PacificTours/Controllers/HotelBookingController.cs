using Microsoft.AspNetCore.Mvc;
using PacificTours.Models;

namespace PacificTours.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    //public class HotelBookingController : Controller
    //{
    //    public IActionResult Index()
    //    {
    //        return View();
    //    }
    //}

    public class HotelBookingController : Controller
    {
        private readonly IHotelBookingRepository _hotelBookingRepository;
        public HotelBookingController(IHotelBookingRepository hotelBookingRepository)
        {
            _hotelBookingRepository = hotelBookingRepository;
        }
        // Get: api/HotelBooking
        [HttpGet]
        public ActionResult<IEnumerable<HotelBooking>> Get()
        {
            return Ok(_hotelBookingRepository.GetHotelBookings());
        }
        // Get:api/HotelBooking/
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return Ok(_hotelBookingRepository.GetHotelBookingById(id));
        }
        // Post: api/HotelBooking/
        [HttpPost]
        public void Post([FromBody] HotelBooking value)
        {
            if (ModelState.IsValid)
            {
                _hotelBookingRepository.InsertHotelBooking(value);
            }
        }
        // Delete: api/HotelBooking
        [HttpDelete("{id}")] 
        public void Delete(int id)
        {
            _hotelBookingRepository.DeleteHotelBooking(id);
        }
    }
}
