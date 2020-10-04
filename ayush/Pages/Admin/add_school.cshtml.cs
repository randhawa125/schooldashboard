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
using System.IO;
using Microsoft.AspNetCore.Hosting;
using ayush.Models.ViewModels;
using Microsoft.AspNetCore.Http;

namespace ayush.Pages.Admin
{
    [AllowAnonymous]
    public class add_schoolModel : PageModel
    {
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ILogger<add_adminModel> _logger;
        private readonly IEmailSender _emailSender;
        private readonly ayushContext _db;

        [Obsolete]
        public add_schoolModel(ayushContext db,
            IHostingEnvironment hostingEnvironment,
   UserManager<IdentityUser> userManager,
   SignInManager<IdentityUser> signInManager,
   ILogger<add_adminModel> logger,
   IEmailSender emailSender)
        {
            _db = db;
            webHostEnvironment = (IWebHostEnvironment)hostingEnvironment;
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
        }
        [BindProperty]
        public AddSchoolInfoViewModel asi { get; set; }
        [BindProperty]
        public InputModel Input { get; set; }
        [BindProperty]
        public List<IFormFile> UploadCenrtificate_poc { get; set; }

        [BindProperty]
        public List<IFormFile> Upload_CV_poc_files { get; set; }

        public List<SchoolCertificate> certificates { get; set; }
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
        private string UploadedFile(int ID)
        {
            string uniqueFileName = null;
            if (UploadCenrtificate_poc != null)
            {
                SchoolCertificate schoolCertificate= new SchoolCertificate();
                var schooldata = _db.AddSchoolInfos.Where(s => s.ID == ID).FirstOrDefault();
                if (UploadCenrtificate_poc != null && UploadCenrtificate_poc.Count != 0)
                {
                    string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "SchoolFiles/POC_Certificates");
                    foreach (IFormFile formfile in UploadCenrtificate_poc)
                    {
                        uniqueFileName = Guid.NewGuid().ToString() + "_" + formfile.FileName;
                        string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                        using (var fileStream = new FileStream(filePath, FileMode.Create))
                        {
                            formfile.CopyTo(fileStream);
                        }
                        schoolCertificate.SchoolID = 0;
                        schoolCertificate.ID = schooldata.ID;
                        schoolCertificate.UploadCertifications_POC = uniqueFileName;
                        _db.schoolCertificates.Add(schoolCertificate);
                        _db.SaveChanges();
                    }
                }
                if (Upload_CV_poc_files != null && Upload_CV_poc_files.Count != 0)
                {
                    string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "SchoolFiles/POC_CV's");
                    foreach (IFormFile formfile in Upload_CV_poc_files)
                    {
                        uniqueFileName = Guid.NewGuid().ToString() + "_" + formfile.FileName;
                        string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                        using (var fileStream = new FileStream(filePath, FileMode.Create))
                        {
                            formfile.CopyTo(fileStream);
                        }
                        schoolCertificate.ID = schooldata.ID;
                        schoolCertificate.SchoolID = 0;
                        schoolCertificate.UploadCv_POC = uniqueFileName;
                        _db.schoolCertificates.Add(schoolCertificate);
                        _db.SaveChanges();
                    }
                }
            } 
            return uniqueFileName;
        }
        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {

            returnUrl = returnUrl ?? Url.Content("~/");
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            if (!ModelState.IsValid)
            {
                //string UploadCertifications_POC = UploadedFile(asi);
                var user = new AddSchool { UserName = Input.Email, Email = Input.Email, FirstName = Input.FirstName, Designation = Input.Designation, Address = Input.Address, PhoneNumber = Input.PhoneNumber };
                var result = await _userManager.CreateAsync(user, Input.Password);
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

                    await _emailSender.SendEmailAsync(Input.Email, "Confirm your email",
                        $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");
                    var users = new AddSchoolInfo
                    {
                        ID = asi.ID,
                        SchoolID = user.Id,
                        SchoolName = "null",
                        Address = "null",
                        PhoneNumber = "null",
                        Email = "null",
                        Name_POC = "null",
                        PhoneNumber_POC = "null",
                        Email_POC = "null",
                        Address_POC = "null",
                        HighQualification_POC = "null",
                        Designation_POC = "null",
                        UploadCertifications_POC = null,
                        UploadCv_POC = null,
                        RegisteredDate = DateTime.Now,
                        Password = "null",
                        ConfirmPassword = "null",
                        IsActive = true
                    };
                    _db.AddSchoolInfos.Add(users);
                    _db.SaveChanges();
                    UploadedFile(users.ID);
                    user.EmailConfirmed = true;
                    var addToRoleResult = await _userManager.AddToRoleAsync(user, "School");

                    if (_userManager.Options.SignIn.RequireConfirmedAccount)
                    {
                        return RedirectToPage("RegisterConfirmation", new { email = Input.Email, returnUrl = returnUrl });
                    }
                    else
                    {
                        user.EmailConfirmed = true;

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
