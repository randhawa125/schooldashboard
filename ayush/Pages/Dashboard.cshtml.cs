using ayush.Data;
using ayush.Models;
using ayush.Models.ViewModels;
using ayush.Services;
using ayush.Models.admin;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using System.Net.Mail;

namespace ayush.Pages
{
    [AllowAnonymous]
    public class DashboardModel : PageModel
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ILogger<DashboardModel> _logger;
        private readonly IEmailSender _emailSender;
        private ayushContext _context { get; set; }

        public List<NotificationViewModel> Notifications { get; set; }
        public List<BlogViewModel> Blogs { get; set; }
        public string ProfileCompletionPercentage { get; set; }

        public DashboardModel(UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            ILogger<DashboardModel> logger,
            IEmailSender emailSender,
            ayushContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
            _context = context;
        }

        private List<BlogViewModel> GetBlogs()
        {
            return _context.Blogs.Take(4).ToList().Select(x => new BlogViewModel()
            {
                Id = x.Id,
                IsActive = x.IsActive,
                ClassId = x.ClassId,
                Description = x.Description,
                Title = x.Title,
                FeaturedImagePath = x.FeaturedImagePath,
                SubmittedDate = x.SubmittedDate,
                SubmittedByUserId = x.SubmittedByUserId,
                SubmittedByUserFullName = GetUserFullname(x.SubmittedByUserId)
            }).Where(x => x.IsActive).OrderBy(x => x.SubmittedDate).ToList();
        }

        public string GetUserFullname(string userId)
        {
            var user = _context.UserInformation.FirstOrDefault(x => x.UserId == userId);
            if (user != null)
                return user.Firstname + " " + user.Lastname;
            else
                return "";
        }

        private List<NotificationViewModel> GetNotifications()
        {
            return _context.Notifications.ToList().Select(x => new NotificationViewModel()
            {
                Id = x.Id,
                Title = x.Title,
                CreatedByUserId = x.CreatedByUserId,
                CreatedDate = x.CreatedDate,
                Description = x.Description,
                IsActive = x.IsActive,
                CreatedByUserFullName = GetUserFullname(x.CreatedByUserId)
            }).Where(x => x.EndDate < DateTime.Now && x.IsActive).OrderBy(x => x.CreatedDate).ToList();
        }

        //private async Task<string> CalculatePercentage()
        //{
        //    string percetange = "";
        //    double availableValue = 0;
        //    double value = 0;

        //    LoggedInUser = await _userManager.GetUserAsync(User);
        //    UserInformation = await _context.UserInformation.FirstOrDefaultAsync(x => x.UserId.Equals(LoggedInUser.Id));

        //    if (LoggedInUser != null)
        //    { if (!string.IsNullOrEmpty(LoggedInUser.PhoneNumber)) { availableValue += 1; } }

        //    if (UserInformation != null)
        //    {
        //        if (!string.IsNullOrEmpty(UserInformation.Firstname))
        //        { availableValue += 1; }

        //        if (UserInformation.DateOfBirth.HasValue)
        //        { availableValue += 1; }

        //        if (!string.IsNullOrEmpty(UserInformation.Lastname))
        //        { availableValue += 1; }

        //        if (!string.IsNullOrEmpty(UserInformation.Gender))
        //        { availableValue += 1; }

        //        if (!string.IsNullOrEmpty(UserInformation.Address))
        //        { availableValue += 1; }

        //        if (!string.IsNullOrEmpty(UserInformation.ClassName))
        //        { availableValue += 1; }

        //        if (!string.IsNullOrEmpty(UserInformation.SchoolName))
        //        { availableValue += 1; }

        //        if (!string.IsNullOrEmpty(UserInformation.FatherName))
        //        { availableValue += 1; }

        //        if (!string.IsNullOrEmpty(UserInformation.MotherName))
        //        { availableValue += 1; }

        //        if (!string.IsNullOrEmpty(UserInformation.FatherProfession))
        //        { availableValue += 1; }

        //        if (!string.IsNullOrEmpty(UserInformation.MotherProfession))
        //        { availableValue += 1; }

        //        if (!string.IsNullOrEmpty(UserInformation.FatherQualification))
        //        { availableValue += 1; }

