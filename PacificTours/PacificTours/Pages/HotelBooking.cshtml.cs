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

        public IList<HotelBooking> HotelBookingList { get; set; }
        public async void OnGet()
        {
            HotelBookingList = await _context.hotelbookings
                .ToListAsync();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            if (ModelState.IsValid)
            {
                var hotelbooking = new HotelBooking()
                {
                    Hotel = Input.Hotel,
                    Room = Input.Room,
                    CheckInDate = Input.CheckInDate,
                    CheckOutDate = Input.CheckOutDate,
                };
                _context.Add(hotelbooking);
                _context.SaveChanges();

            }
            return Page();
        }        
    }
}
