using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PacificTours.Models;
using Microsoft.AspNetCore.Authorization;
using SQLitePCL;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using Microsoft.Identity.Client;
using PacificTours.Services;

namespace PacificTours.Pages
{
    [Authorize]
    public class HotelBookingModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;
        public HotelBookingModel(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
            Hotels = _context.hotels.ToList();
        }

        [BindProperty]
        public InputModel Input { get; set; }
        public class InputModel
        {
            [Required]
            public int Hotel_Id { get; set; }
            [Required]
            public string RoomType { get; set; }
            [Required]
            public DateTime CheckInDate { get; set; }
            [Required]
            public DateTime CheckOutDate { get; set; }
        }

        public List<Hotel> Hotels { get; set; }

        public IList<HotelBooking> HotelBookingList { get; set; }
        public async Task OnGet()
        {

            HotelBookingList = await _context.hotelbookings
                .ToListAsync();
        }

        public ApplicationUser user { get; set; }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            user = await _userManager.GetUserAsync(User);
            if (ModelState.IsValid)
            {
                var hotelbooking = new HotelBooking
                {
                    Hotel_Id = Input.Hotel_Id,
                    User_Id = user.Id,
                    RoomType = Input.RoomType,
                    CheckInDate = Input.CheckInDate,
                    CheckOutDate = Input.CheckOutDate,
                };
                _context.Add(hotelbooking);
                _context.SaveChanges();

            }
            HotelBooking hotelBooking = new();
            if (hotelBooking != null)
            {
                return RedirectToPage("./Payment");
            }
            else
            {
                return Page();
            }
        } 
    }
}