        //        if (!string.IsNullOrEmpty(UserInformation.MotherQualification))
        //        { availableValue += 1; }
        //    }

        //    value = (availableValue / 14) * 100;
        //    percetange = Convert.ToInt32(value).ToString() + "%";

        //    return percetange;
        //}

        [BindProperty]
        public InputModel Input { get; set; }
        public string ReturnUrl { get; set; }
        public IList<AuthenticationScheme> ExternalLogins { get; set; }
        public class InputModel
        {
            //[Required]
            //[EmailAddress]
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

            [Required]
            [Display(Name = "Last Name")]
            public string LastName { get; set; }

            [Display(Name = "Class Name")]
            public string ClassName { get; set; }

            [Display(Name = "School Name")]
            public string SchoolName { get; set; }

            [Display(Name = "Address")]
            public string Address { get; set; }

            //[Required]
            [Display(Name = "Phone Number")]
            public string PhoneNumber { get; set; }

            [Required(ErrorMessage = "Date Of Birth is required")]
            [Display(Name = "Date Of Birth")]
            public DateTime DateOfBirth { get; set; }

            [Display(Name = "Father Name")]
            public string FatherName { get; set; }

            [Display(Name = "Mother Name")]
            public string MotherName { get; set; }

            [Display(Name = "Father Qualification")]
            public string FatherQualification { get; set; }

            [Display(Name = "Mother Qualification")]
            public string MotherQualification { get; set; }

            [Display(Name = "Father Professione")]
            public string FatherProfession { get; set; }

            [Display(Name = "Mother Profession")]
            public string MotherProfession { get; set; }

            [Display(Name = "Gender")]
            public string Gender { get; set; }
            public string InvitedByUserId { get; set; }
            public bool IsPhoneNumberUsed { get; set; }
            [Display(Name = "Subject 1")]
            public string Subject1 { get; set; }
            [Display(Name = "Subject 2")]
            public string Subject2 { get; set; }
            [Display(Name = "Subject 3")]
            public string Subject3 { get; set; }
            [Display(Name = "Subject 4")]
            public string Subject4 { get; set; }
            [Display(Name = "Subject 5")]
            public string Subject5 { get; set; }
        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

            Notifications = GetNotifications();

            Blogs = GetBlogs();

            // ProfileCompletionPercentage = await CalculatePercentage();

            //return Page();
        }
      

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

            if (string.IsNullOrEmpty(Input.Email) == false)
            {
                try
                {
                    new MailAddress(Input.Email);

                    if (_context.Users.Any(x => x.Email == Input.Email))
                    {
                        ModelState.AddModelError("Email", "Email already exists");
                    }
                }
                catch
                {
                    ModelState.AddModelError("Email", "Invalid Email Format");
                }                
            }

            if (ModelState.IsValid)
            {
                var user = new BaseUser { UserName = Input.Email, Email = Input.Email, PhoneNumber = Input.PhoneNumber, EmailConfirmed = true };
                if (Input.IsPhoneNumberUsed) { user.UserName = Input.PhoneNumber; }
                var result = await _userManager.CreateAsync(user, Input.Password);

                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, "Student");

                    var info = new UserInformation { UserId = user.Id, Firstname = Input.FirstName, Lastname = Input.LastName, Address = Input.Address, ClassName = Input.ClassName, CreatedOn = DateTime.Now, InvitedByUserId = Input.InvitedByUserId };

                    if(Input.ClassName == "11th" || Input.ClassName == "12th" || Input.ClassName == "Undergraduate")
                    {
                        info.Subject1 = Input.Subject1;
                        info.Subject2 = Input.Subject2;
                        info.Subject3 = Input.Subject3;
                        info.Subject4 = Input.Subject4;
                        info.Subject5 = Input.Subject5;
                    }

                    await _context.UserInformation.AddAsync(info);
                    await _context.SaveChangesAsync();

                    await _signInManager.SignInAsync(user, isPersistent: false);
                    return LocalRedirect("~/Student/Dashboard");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

            Notifications = GetNotifications();

            Blogs = GetBlogs();
            return Page();
        }
    }
}