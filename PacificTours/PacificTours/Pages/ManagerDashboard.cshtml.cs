using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PacificTours.Models;
using PacificTours.Services;

namespace PacificTours.Pages
{
    [Authorize(Roles = "admin")]
    public class ManagerDashboardModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        public ManagerDashboardModel(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public ApplicationUser user { get; set; }

        public IList<HotelBooking> HotelBookingList { get; set; }
        public async Task OnGet()
        {
            HotelBookingList = await _context.hotelbookings
                .ToListAsync();
            user = await _userManager.GetUserAsync(User);
        }
    }
}
