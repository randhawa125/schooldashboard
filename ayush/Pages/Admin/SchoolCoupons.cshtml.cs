using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ayush.Data;
using ayush.Models.admin;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ayush.Pages.Admin
{
    public class SchoolCouponsModel : PageModel
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ILogger<add_adminModel> _logger;
        private readonly IEmailSender _emailSender;
        private readonly ayushContext _db;
        public SchoolCouponsModel(ayushContext db,
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
        public AddSchoolCoupons asc { get; set; }
        public string ReturnUrl { get; set; }
        public IList<AuthenticationScheme> ExternalLogins { get; set; }
        public List<AddSchoolCoupons> SchoolCouponsList { get; set; }
        public void OnGet()
        {
            var data = (from schoolcouponlist in _db.SchoolCoupons
                        select schoolcouponlist).ToList();

            SchoolCouponsList = data;
        }
        public async Task<IActionResult> OnPostAsync()
        {
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            for (int count = 0; count <= asc.NumberOfCoupons; count++)
            {
                if (ModelState.IsValid)
                {
                    var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
                    var stringChars = new char[6];
                    var random = new Random();
                    // for (int j=0;j>=asc.NumberOfCoupons;j++)
                    //{
                    for (int i = 0; i < stringChars.Length; i++)
                    {
                        stringChars[i] = chars[random.Next(chars.Length)];
                    }

                    var finalString = new String(stringChars);
                    var users = new AddSchoolCoupons
                    {
                        ID = asc.ID,
                        SchoolID = asc.SchoolID,
                        NumberOfCoupons = asc.NumberOfCoupons,
                        IssueDate = DateTime.Now,
                        CouponNumber = finalString,
                        IsActive = true

                    };



                    _db.SchoolCoupons.Add(users);
                    _db.SaveChanges();





                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}
