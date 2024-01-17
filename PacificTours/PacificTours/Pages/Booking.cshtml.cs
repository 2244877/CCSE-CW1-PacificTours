using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PacificTours.Pages
{
    [Authorize]
    public class BookingModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
