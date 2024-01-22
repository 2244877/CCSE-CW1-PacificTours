using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PacificTours.Models;

namespace PacificTours.Pages
{
    public class TourBookingModel : PageModel
    {
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            HotelBooking hotelBooking = new();
            if (hotelBooking != null)
            {
                return RedirectToPage("./Payment");
            }
            return Page();
        }
    }
}
