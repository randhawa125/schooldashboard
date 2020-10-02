using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using ayush.Models;
using ayush.Models.admin;
using ayush.Data;

namespace ayush.Pages.Admin
{
    [AllowAnonymous]
    public class add_schoolModel : PageModel
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ILogger<add_adminModel> _logger;
        private readonly IEmailSender _emailSender;
        private readonly ayushContext _db;
        public add_schoolModel(ayushContext db,
   UserManager<IdentityUser> userManager,
   SignInManager<IdentityUser> signInManager,
   ILogger<add_adminModel> logger,
   IEmailSender emailSender)
        {
            _db = db;
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
        }
        [BindProperty]
        public AddSchoolInfo asi { get; set; }
        public InputModel Input { get; set; }
        public class InputModel
        {
            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }

            [Required]
            [Display(Name = "First Name")]
            public string FirstName { get; set; }



            [Display(Name = "Designation")]
            public string Designation { get; set; }

            [Display(Name = "Address")]
            public string Address { get; set; }

            [Required]
            [Display(Name = "Phone Number")]
            public string PhoneNumber { get; set; }
        }

        public string ReturnUrl { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }


        public async Task OnGetAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            if (ModelState.IsValid)
            {

                var user = new AddSchool { UserName = asi.Email, Email = asi.Email, FirstName = asi.Name_POC, Designation = asi.Designation_POC, Address = asi.Address, PhoneNumber = asi.PhoneNumber };
                var result = await _userManager.CreateAsync(user, asi.Password);
                if (result.Succeeded)
                {
                    _logger.LogInformation("User created a new account with password.");

                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                    var callbackUrl = Url.Page(
                        "/Account/ConfirmEmail",
                        pageHandler: null,
                        values: new { area = "Identity", userId = user.Id, code = code, returnUrl = returnUrl },
                        protocol: Request.Scheme);

                    await _emailSender.SendEmailAsync(asi.Email, "Confirm your email",
                        $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");
                    var users = new AddSchoolInfo
                    {
                        ID = asi.ID,
                        SchoolID = user.Id,
                        SchoolName = asi.SchoolName,
                        Address = asi.Address,
                        PhoneNumber = asi.PhoneNumber,
                        Email = asi.Email,
                        Name_POC = asi.Name_POC,
                        PhoneNumber_POC = asi.PhoneNumber_POC,
                        Email_POC = asi.Email_POC,
                        Address_POC = asi.Address,
                        HighQualification_POC = asi.HighQualification_POC,
                        Designation_POC = asi.Designation_POC,
                        UploadCertifications_POC = asi.UploadCertifications_POC,
                        UploadCv_POC = asi.UploadCv_POC,
                        RegisteredDate = DateTime.Now,
                        Password = asi.Password,
                        ConfirmPassword = asi.ConfirmPassword,
                        IsActive = true
                    };
                    _db.AddSchoolInfos.Add(users);
                    _db.SaveChanges();

                    var addToRoleResult = await _userManager.AddToRoleAsync(user, "School");

                    if (_userManager.Options.SignIn.RequireConfirmedAccount)
                    {
                        return RedirectToPage("RegisterConfirmation", new { email = asi.Email, returnUrl = returnUrl });
                    }
                    else
                    {
                        await _signInManager.SignInAsync(user, isPersistent: false);
                        return LocalRedirect(returnUrl);
                    }
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}
