using ayush.Data;
using ayush.Models;
using ayush.Models.ViewModels;
using ayush.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ayush.Pages.Counsellor
{
    public class DashboardModel : PageModel
    {
        public List<NotificationViewModel> Notifications { get; set; }
        public List<BlogViewModel> Blogs { get; set; }
        private readonly UserManager<IdentityUser> _userManager;
        public UserInformation UserInformation { get; set; }
        public IdentityUser LoggedInUser { get; set; }
        private ayushContext _context { get; set; }
        public string ProfileCompletionPercentage { get; set; }
        private SmsService _smsService { get; set; }

        public DashboardModel(UserManager<IdentityUser> userManager, ayushContext context, SmsService smsService)
        {
            _userManager = userManager;
            _context = context;
            _smsService = smsService;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            Notifications = GetNotifications();

            Blogs = await GetBlogs();

            ProfileCompletionPercentage = await CalculatePercentage();

            return Page();
        }

        private async Task<List<BlogViewModel>> GetBlogs()
        {
            var userId = User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier).Value;

            var userInfo = await _context.UserInformation.FirstOrDefaultAsync(x => x.UserId.Equals(userId));

            return _context.Blogs.ToList().Select(x => new BlogViewModel()
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
            })
                .Where(x => x.IsActive && (x.ClassId == "Public"))
                .OrderBy(x => x.SubmittedDate).ToList();
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

        private async Task<string> CalculatePercentage()
        {
            string percetange = "";
            double availableValue = 0;
            double value = 0;

            LoggedInUser = await _userManager.GetUserAsync(User);
            UserInformation = await _context.UserInformation.FirstOrDefaultAsync(x => x.UserId.Equals(LoggedInUser.Id));

            if (LoggedInUser != null)
            { if (!string.IsNullOrEmpty(LoggedInUser.PhoneNumber)) { availableValue += 1; } }

            if (UserInformation != null)
            {
                if (!string.IsNullOrEmpty(UserInformation.Firstname))
                { availableValue += 1; }

                if (UserInformation.DateOfBirth.HasValue)
                { availableValue += 1; }

                if (!string.IsNullOrEmpty(UserInformation.Lastname))
                { availableValue += 1; }

                if (!string.IsNullOrEmpty(UserInformation.Gender))
                { availableValue += 1; }

                if (!string.IsNullOrEmpty(UserInformation.Address))
                { availableValue += 1; }

                if (!string.IsNullOrEmpty(UserInformation.ClassName))
                { availableValue += 1; }

                if (!string.IsNullOrEmpty(UserInformation.SchoolName))
                { availableValue += 1; }

                if (!string.IsNullOrEmpty(UserInformation.FatherName))
                { availableValue += 1; }

                if (!string.IsNullOrEmpty(UserInformation.MotherName))
                { availableValue += 1; }

                if (!string.IsNullOrEmpty(UserInformation.FatherProfession))
                { availableValue += 1; }

                if (!string.IsNullOrEmpty(UserInformation.MotherProfession))
                { availableValue += 1; }

                if (!string.IsNullOrEmpty(UserInformation.FatherQualification))
                { availableValue += 1; }

                if (!string.IsNullOrEmpty(UserInformation.MotherQualification))
                { availableValue += 1; }
            }

            value = (availableValue / 14) * 100;
            percetange = Convert.ToInt32(value).ToString() + "%";

            return percetange;
        }
    }
}
