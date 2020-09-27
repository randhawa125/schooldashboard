using AutoMapper;
using ayush.Data;
using ayush.Models;
using ayush.Resource;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ayush.Pages.Counsellor
{
    public class StudentProfileModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly IMapper _mapper;
        public UserInformation UserInformation { get; set; }
        public IdentityUser LoggedInUser { get; set; }
        private ayushContext _context { get; set; }
        public EditUserProfile Profile { get; set; }
        public IList<UserLoginInfo> CurrentLogins { get; set; }
        public IList<AuthenticationScheme> OtherLogins { get; set; }
        public string StatusMessage { get; set; }
        public string ProfilePictureErrorMessage { get; set; }
        public bool ShowSuccess = false;
        public string UserId = string.Empty;
        public StudentProfileModel(UserManager<IdentityUser> userManager, ayushContext context, IMapper mapper, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
            _mapper = mapper;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            UserId = Request.Query["id"];
            await SetPageValues();

            return Page();
        }

        private async Task SetPageValues()
        {
            LoggedInUser = await _userManager.GetUserAsync(User);

            UserInformation = await _context.UserInformation.FirstOrDefaultAsync(x => x.UserId.Equals(LoggedInUser.Id));

            if (UserInformation == null)
            { UserInformation = new UserInformation() { DateOfBirth = null }; }

            Profile = _mapper.Map<EditUserProfile>(UserInformation);

            if (Profile != null) { Profile.PhoneNumber = LoggedInUser.PhoneNumber; }
            if (Profile != null) { Profile.Email = LoggedInUser.Email; }

            CurrentLogins = await _userManager.GetLoginsAsync(LoggedInUser);
            OtherLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync())
                .Where(auth => CurrentLogins.All(ul => auth.Name != ul.LoginProvider))
                .ToList();
        }

        public async Task<IActionResult> OnPostLinkLoginAsync(string provider)
        {
            // Clear the existing external cookie to ensure a clean login process
            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);

            // Request a redirect to the external login provider to link a login for the current user
            var redirectUrl = Url.Page("profile", pageHandler: "LinkLoginCallback");
            var properties = _signInManager.ConfigureExternalAuthenticationProperties(provider, redirectUrl, _userManager.GetUserId(User));
            return new ChallengeResult(provider, properties);
        }

        public async Task<IActionResult> OnGetLinkLoginCallbackAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID 'user.Id'.");
            }

            var info = await _signInManager.GetExternalLoginInfoAsync(user.Id);
            if (info == null)
            {
                throw new InvalidOperationException($"Unexpected error occurred loading external login info for user with ID '{user.Id}'.");
            }

            var result = await _userManager.AddLoginAsync(user, info);
            if (!result.Succeeded)
            {
                StatusMessage = "The external login was not added. External logins can only be associated with one account.";
                return RedirectToPage();
            }

            // Clear the existing external cookie to ensure a clean login process
            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);

            StatusMessage = "The external login was added.";

            ShowSuccess = false;

            return RedirectToPage();
        }

        public async Task<IActionResult> OnPostRemoveLoginAsync(string loginProvider, string providerKey)
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID 'user.Id'.");
            }

            var result = await _userManager.RemoveLoginAsync(user, loginProvider, providerKey);
            if (!result.Succeeded)
            {
                StatusMessage = "The external login was not removed.";
                return RedirectToPage();
            }

            await _signInManager.RefreshSignInAsync(user);
            StatusMessage = "The external login was removed.";
            ShowSuccess = false;
            return RedirectToPage();
        }

        public async Task<IActionResult> OnPost(EditUserProfile profile)
        {
            LoggedInUser = await _userManager.GetUserAsync(User);
            UserInformation = await _context.UserInformation.FirstOrDefaultAsync(x => x.UserId.Equals(LoggedInUser.Id));

            if (!ModelState.IsValid)
            {
                Profile = profile;
                await SetPageValues();
                return Page();
            }

            //Update user mobile number
            LoggedInUser.PhoneNumber = profile.PhoneNumber;
            LoggedInUser.Email = profile.Email;
            await _userManager.UpdateAsync(LoggedInUser);

            if (profile.ClassName != "11th" || profile.ClassName != "12th")
            {
                profile.Subject1 = null;
                profile.Subject2 = null;
                profile.Subject3 = null;
                profile.Subject4 = null;
                profile.Subject5 = null;
            }

            //Update user information
            UserInformation = _mapper.Map(profile, UserInformation);
            UserInformation.UserId = LoggedInUser.Id;
            _context.UserInformation.Update(UserInformation);
            await _context.SaveChangesAsync();

            ShowSuccess = true;

            await SetPageValues();

            return Page();
        }

        public async Task<IActionResult> OnPostUpdateProfilePicture()
        {
            if (Request.Form.Files.Any())
            {
                var file = Request.Form.Files[0];

                if (file.Length > 200000)
                {
                    ProfilePictureErrorMessage = "File should be less than 200KB";
                    await SetPageValues();
                    return Page();
                }

                var randomFileName = Guid.NewGuid() + Path.GetExtension(file.FileName);

                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads", randomFileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }

                var user = await _userManager.GetUserAsync(User);
                var userInfo = _context.UserInformation.FirstOrDefault(x => x.UserId == user.Id);
                userInfo.ProfilePictureFilePath = randomFileName;
                await _context.SaveChangesAsync();
            }
            ShowSuccess = false;
            return RedirectToPage();
        }
    }
}
