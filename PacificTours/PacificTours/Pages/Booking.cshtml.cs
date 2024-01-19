using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PacificTours.Models;
using Microsoft.EntityFrameworkCore;

namespace PacificTours.Pages
{
    [Authorize]
    public class BookingModel : PageModel
    {
        private readonly PacificTours.Services.ApplicationDbContext _context;

        public BookingModel(PacificTours.Services.ApplicationDbContext context)
        {
            _context = context;
        }
        public IList<Hotel> HotelList { get; set; }
        public async Task OnGet()
        {
            HotelList = await _context.hotels
                .ToListAsync();
        }
    }
}
