using Aspnet_Core_Identity.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Aspnet_Core_Identity.Pages
{
    public class LoginModel : PageModel
    {
        private readonly SignInManager<IdentityUser> signInManager;

        [BindProperty]
        public Login Model { get; set; }

        public LoginModel(SignInManager<IdentityUser> signInManager)
        {
            this.signInManager = signInManager;
        }
        public void OnGet()
        {
        }

        //public async Task<IActionResult> OnPostAsync(string returnUrl=null)
        //{
        //    if (ModelState.IsValid)
        //    {
        //       var identityResult= await signInManager.PasswordSignInAsync(Model.Email, Model.Password,Model.RememberMe, lockoutOnFailure:false);

        //        if (identityResult.Succeeded)
        //        {
        //            if(returnUrl== null || returnUrl == "/")
        //            {
        //                return RedirectToPage("Index");
        //            }
        //            else
        //            {
        //                return RedirectToPage(returnUrl);
        //            }
        //        }
        //        ModelState.AddModelError("", "UserName or Password incorrect");
        //    }
        //    return Page();
        //}


        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            if (ModelState.IsValid)
            {
                var identityResult = await signInManager.PasswordSignInAsync(Model.Email, Model.Password, Model.RememberMe, lockoutOnFailure: false);

                if (identityResult.Succeeded)
                {
                    if (returnUrl == null || returnUrl == "/")
                    {
                        return RedirectToPage("Index");
                    }
                    else
                    {
                        return RedirectToPage(returnUrl);
                    }
                }
                ModelState.AddModelError("", "UserName or Password incorrect");
            }
            return Page();
        }


    }
}
