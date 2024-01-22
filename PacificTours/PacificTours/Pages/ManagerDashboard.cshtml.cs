using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PacificTours.Pages
{
    [Authorize(Roles = "admin")]
    public class ManagerDashboardModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
