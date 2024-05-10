using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Aspnet_Core_Identity.Pages
{
    public class LogOutModel : PageModel
    {
        private readonly SignInManager<IdentityUser> signInManager;
        private readonly ILogger<LogOutModel> _logger;


        public LogOutModel(SignInManager<IdentityUser> signInManager, ILogger<LogOutModel> logger)
        {
            this.signInManager = signInManager;
            _logger = logger;

        }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostLogOutAsync()
        {
            await signInManager.SignOutAsync();
            return RedirectToPage("Login");
        }

        public IActionResult OnPostDontLogOutAsync()
        {
            return RedirectToPage("Index");
        }

        //public async Task<IActionResult> OnPost(string returnUrl = null)
        //{
        //    await signInManager.SignOutAsync();
        //    _logger.LogInformation("User logged out.");
        //    if (returnUrl != null)
        //    {
        //        return LocalRedirect(returnUrl);
        //    }
        //    else
        //    {
        //        // This needs to be a redirect so that the browser performs a new
        //        // request and the identity for the user gets updated.
        //        return RedirectToPage();
        //    }
        //}
    }
}
