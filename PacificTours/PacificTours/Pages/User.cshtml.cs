using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PacificTours.Models;

namespace PacificTours.Pages
{
    [Authorize]
    public class UserModel : PageModel
    {
        private UserManager<ApplicationUser> UserManager { get; set; }
        public ApplicationUser? appUser;
        public UserModel(UserManager<ApplicationUser> userManager)
        {
            this.UserManager = userManager;
        }
        public void OnGet()
        {
            var userTask = UserManager.GetUserAsync(User);
            userTask.Wait();
            appUser = userTask.Result;
        }
    }
}
