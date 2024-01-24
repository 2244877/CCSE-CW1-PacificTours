using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using PacificTours.Models;
using PacificTours.Services;

namespace PacificTours.Pages
{
    [Authorize]
    public class TourBookingsModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        public TourBookingsModel(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public ApplicationUser user { get; set; }

        public IList<TourBooking> TourBookingList { get; set; }
        public async Task OnGet()
        {
            TourBookingList = await _context.tourbookings
                .ToListAsync();
            user = await _userManager.GetUserAsync(User);
        }
    }
}