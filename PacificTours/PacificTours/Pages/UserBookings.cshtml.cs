using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PacificTours.Models;

namespace PacificTours.Pages
{
    public class HotelBookingsModel : PageModel
    {
        private readonly PacificTours.Services.ApplicationDbContext _context;
        public HotelBookingsModel(PacificTours.Services.ApplicationDbContext context)
        {
            _context = context;
        }
        public IList<HotelBooking> HotelBookingList { get; set; }
        public async Task OnGet()
        {
            HotelBookingList = await _context.hotelbookings
                .ToListAsync();
        }
    }
}
