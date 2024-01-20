using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PacificTours.Models;
using Microsoft.AspNetCore.Authorization;
using SQLitePCL;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace PacificTours.Pages
{
    [Authorize]
    public class HotelBookingModel : PageModel
    {
        private readonly PacificTours.Services.ApplicationDbContext _context;
        public HotelBookingModel(PacificTours.Services.ApplicationDbContext context)
        {
            _context = context;
        }
        public IList<HotelBooking> HotelBookingList { get; set; }
        public async void OnGet()
        {
            HotelBookingList = await _context.hotelbookings
                .ToListAsync();
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [Required]
            public string Hotel { get; set; }
            [Required]
            public string Room { get; set; }
            [Required]
            public DateTime CheckInDate { get; set; }
            [Required]
            public DateTime CheckOutDate { get; set; }
        }
    }
}
