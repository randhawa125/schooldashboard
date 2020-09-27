using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ayush.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
	public class LoginModel : PageModel
	{
		private readonly UserManager<IdentityUser> _userManager;
		private readonly SignInManager<IdentityUser> _signInManager;
		private readonly ILogger<LoginModel> _logger;

		public LoginModel(SignInManager<IdentityUser> signInManager,
			ILogger<LoginModel> logger,
			UserManager<IdentityUser> userManager)
		{
			_userManager = userManager;
			_signInManager = signInManager;
			_logger = logger;

		}

		[BindProperty]
		public InputModel Input { get; set; }

		public IList<AuthenticationScheme> ExternalLogins { get; set; }

		public string ReturnUrl { get; set; }

		[TempData]
		public string ErrorMessage { get; set; }

		public class InputModel
		{
			[Required]
			public string Email { get; set; }

			[Required]
			[DataType(DataType.Password)]
			public string Password { get; set; }

			[Display(Name = "Remember me?")]
			public bool RememberMe { get; set; }
		}

		public async Task OnGetAsync(string returnUrl = null)
		{
			if (!string.IsNullOrEmpty(ErrorMessage))
			{
				ModelState.AddModelError(string.Empty, ErrorMessage);
			}

			returnUrl = returnUrl ?? Url.Content("~/");

			// Clear the existing external cookie to ensure a clean login process
			await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);

			ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

			ReturnUrl = returnUrl;
		}

		public async Task<IActionResult> OnPostAsync(string returnUrl = null)
		{
			returnUrl = returnUrl ?? Url.Content("~/");
			if (ModelState.IsValid)
			{
				// This doesn't count login failures towards account lockout
				// To enable password failures to trigger account lockout, set lockoutOnFailure: true
				bool loginByPhone = false;
				string email = string.Empty;
				var result = await _signInManager.PasswordSignInAsync(Input.Email, Input.Password, Input.RememberMe, lockoutOnFailure: false);
				if (!result.Succeeded)
                {
					var user = await _userManager.Users.FirstOrDefaultAsync(x => x.PhoneNumber == Input.Email);
					result = await _signInManager.PasswordSignInAsync(user, Input.Password, Input.RememberMe, lockoutOnFailure: false);
					loginByPhone = true;
					email = user.Email;
				}
				
				if (result.Succeeded)
				{
					if (!string.IsNullOrEmpty(returnUrl))
					{
						_logger.LogInformation("User logged in.");
						
						if(loginByPhone == false)
                        {
							email = Input.Email;
                        }

						var Find_user = await _userManager.FindByNameAsync(email);
						var User_roles = await _userManager.GetRolesAsync(Find_user);

						if (User_roles[0] == "Admin")
						{
							return Redirect("~/Admin/Dashboard");
						}
						else if (User_roles[0] == "Student")
						{
							return Redirect("~/Student/Dashboard");
						}
						else if (User_roles[0] == "Counsellor")
						{
							return Redirect("~/Counsellor/Dashboard");
						}
						else if (User_roles[0] == "School")
						{
							return Redirect("~/School/Dashboard");
						}
					}
					else
					{
						_logger.LogInformation("User logged in.");
						return LocalRedirect(returnUrl);
					}
				}
				if (result.RequiresTwoFactor)
				{
					return RedirectToPage("./LoginWith2fa", new { ReturnUrl = returnUrl, RememberMe = Input.RememberMe });
				}
				if (result.IsLockedOut)
				{
					_logger.LogWarning("User account locked out.");
					return RedirectToPage("./Lockout");
				}
				else
				{
					ModelState.AddModelError(string.Empty, "Invalid login attempt.");
					return Page();
				}
			}

			// If we got this far, something failed, redisplay form
			return Page();
		}
	}
}
