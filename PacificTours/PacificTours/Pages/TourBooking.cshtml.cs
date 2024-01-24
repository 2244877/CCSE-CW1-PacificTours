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
    public class TourBookingModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;
        public TourBookingModel(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
            Tours = _context.tours.ToList();
        }

        [BindProperty]
        public InputModel Input { get; set; }
        public class InputModel
        {
            [Required]
            public int Tour_Id { get; set; }
            [Required]
            public DateTime CheckInDate { get; set; }
            [Required]
            public DateTime CheckOutDate { get; set; }
        }

        public List<Tour> Tours { get; set; }

        public IList<TourBooking> TourBookingList { get; set; }
        public async Task OnGet()
        {

            TourBookingList = await _context.tourbookings
                .ToListAsync();
        }

        public ApplicationUser user { get; set; }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            user = await _userManager.GetUserAsync(User);
            if (ModelState.IsValid)
            {
                var tourbooking = new TourBooking
                {
                    User_Id = user.Id,
                    Tour_Id = Input.Tour_Id,
                    CheckInDate = Input.CheckInDate,
                    CheckOutDate = Input.CheckOutDate,
                };
                _context.Add(tourbooking);
                _context.SaveChanges();

            }
            TourBooking tourBooking = new();
            if (tourBooking != null)
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