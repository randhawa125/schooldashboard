using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
////using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using ayush.Data;
using ayush.Models;
using ayush.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ayush.Areas.Identity.Pages.Account
{
    public class ForgotPasswordPhoneModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ISmsService _smsService;

        public ForgotPasswordPhoneModel(UserManager<IdentityUser> userManager, ISmsService smsService, ayushContext context)
        {
            _userManager = userManager;
            _smsService = smsService;
            _context = context;
        }

        private ayushContext _context { get; set; }

        [BindProperty]
        public PhoneInputModel Input { get; set; }

        public class PhoneInputModel
        {
            [Required]
            public string Phone { get; set; }
        }
        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                if (IsNumeric(Input.Phone))
                {
                    var user = await _userManager.Users.FirstOrDefaultAsync(x => x.PhoneNumber == Input.Phone);
                    if (user == null)
                    {
                        Random generator = new Random();
                        string code = generator.Next(0, 999999).ToString("D6");

                        var otp = new OneTimePassword() { Key = user.PhoneNumber, Value = code, CreatedOn = DateTime.Now };
                        await _context.OneTimePasswords.AddAsync(otp);
                        await _context.SaveChangesAsync();

                        string message = $"Your UPCLASS OTP is {code}. This code is valid for next 15 minutes only.";
                        _smsService.SendSMS(message, user.PhoneNumber);

                        return RedirectToPage("./ForgotPasswordConfirmation");
                    }
                    else
                    {
                        return Page();
                    }
                }
                else
                {
                    return Page();
                }
            }
            else
            {
                return Page();
            }
        }

        private bool IsNumeric(string email)
        {
            if (int.TryParse(email, out int result))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
