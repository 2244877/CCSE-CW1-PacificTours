using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PacificTours.Models;
using PacificTours.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PacificTours.Pages
{
    public class ManagerDashboardModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public ManagerDashboardModel(ApplicationDbContext context)
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